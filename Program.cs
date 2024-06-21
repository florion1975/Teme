using System;

namespace MediaAritmetica
{
    class MediaAritmetica
{
    static void Main(string[] args) {

            //double lungime = 24.5, latime = 11.23, inaltime = 15.7;

            //double MediaAritmetica = (lungime * latime * inaltime)/3;


            //Console.Write("Rezultatul este: ");
            //Console.WriteLine(MediaAritmetica);




            Console.WriteLine("Introduceti lungimea");
            double lungime = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea");
            double latime = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea");
            double inaltime = double.Parse(Console.ReadLine());

            double MediaAritmetica = (lungime * latime * inaltime) / 3;

            Console.Write("Rezultatul este: ");
            Console.WriteLine(MediaAritmetica);








        }
    }

}