using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1__LINQ.Models
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        //relation
        public Teacher Teacher { get; set; }
    }
}
