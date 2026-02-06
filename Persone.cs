using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalSystem
{
    internal class Persone
    {
        private  int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        static int  id = 0;
        //Creat Constrctor
        public Persone(string name , int age, string gender)
        {
            id++;
            ID = id;
            Name = name;
            Age = age;
            Gender = gender;
            
        }
        public void printData() {
            Console.WriteLine($"this Id : {ID} \nthis Nmae : {Name} \nthis Age :{Age} \nthis is Gender : {Gender}");
            Console.WriteLine("---------------------------g-------------------------------");
        
        }
    }
}
