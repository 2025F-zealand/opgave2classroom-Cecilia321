using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        public string Name { get; }
        public int BirthMonth { get;}
        public int BirthDay { get;}


        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;

        }

        //There must now be implemented a method "season" the returntype is a string. The methods returns what season for the student's birthday.
        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            {
                return "Vinter";
            }
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Forår";
            }
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Sommer";
            }
            else
            {
                return "Efterår";
            }
        }
    }
}
