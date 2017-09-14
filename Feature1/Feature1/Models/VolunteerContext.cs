using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Feature1.Models
{
	public class VolunteerContext : DbContext
	{
		public DbSet<Volunteer> Volunteers { get; set; }
	}
}