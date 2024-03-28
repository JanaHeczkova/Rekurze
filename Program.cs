namespace Rekurze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mocnina mocnina = new Mocnina();
            Console.WriteLine(mocnina.SpocitejMocninu(4, 10));

            CifernySoucet cifernySoucet = new CifernySoucet();
            Console.WriteLine(cifernySoucet.SpocitejCifernySoucet(98763));
        }
    }
}