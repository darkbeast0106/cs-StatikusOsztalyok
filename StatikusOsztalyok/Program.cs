namespace StatikusOsztalyok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Veletlen.VelKarakter('A', 'Z'));
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Veletlen.velTeljesNev(false));
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Veletlen.velTeljesNev(true));
            }
        }
    }
}