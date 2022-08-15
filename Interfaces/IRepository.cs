using myBlog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myBlog.Interfaces
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int id);
        Task<bool> SaveChangesAsync();
    }
}
