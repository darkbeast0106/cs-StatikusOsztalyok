using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikusOsztalyok
{
    internal static class Veletlen
    {
        private static Random RND = new Random();
        private static List<string> vezetekNevek = Feltolt("files/veznev.txt");
        private static List<string> ferfiKeresztNevek = Feltolt("files/ferfikernev.txt");
        private static List<string> noiKeresztNevek = Feltolt("files/noikernev.txt");
        private static List<string> Feltolt(string fajlnev)
        {
            List<string> list = new List<string>();
            using (var reader = new StreamReader(fajlnev))
            {
                while (!reader.EndOfStream)
                {
                    list.Add(reader.ReadLine());
                }
            }
            return list;
        }

        public static int VelEgesz(int min, int max)
        {
            return RND.Next(min, max + 1);
        }

        public static char VelKarakter(char min, char max)
        {
            return (char)VelEgesz(min, max);
        }

        public static string velVezetekNev()
        {
            return vezetekNevek[RND.Next(vezetekNevek.Count)];
        }

        /// <summary>
        /// Véletlen keresztnevet generáló függvény
        /// </summary>
        /// <param name="nem">A generált keresztnév neme: férfi - false || nő - true</param>
        /// <returns>Generált véletlen keresztnév</returns>
        public static string velKeresztNev(bool nem)
        {
            string keresztNev;
            if (nem)
            {
                keresztNev = velNoiKeresztNev();
            } 
            else
            {
                keresztNev = velFerfiKeresztNev();
            }
            return keresztNev;
        }

        private static string velFerfiKeresztNev()
        {
            return ferfiKeresztNevek[RND.Next(ferfiKeresztNevek.Count)];
        }

        private static string velNoiKeresztNev()
        {
            return noiKeresztNevek[RND.Next(noiKeresztNevek.Count)];
        }

        /// <summary>
        /// Véletlen nevet generáló függvény
        /// </summary>
        /// <param name="nem">A generált név neme: férfi - false || nő - true</param>
        /// <returns>Generált véletlen név</returns>
        public static string velTeljesNev(bool nem)
        {
            return velVezetekNev() + " " + velKeresztNev(nem);
        }
    }
}
