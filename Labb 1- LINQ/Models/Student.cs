using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1__LINQ.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public Course Courrse { get; set; }
        public int CourseId { get; set; }
    }
}
