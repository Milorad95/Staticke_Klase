using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticke_klase
{
    static class Nizovi
    {
        public static int[] Niz = new int[0];
        public static int Brojac { get; set; }
        public static int Zbir { get; set; }

        // generisi niz duzine koja je prosledjena kao parametar
        public static void generisi(int duzina)
        {
            Random rnd = new Random();
            Niz = new int[duzina];

            for (int i = 0; i < Niz.Length; i++)
            {
                Niz[i] = rnd.Next(0, 50);
            }
        }

        // ispis clanova niza
        public static void ispis()
        {
            foreach(var clan in Niz)
            {
                Console.Write($"{clan} ");
            }
        }

        // ispis parnih ili neparnih clanova niza u zavisnosti koji je tip parnosti prosledjen kao parametar 
        public static void ispisParnosti(Parnost parnost)
        {
            if(parnost == 0)
            {
                for (int i = 0; i < Niz.Length; i++)
                {
                    if(Niz[i] % 2 == 0)
                    {
                        Console.Write($"{Niz[i]} ");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Niz.Length; i++)
                {
                    if (Niz[i] % 2 != 0)
                    {
                        Console.Write($"{Niz[i]} ");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        // prosek zbira svih clanova niza
        public static int prosek()
        {
            foreach(var broj in Niz)
            {
                Zbir += broj;
                Brojac++;
            }

            return Zbir / Brojac;
        }

        // prosek parnih ili neparnih clanova niza u zavisnosti koji je tip parnosti prosledjen kao parametar
        public static int prosekParnosti(Parnost parametar)
        {      
            if(parametar == 0)
            {
                foreach (var clan in Niz)
                {
                    if(clan % 2 == 0)
                    {
                        Zbir += clan;
                        Brojac++;
                    }
                }
            }
            else
            {
                foreach (var clan in Niz)
                {
                    if (clan % 2 != 0)
                    {
                        Zbir += clan;
                        Brojac++;
                    }
                }
            }

            return Zbir / Brojac;
        }

        public enum Parnost
        {
            Parno,
            Neparno
        }
    }
}
