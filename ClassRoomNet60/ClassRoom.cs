using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }




        
        public void CountSeason()
        {
            var seasonCounts = StudentList.GroupBy(s => s.Season()) // Gruppér efter sæson
                                 .ToDictionary(g => g.Key, g => g.Count()); // Lav en dictionary med tællinger, hvor key er sæson og value er antal, nøglen bestemmes af hvad season metoden returnere. g.count dette er værdien i ordbogen, tæller antallet af studerende i hver sæsongruppe, hvilket giver antallet af studerende der har fødselsdag den pågældene sæson  

            foreach (var season in seasonCounts)
            {
                Console.WriteLine($"\n Der er {season.Value} studerende der har fødselsdag om {season.Key}");
            }
        }


    }
}
