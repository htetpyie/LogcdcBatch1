using Microsoft.AspNetCore.Mvc;

namespace LogcdcBatch1.Backend.Features.Blog
{
    public static class BlogEndpoint
    {
        public static void MapBlogEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/blogs", async ([FromServices] BlogService blogService) =>
            {
                var lst = await blogService.GetBlogs();
                return Results.Ok(lst);
            });
        }
    }
}
