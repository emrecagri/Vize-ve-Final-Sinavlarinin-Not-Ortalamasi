using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeveFinaldenNotOrtalamasiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize, final, ort;
            Console.WriteLine("Vize ve final notları ile ortalamayı hesaplayan program.");
            Console.WriteLine("Vizenin yüzde 40'ını finalin/bütünlemenin yüzde 60'ı alınmaktadır.");
            Console.WriteLine("Geçme notunuda 60 olarak hesaplanmaktadır.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            while (true)
            {

                Console.Write("Vize notunu yaz: ");
                vize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Final/Bütünleme notunu yaz: ");
                final = Convert.ToInt32(Console.ReadLine());
                ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
                Console.WriteLine("Ortalaman: {0}", ort);


                if (ort < 60)
                    Console.WriteLine("Kaldın.");
                else
                    Console.WriteLine("Geçtin.");

                Console.WriteLine("");
                Console.WriteLine("-----------Tekrar Hesapla-----------");
                Console.WriteLine("");


            }


        }
    }
}
