using System.Xml.Linq;

namespace hospitalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appointment p = new Appointment();
            p.AddDoctor(new Doctor("wael",31,"meal"));
            p.AddDoctor(new Doctor("atta", 31, "meal"));
            p.AddDoctor(new Doctor("ebrahim", 31, "meal"));
            p.AddDoctor(new Doctor("wael", 31, "meal"));
            p.RemoveDoctor("atta");
            p.PrintData();




            PatintMangmint manager = new PatintMangmint();
            manager.AddPatient(new Patient( "Ali", 30, "Flu"));
            manager.AddPatient(new Patient( "Sara", 28888885, "Diabetes"));
            manager.AddPatient(new Patient("q",2,"dq"));
            manager.DelForName("Sara");
            Console.WriteLine("Enter Name for Search By Name :");
            string searchName = Console.ReadLine();
            var fin=manager.FindPatintForName(searchName);
  
            if (fin != null)
            {
                Console.WriteLine("Finded patint");
                Console.WriteLine(fin.Name);
            }
            else {

                Console.WriteLine("not Fund"); 
            }
   manager.PrintData();
        }
   
    
    
    }
}
