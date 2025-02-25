using api.Dtos.Comment;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IStockRepository _stockRepository;

        public CommentController(ICommentRepository commentRepository, IStockRepository stockRepository)
        {
            _commentRepository = commentRepository;
            _stockRepository = stockRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAll()
        {
            var comments = await _commentRepository.GetAllAsync();
            
            return Ok(comments);
        }

        [HttpGet("{id:int}")]
        [Authorize]
        public async Task<ActionResult> GetById(int id)
        {
            var comment = await _commentRepository.GetByIdAsync(id);

            if (comment == null) return NotFound("Comment not found");
            
            return Ok(comment);
        }

        [HttpPost("{stockId:int}")]
        [Authorize]
        public async Task<ActionResult> Create([FromRoute] int stockId, [FromBody] CreateCommentRequestDto commentDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            if (!await _stockRepository.StockExists(stockId)) return BadRequest("Stock does not exist");
            
            var commentModel = commentDto.ToCommentFromCreate(stockId);
            
            await _commentRepository.CreateAsync(commentModel);
            
            return CreatedAtAction(nameof(GetById), new { id = commentModel.Id }, commentModel.ToComment());
        }

        [HttpPut("{id:int}")]
        [Authorize]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentRequestDto commentDto)
        {
            if (!ModelState.IsValid) return BadRequest();
            
            var commentModel = await _commentRepository.UpdateAsync(id, commentDto.ToCommentFromUpdate());

            return commentModel != null ? Ok(commentModel) : NotFound("Comment not found");
        }
    
        [HttpDelete("{id:int}")]
        [Authorize]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var commentModel = await _commentRepository.DeleteAsync(id);
            
            return commentModel != null ? Ok(commentModel) : NotFound("Comment not found");
        }
    }
}
