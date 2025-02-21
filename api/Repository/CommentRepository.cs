using api.Data;
using api.Dtos.Comment;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<CommentDto>> GetAllAsync()
        {
            var comments = await _context.Comments.ToListAsync();
            
            var commentDto = comments.Select(comment => comment.ToCommentDto());
            
            return commentDto;
        }

        public async Task<CommentDto?> GetByIdAsync(int id)
        {
            var comment = await _context.Comments.FindAsync(id);

            return comment?.ToCommentDto() ?? null;
        }

        public async Task<Comment> CreateAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            
            return comment;
        }
    }
}

