namespace Dolgozat
{
    internal class Program
    {
        static string[] Huto = new string[10];

        static void Takarit()
        {
            foreach (var item in Huto)
            {
                
            }
        }

        static void mghLista()
        {
            //Console.Write("Kérem adja meg annak a termék nevét amit a hűtőben keres: ");
            //string keresett = Console.ReadLine();
            //foreach (var keresett in Huto)
            //{
            //    if (keresett == Huto[])
            //}
        }
        private static void Berak(string elsotermek)
        {
            int i = 0;
            while (i < Huto.Length && Huto[i] != "")
            {
                i++;
            }
            if (i < Huto.Length)
            {
                Huto[i] = elsotermek;
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < Huto.Length; i++)
            {
                Huto[i] = "";
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
    }
}
