using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registrations.Models
{
    public class DayAtDaddyWork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Display(Name = "Employee ID")]
        public string IDNumber { get; set; }
        [Display(Name = "Name")]
        public string ChildName { get; set; }
        [Display(Name = "Age")]
        [Range(7,13)]
        public int ChildAge { get; set; }
        [Display(Name = "Gender")]
        public int ChildGender { get; set; }
        [Display(Name = "T-Shirt Size")]
        public int ChildSize { get; set; }
    }
}