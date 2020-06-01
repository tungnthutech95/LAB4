using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }

        public string LecturerID { get; set; }

        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public Category category { get; set; }
        public byte CategoryId { get; set; }

    }
}