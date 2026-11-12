using System.Security.Principal;

namespace Dolgozat
{
    internal class Program
    {
        static string[] huto = new string[10];

        static void Feltoltes()
        {
            for (int i = 0; i < huto.Length; i++)
            {
                huto[i] = "";
            }

            string valasz = "";

            do
            {
                Console.Write("1. feltölt, 2 kilép: ");
                valasz = Console.ReadLine();
                switch (valasz)
                {
                    case "1":
                        Console.Write("Kérem adja meg annak a termék nevét amit a hűtőbe kíván tenni: ");
                        string elsotermek = Console.ReadLine();
                        Berak(elsotermek);
                        break;
                    case "2":
                        Console.WriteLine("Kilépés");
                        break;
                }
            }
            while (valasz != "2");
        }

        static int Takarit()
        {
            int dbSzam = 0;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    huto[dbSzam] = huto[i];
                    dbSzam++;
                }
            }
            for (int j = dbSzam; j < huto.Length; j++)
            {
                huto[j] = "";
            }
            return dbSzam;
        }

        static int keresEtel(string etelNeve)
        {

            int index = 0;
            foreach (var item in huto)
            {
                if (etelNeve == item)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        static void mghLista()
        {
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    if ("aáeéiíoóöőüűuú".Contains(
                        char.ToLower(huto[i][0])))
                    {
                        Console.WriteLine(huto[i]);
                    }
                }
            }
        }

        private static void Berak(string elsotermek)
        {
            int i = 0;
            while (i < huto.Length && huto[i] != "")
            {
                i++;
            }
            if (i < huto.Length)
            {
                huto[i] = elsotermek;
            }
        }

        static void Eredmeny()
        {
            Feltoltes();
            Console.WriteLine($"A hűtőben {Takarit()} db-nyi termék van.");
            Console.Write("Kérem adja meg annak a termék nevét amit a hűtőben keres: ");
            string etelNeve = Console.ReadLine();
            int index = keresEtel(etelNeve);
            if (index < 0)
            {
                Console.WriteLine("Nincs ilyen étel.");
            }
            else
            {
                Console.WriteLine($"Az {index + 1} helyen van.");
            }
            mghLista();
        }

        static void Main(string[] args)
        {
            Eredmeny();
        }
    }
}
