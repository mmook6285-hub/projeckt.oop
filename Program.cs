namespace hospitalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone p1 =new Persone("atta",25, "male");
            Persone p2 = new Persone("mody",13,"femal");
            Doctor d1=new Doctor("DR khalil",2,"fa");
            Doctor d2=new Doctor("DR atta",2,"fa");
            Doctor d3=new Doctor("DR medo",2,"fa");
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(d1);
            doctors.Add(d2);
            doctors.Add(d3);
            foreach (Doctor doctor in doctors) {
                Console.WriteLine($"the Name Doctor is : {doctor.Name} the Gendr : {doctor.Gender}");
            }
            d1.printData();
            p2.printData();
         
        }
    }
}
