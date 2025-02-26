using api.Data;
using api.Dtos.Comment;
using api.Extensions;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository(ApplicationDbContext context, UserManager<AppUser> userManager) : ICommentRepository
    {
        public async Task<IEnumerable<CommentDto>> GetAllAsync()
        {
            var comments = await context.Comments
                .Include(c => c.AppUser).
                ToListAsync();
            
            var commentDto = comments.Select(comment => comment.ToComment());
            
            return commentDto;
        }

        public async Task<CommentDto?> GetByIdAsync(int id)
        {
            var commentDto = await context.Comments
                .Include(c => c.AppUser)
                .FirstOrDefaultAsync(c => c.Id == id);

            return commentDto?.ToComment() ?? null;
        }

        public async Task<Comment?> CreateAsync(CreateCommentRequestDto commentDto, int stockId, string username)
        {
            var appUser = await userManager.FindByNameAsync(username);
            
            if (appUser == null) return null;

            var commentModel = commentDto.ToCommentFromCreate(stockId);
            
            commentModel.AppUserId = appUser?.Id;
            
            await context.Comments.AddAsync(commentModel);

            await context.SaveChangesAsync();
            
            return commentModel;
        }

        public async Task<Comment?> UpdateAsync(int id, Comment commentModel)
        {
            var existingComment = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);

            if (existingComment == null) return null;
            
            existingComment.Title = commentModel.Title;
            existingComment.Content = commentModel.Content;
            
            await context.SaveChangesAsync();
            
            return existingComment;
        }

        public async Task<Comment?> DeleteAsync(int id)
        {
            var comment = await context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            
            if (comment == null) return null;
            
            context.Comments.Remove(comment);
            
            await context.SaveChangesAsync();
            
            return comment;
        }
    }
}
