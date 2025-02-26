using api.Dtos.Comment;
using api.Extensions;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController(ICommentRepository commentRepository, IStockRepository stockRepository) : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAll()
        {
            return Ok(await commentRepository.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        [Authorize]
        public async Task<ActionResult> GetById(int id)
        {
            var comment = await commentRepository.GetByIdAsync(id);

            return comment == null ? NotFound("Comment not found") : Ok(comment);
        }

        [HttpPost("{stockId:int}")]
        [Authorize]
        public async Task<ActionResult> Create([FromRoute] int stockId, [FromBody] CreateCommentRequestDto commentDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (!await stockRepository.StockExists(stockId)) return BadRequest("Stock does not exist");

            var commentModel = await commentRepository.CreateAsync(commentDto, stockId, User.GetUsername());

            return CreatedAtAction(nameof(GetById), new { id = commentModel.Id }, commentModel.ToComment());
        }

        [HttpPut("{id:int}")]
        [Authorize]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentRequestDto commentDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var commentModel = await commentRepository.UpdateAsync(id, commentDto.ToCommentFromUpdate());

            return commentModel != null ? Ok(commentModel) : NotFound("Comment not found");
        }

        [HttpDelete("{id:int}")]
        [Authorize]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var commentModel = await commentRepository.DeleteAsync(id);

            return commentModel != null ? Ok(commentModel) : NotFound("Comment not found");
        }
    }
}