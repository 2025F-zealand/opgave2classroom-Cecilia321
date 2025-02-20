using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ClassRoomNet60.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        [DataRow("Cilla", 3, 14, "Forår")]
        [DataRow("Rebekka", 2, 14, "Vinter")]
        [DataRow("Sara", 6, 14, "Sommer")]
        [DataRow("Mikkel", 10, 14, "Efterår")]
        [DataRow("Wes", 13, 14, "Vinter")] //denne skal fejle
        public void SeasonTest(string name, int birthMorth, int birthDay, string expectedSeason)
        {
            //Arrange 
            Student st = new Student(name, birthMorth, birthDay);

            //Act
            string actual = st.Season();

            //Assert
            Assert.AreEqual(expectedSeason, actual);

        }
    


    
        [TestMethod()]
        public void SeasonTestFail()
        {
            //arrange 
            
            //Act + Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Student("Kim", 13, 14));

        }
    }
}