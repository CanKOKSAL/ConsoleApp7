using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    public class Group_Class : Student
    {
        private int Exit;
        public void Consol()
        {
            do
            {
                #region
                if (Name.Length < 3)
                {
                    Console.WriteLine("Name space must be more than three letters");
                }
                if (Name.Length > 15)
                {
                    Console.WriteLine("Name space must be less than fifteen letters");
                }
                if (SurName.Length < 3)
                {
                    Console.WriteLine("Surname space must be more than three letters");
                }
                if (SurName.Length >= 15)
                {
                    Console.WriteLine("Surname space must be less than fifteen letters");
                }
                if (Average < 0)
                {
                    Console.WriteLine("Please write your average properly");
                }
                if (Average > 100)
                {
                    Console.WriteLine("Please write your average properly");
                }
                #endregion
                //if (StudentService == 1)
                //{
                //    Console.WriteLine(Menu());
                //}
                switch (StudentService)
                {
                case 1:
                    Console.WriteLine("Edit");
                    break;
                case 2:
                    Console.WriteLine("Delete");
                    break;
                case 3:
                    Console.WriteLine("Create");
                    break;
                case 4:
                    Console.WriteLine("Get all");
                 break;
                } 
                
                
            } while (Exit != 0);
        }
    }
}
