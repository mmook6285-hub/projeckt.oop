using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalSystem
{
    internal class Doctor : Persone
    {
        public Doctor(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override void printData()
        {
            Console.WriteLine($"this Id : {ID} \nthis Nmae : {Name} \nthis Age :{Age} \nthis is Gender : {Gender}");
            Console.WriteLine("---------------------------g-------------------------------");

        }
    }
}
