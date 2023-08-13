using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Fake_instagram.Context
{
    public class PostDb : DbContext
    {
        public PostDb(DbContextOptions<PostDb> options) 
        : base(options)
        {

        }
        public DbSet<Post> Posts => Set<Post>();
    }
}