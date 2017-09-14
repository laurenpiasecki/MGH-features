using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Feature3.Models
{
	public class CalendarContext : DbContext
	{
		public DbSet<Calendar> Calendars { get; set; }
	}
}
