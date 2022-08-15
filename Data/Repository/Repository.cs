using myBlog.Interfaces;
using myBlog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myBlog.Data.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddPost(Post post)
        {
            throw new System.NotImplementedException();
        }

        public List<Post> GetAllPosts()
        {
            throw new System.NotImplementedException();
        }

        public Post GetPost(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePost(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new System.NotImplementedException();
        }
    }
}
