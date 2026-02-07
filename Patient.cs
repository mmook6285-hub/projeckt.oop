using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalSystem
{
    internal class Patient : Persone , LLnterface
    {
        public int IdPatient{ get;private set; }

        public Patient(string name, int age, string gender) : base(name, age, gender)
        {
            IdPatient = ID;

        }
        
        public  void PrintData()
        {
            Console.WriteLine($"this IdPatient : {ID} \nthis Nmae patint : {Name} \nthis Age patint :{Age} \nthis is Gender patint : {Gender} ");
            Console.WriteLine("----------------------------------------------------------");
        }
        
    }
}
