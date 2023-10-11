namespace cwiczenia
{
    class Program
    {
        
        static void Main(string[] args)
        {
            p12();
        }
        static void p12()
        {
            Console.Write("Podaj promień: ");
            double r = Double.Parse(Console.ReadLine());
            double obwod = 2 * Math.PI * r;
            Console.WriteLine("Obwód wynosi: {0:0.##}", obwod);
        }
    }

}