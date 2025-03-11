using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr23106_tiagnirenko_4
{
    internal class Group
    {
        [Key]
        public int idGroup { get; set; }
        public string Title { get; set; }
        public int CourseNumber { get; set; }
        public int IdSpeciality { get; set; }
    }
}
