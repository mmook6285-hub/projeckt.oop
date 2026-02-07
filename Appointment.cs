using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalSystem
{
    internal class Appointment : LLnterface
    {
        List<Doctor> doctors;
        public Appointment() { 
        
        doctors = new List<Doctor>();
        }
        public void AddDoctor(Doctor doctor) { 
                doctors.Add(doctor);
        }

        public void RemoveDoctor(string doctor)
        { doctors.RemoveAll( p => p.Name == doctor ); }

        public  void PrintData() {


            foreach (Doctor item in doctors)
            {
                Console.WriteLine( $"this id : {item.IdDoctor} \nthis is name  : {item.Name} \nthis is Age : {item.Age} \nthis is Gender : {item.Gender}");
                Console.WriteLine("--------------------------D------------------------------");
            
            }
        
        
        
        
        
        }






    }
}
