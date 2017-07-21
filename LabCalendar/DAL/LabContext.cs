using LabCalendar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LabCalendar.DAL
{
    public class LabContext : DbContext
    {
        public LabContext() : base("LabContext")
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}