using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Feature3.Models
{
	[Table("Events_calendar")]
	public class Calendar
		{
		[Key]
		public int Id { get; set; }

		[DisplayName("Event Name")]
		[Required(ErrorMessage = "* Event name is required")]
		public string Event_name { get; set; }

		[DisplayName("Date")]
		[Required(ErrorMessage = "* Event date is required")]
		[DataType(DataType.Date)]
		public DateTime Event_date { get; set; }

		[DisplayName("Time")]
		[Required(ErrorMessage = "* Event time is required")]
		[DataType(DataType.Time)]
		public DateTime Event_time { get; set; }

		[DisplayName("Location")]
		[Required(ErrorMessage = "* Event location is required")]
		public string Event_location { get; set; }

		[DisplayName("Description")]
		[Required(ErrorMessage = "* Event description is required")]
		public string Event_desc { get; set; }
	}
}