using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        public string Name { get; private set; }
        private int birthMonth;
        public int BirthDay { get; private set; }


        public int BirthMonth
        {
            get => birthMonth;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "skal være mellem 1 og 12");
                }

                birthMonth = value;
            } // BirthMonth skal være mellem 1 og 12, ellers kastes en ArgumentOutOfRangeException
        }

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }
       

        
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
