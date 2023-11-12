using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4.models
{
    internal class person
    {
        private string name;
        private int age;

        public string Name 
        { 
            get 
            { 
                return name; 

            } 

            set    
            {
                name = value;
            } 
        }
        public int Age
        {
            get { return age; }
            set
            {

                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("yas sefdir.");
                }
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
   
}
