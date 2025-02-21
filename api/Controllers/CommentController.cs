using api.Dtos.Comment;
using api.Interfaces;
using api.Mappers;
using api.Models;
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
        public async Task<ActionResult<IEnumerable<Comment>>> GetAll()
        {
            var comments = await _commentRepository.GetAllAsync();
            
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CommentDto>> GetById(int id)
        {
            var comment = await _commentRepository.GetByIdAsync(id);

            if (comment == null) return NotFound();
            
            return Ok(comment);
        }

        [HttpPost("{stockId}")]
        public async Task<ActionResult<CommentDto>> Create([FromRoute] int stockId, [FromBody] CreateCommentRequestDto commentDto)
        {
            if (!await _stockRepository.StockExists(stockId)) return BadRequest("Stock does not exist");
            
            var commentModel = commentDto.ToCommentFromCreateDto(stockId);
            
            await _commentRepository.CreateAsync(commentModel);
            
            return CreatedAtAction(nameof(GetById), new { id = commentModel.Id }, commentModel.ToCommentDto());
        }
    }
}
