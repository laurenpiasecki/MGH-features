using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Feature2.Models
{
	public class BlogContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
	}
}