using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SomaliNews.Models
{
    public class NewsDbContext : DbContext
    {

        public NewsDbContext() : base("NewsConnection")
        {

        }

        public DbSet <News>  News { get; set; }
    }
}