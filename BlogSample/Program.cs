using BlogSample.Services;
using System;

namespace BlogSample
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogService blogService = new BlogService();
            var post = blogService.GetPost(1).Result;
            Console.WriteLine("Title of first post:");
            Console.WriteLine(post.Title);
            Console.WriteLine("\n");

            var numberOfPosts = blogService.GetNumberOfPosts().Result;
            Console.WriteLine("Number of all posts:");
            Console.WriteLine(numberOfPosts);
            Console.WriteLine("\n");


            var updatedPost = blogService.ChangeTitle(1, "NEW_TITLE").Result;
            Console.WriteLine("Title of updated first post:");
            Console.WriteLine(updatedPost.Title);
            Console.WriteLine("\n");
            
            var commentOwnersFromChosenPost = blogService.GetCommentsOwnersFromPost(1).Result;
            Console.WriteLine("Comment owners: ");
            commentOwnersFromChosenPost.ForEach(o => Console.WriteLine(o));
            Console.WriteLine("\n");

            var postAdded = blogService.AddPost(GeneratePost()).Result;
            Console.WriteLine("Title of added post:");
            Console.WriteLine(postAdded.Title);
            Console.WriteLine("Body of added post:");
            Console.WriteLine(postAdded.Body);
            Console.WriteLine("\n");

            Console.ReadKey();
        }

        private static Post GeneratePost()
        {
            return new Post
            {
                Title = "Refit usage",
                Body = "Refit allow you to really quickly create client libraries for Web APIs"
            };
        }
    }
}
