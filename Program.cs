using System;

namespace Staticke_klase
{
    class Program
    {
        static void Main(string[] args)
        {
            Nizovi.generisi(15);
            Console.WriteLine("Ispis clanova niza: ");
            Nizovi.ispis();

            Console.ReadLine();

            Console.WriteLine("Ispis parnih clanova niza: ");
            Nizovi.ispisParnosti(Nizovi.Parnost.Parno);
            Console.ReadLine();

            Console.WriteLine("Ispis neparnih clanova niza: ");
            Nizovi.ispisParnosti(Nizovi.Parnost.Neparno);
            Console.ReadLine();

            Nizovi.prosek();
            Console.ReadLine();

            Console.WriteLine("Prosek parnih clanova niza: ");
            Console.WriteLine(Nizovi.prosekParnosti(Nizovi.Parnost.Parno));
            Console.ReadLine();

            Console.WriteLine("Prosek neparnih clanova niza: ");
            Console.WriteLine(Nizovi.prosekParnosti(Nizovi.Parnost.Neparno));

            Console.ReadLine();
        }
    }
}
