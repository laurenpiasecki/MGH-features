using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Feature2.Models
{
	[Table("Blogs")]
	public class Blog
	{
		[Key]
		public int Id { get; set; }

		[DisplayName("Blog Title")]
		[Required(ErrorMessage = "* Blog title is required")]
		public string Blog_title { get; set; }

		[DisplayName("Blog Author")]
		public string Blog_author { get; set; }

		[DisplayName("Blog Date")]
		[DataType(DataType.DateTime)]
		public DateTime Blog_date { get; set; } = DateTime.Now;

		[DisplayName("Blog Post")]
		[Required(ErrorMessage = "* Blog post is required")]
		public string Blog_post { get; set; }
}
}