using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        private string ClassName { get; set; }
        private List<Student> StudentList { get; set; }
        private DateTime SemesterStart { get; set; }


        public ClassRoom()
        {
            
        }
    }
}
