using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Feature1.Models
{
	[Table("Volunteers")]
	public class Volunteer
	{
		[Key]
		public int Id { get; set; }

		[DisplayName("First Name")]
		[Required(ErrorMessage = "First name is required")]
		public string Volunteer_first { get; set; }

		[DisplayName("Last Name")]
		[Required(ErrorMessage = "Last name is required")]
		public string Volunteer_last { get; set; }

		[DisplayName("Phone Number")]
		[Required(ErrorMessage = "Phone number is required")]
		[DataType(DataType.PhoneNumber)]
		public string Volunteer_phone { get; set; }

		[DisplayName("Email Address")]
		[Required(ErrorMessage = "Email address is required")]
		[DataType(DataType.EmailAddress)]
		public string Volunteer_email { get; set; }

		[DisplayName("Addtional Comments")]
		public string Volunteer_comment { get; set; }

	}
}