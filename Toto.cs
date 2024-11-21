using System.Runtime.CompilerServices;
using System.Text;

namespace Toto
{

    class toto
    {
        public int ev;
        public int het;
        public int fordulo;
        public int darab;
        public int fonyeremeny;
        public string eredmeny;

        public toto(string line)
        {
            string[] parts = line.Split(";");
            this.ev = int.Parse(parts[0]);
            this.het = int.Parse(parts[1]);
            this.fordulo = int.Parse(parts[2]);
            this.darab = int.Parse(parts[3]);
            this.fonyeremeny = int.Parse(parts[4]);
            this.eredmeny = parts[5];
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(path: "toto.txt", encoding: Encoding.UTF8);

            string line;
            List<toto> adatok = new List<toto>();

            sr.ReadLine();
            while ((line = sr.ReadLine()) != null)
            {
                adatok.Add(new(line));
            }
            Console.WriteLine($"{adatok.Count} forduló adatai találhatóak benne.");

            int ossz = 0;
            foreach (toto adat in adatok)
            {
                ossz += adat.darab;
            }
            Console.WriteLine($"{ossz} ennyi van.");

           //5
           double osszeg = 0;
           double darabszam = 0;
            
            foreach (toto adat in adatok)
            {
                osszeg += adat.fonyeremeny * adat.darab;
                darabszam += adat.darab;
            }
            Console.WriteLine($"5. feladat: Átlag: {Math.Round(osszeg / adatok.Count)} db");

            // 6.
            toto min = adatok[0];
            toto max = adatok[0];

            foreach ( toto adat in adatok)
            {
                if(adat.fonyeremeny < min.fonyeremeny) { min = adat;}
                if(adat.fonyeremeny > max.fonyeremeny) { max = adat;}
            }

            Console.WriteLine("Legnagyobb: ");
            Console.WriteLine($"Év: {max.ev}");
            Console.WriteLine($"Hét: {max.het}");
            Console.WriteLine($"Forduló: {max.fordulo}");
            Console.WriteLine($"Telitalálat: {max.darab} db");
            Console.WriteLine($"Nyeremény: {max.fonyeremeny} Ft");
            Console.WriteLine($"Eredmények: {max.eredmenyek}");
            Console.WriteLine();
            Console.WriteLine("Legkisebb: ");
            Console.WriteLine($"Év: {min.ev}");
            Console.WriteLine($"Hét: {min.het}");
            Console.WriteLine($"Forduló: {min.fordulo}");
            Console.WriteLine($"Telitalálat: {min.darab} db");
            Console.WriteLine($"Nyeremény: {min.fonyeremeny} Ft");
            Console.WriteLine($"Eredmények: {min.eredmenyek}");
        }
    }
}