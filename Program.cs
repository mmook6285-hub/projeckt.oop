namespace hospitalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone p1 =new Persone("atta",25, "male");
            Persone p2 = new Persone("mody",13,"femal");
         
            p1.printData();
            p2.printData();
         
        }
    }
}
