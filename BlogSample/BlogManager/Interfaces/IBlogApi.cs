using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogSample.BlogManager.Interfaces
{
    public interface IBlogApi
    {
        [Get("/posts/{id}")]
        Task<Post> GetPost(int id);

        [Get("/posts")]
        Task<List<Post>> GetPosts();

        [Get("/comments?postId={id}")]
        Task<List<Comment>> GetPostComments([AliasAs("id")] int postId);

        [Put("/posts/{id}")]
        Task UpdatePost(int id, [Body] Post post);

        [Post("/posts")]
        Task<Post> AddPost([Body] Post post);
    }
}
