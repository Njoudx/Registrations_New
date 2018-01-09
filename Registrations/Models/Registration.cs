using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registrations.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}