using api.Dtos.Comment;
using api.Models;

namespace api.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<CommentDto>> GetAllAsync();

        Task<CommentDto?> GetByIdAsync(int id);
        
        Task<Comment?> CreateAsync(CreateCommentRequestDto commentDto, int stockId, string username);
        
        Task<Comment?> UpdateAsync(int id, Comment comment);
        
        Task<Comment?> DeleteAsync(int id);
    }
}
