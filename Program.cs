using System.Xml.Linq;

namespace hospitalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatintMangmint manager = new PatintMangmint();
            manager.AddPatient(new Patient( "Ali", 30, "Flu"));
            manager.AddPatient(new Patient( "Sara", 28888885, "Diabetes"));
            manager.AddPatient(new Patient("q",2,"dq"));
            manager.DelForName("Sara");
            Console.WriteLine("ابحث عن مريض بالاسم:");
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
        }
    }
}
