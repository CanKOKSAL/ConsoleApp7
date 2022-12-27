using System.Threading;
using System.Xml.Linq;

namespace ConsoleApp7
{
    public class Student
    {
        public int StudentService;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public double Average { get; set; }
    

        public void Setup(string name, string Surname, double average,int id)
        {
            Name = name;
            SurName = Surname;
            Average = average;
            Id = id;
        
        }

        internal void Setup()
        {
            throw new NotImplementedException();
        }
    }
}