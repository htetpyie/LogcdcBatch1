using LogcdcBatch1.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LogcdcBatch1.Backend.Features.Blog
{
    public class BlogRepo
    {
        private readonly AppDbContext _db;

        public BlogRepo(AppDbContext db) // Constructor Injection
        {
            _db = db;
        }

        public async Task<List<TblBlog>> GetBlogs()
        {
            return await _db.TblBlogs.AsNoTracking().ToListAsync();
        }
    }
}
