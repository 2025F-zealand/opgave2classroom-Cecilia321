using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        private string name { get; }
        private int birthMonth { get;}
        private int birthDay { get;}


        public Student(string name, int birthMonth, int birthDay)
        {
            this.name = name;
            this.birthMonth = birthMonth;
            this.birthDay = birthDay;
        }
    }
}
