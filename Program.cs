namespace hospitalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone p1 =new Persone("atta",25);
            Persone p2 = new Persone("mody",13);
            Persone p3 = new Persone("mahmoud",22);
            Persone p4 = new Persone("mahmoud",22);
            Persone p5 = new Persone("mahmoud",22);
            Persone p6 = new Persone("mahmoud",22);
            p1.printData();
            p2.printData();
            p3.printData();
            p4.printData();
            p5.printData();
            p6.printData();
        }
    }
}
