using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1__LINQ.Models
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
