using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalSystem
{
    internal class Doctor : Persone , LLnterface
    {
        public int IdDoctor{ get; private set; }

        public Doctor(string name, int age, string gender) : base(name, age, gender)
        {
            IdDoctor = ID;
        }

        public void PrintData()
        {
            Console.WriteLine($"this Id : {ID} \nthis Nmae : {Name} \nthis Age :{Age} \nthis is Gender : {Gender}");
            Console.WriteLine("---------------------------g-------------------------------");

        }
    }
}
