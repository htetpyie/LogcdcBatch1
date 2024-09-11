using LogcdcBatch1.Database.Models;

namespace LogcdcBatch1.Backend.Features.Blog
{
    public class BlogService
    {
        private readonly BlogRepo _blogRepo;

        public BlogService(BlogRepo blogRepo)
        {
            _blogRepo = blogRepo;
        }

        public async Task<List<TblBlog>> GetBlogs()
        {
            return await _blogRepo.GetBlogs();
        }
    }
}
