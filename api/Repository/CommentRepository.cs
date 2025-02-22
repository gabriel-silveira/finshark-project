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
            
            var commentDto = comments.Select(comment => comment.ToComment());
            
            return commentDto;
        }

        public async Task<CommentDto?> GetByIdAsync(int id)
        {
            var commentDto = await _context.Comments.FindAsync(id);

            return commentDto?.ToComment() ?? null;
        }

        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            
            return commentModel;
        }

        public async Task<Comment?> UpdateAsync(int id, Comment commentModel)
        {
            var existingComment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);

            if (existingComment == null) return null;
            
            existingComment.Title = commentModel.Title;
            existingComment.Content = commentModel.Content;
            
            await _context.SaveChangesAsync();
            
            return existingComment;
        }

        public async Task<Comment?> DeleteAsync(int id)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            
            if (comment == null) return null;
            
            _context.Comments.Remove(comment);
            
            await _context.SaveChangesAsync();
            
            return comment;
        }
    }
}
