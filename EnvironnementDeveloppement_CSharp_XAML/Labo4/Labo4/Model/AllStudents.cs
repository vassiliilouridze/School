using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4.Model
{
    public static class AllStudents
    {
        public static IEnumerable<Student> Students { get; set; }

        public static IEnumerable<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student ("student 1",20),
                new Student ("student 2",21),
                new Student ("student 3",18),
            };
        }
    }
}
