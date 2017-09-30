using BlogSample.Services.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogSample.Services
{
    public class BlogService
    {
        private readonly string _apiAddress = "https://jsonplaceholder.typicode.com";
        private readonly IBlogApi _blogApi;

        public BlogService()
        {
            _blogApi = RestService.For<IBlogApi>(_apiAddress);
        }

        public async Task<Post> GetPost(int index)
        {            
            var post = await _blogApi.GetPost(index);
            return post;
        }

        public async Task<int> GetNumberOfPosts()
        {           
            var posts = await _blogApi.GetPosts();
            return posts.Count;
        }

        public async Task<Post> ChangeTitle(int index, string newTitle)
        {
            var post = await GetPost(index);
            post.Title = newTitle;
            await _blogApi.UpdatePost(index, post);
            return post;
        }

        public async Task<List<String>> GetCommentsOwnersFromPost(int postId)
        {
            var comments = await _blogApi.GetPostComments(postId);
            var owners = new List<string>();
            foreach (var comment in comments)
            {
                if (!owners.Contains(comment.Owner)) owners.Add(comment.Owner);
            }
            return owners;
        }

        public async Task<Post> AddPost(Post post)
        {
            var postAdded = await _blogApi.AddPost(post);
            return postAdded;
        }
    }
}
