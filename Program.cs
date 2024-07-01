using System;

namespace TemeDeCasa
{
    class Rezolvari
{
    static void Main(string[] args) {

            //double lungime = 24.5, latime = 11.23, inaltime = 15.7;


            //double mediaAritmetica = (lungime * latime * inaltime);


            //Console.Write("Rezultatul este: ");
            //Console.WriteLine(calculVolum);




            // Console.WriteLine("Introduceti lungimea");
            // double lungime = double.Parse(Console.ReadLine());

            // Console.WriteLine("Introduceti latimea");
            // double latime = double.Parse(Console.ReadLine());

            // Console.WriteLine("Introduceti inaltimea");
            // double inaltime = double.Parse(Console.ReadLine());


            // double calculVolum = (lungime * latime * inaltime);

            // Console.Write("Rezultatul este: ");
            // Console.WriteLine(calculVolum);


        

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
        

 using System;

namespace CelMaiMicNumar 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introduceti primul numar:");
            //double numar1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Introduceti al doilea numar:");
            //double numar2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Introduceti al treilea numar:");
            //double numar3 = double.Parse(Console.ReadLine());

            //double minim = 0;

            //  if (numar1 < minim)
            //  {
            //      minim = numar1;
            //  }
            //  if (numar2 < minim)
            //  {
            //      minim = numar2;
            //  }
            //  if (numar3 < minim)
            //  {
            //      minim = numar3;
            //  }
            //  Console.WriteLine("Cel mai mic numar este: " + minim);

            //// Determinare cel mai mic numar
            //double minim = numar1;

            //if (numar2 < minim)
            //{
            //    minim = numar2;
            //    Console.WriteLine("Cel mai mic numar este: " + minim);
            //}

            //else if (numar3 < minim)
            //{
            //    minim = numar3;
            //    Console.WriteLine("Cel mai mic numar este: " + minim);
            //}
            //else
            //{
            //    Console.WriteLine("Numerele sunt egale");
            //}
            //Console.WriteLine("operatia a fost finalizata cu succes");

            Console.WriteLine("Introduceti primul numar:");
            double numar1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            double numar2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar:");
            double numar3 = double.Parse(Console.ReadLine());

            double minim = 0;


            if (numar1 < minim)
            {
                minim = numar1;               
            }
            else if (numar2 < minim)
            {
                minim = numar2;               
            }
            else if (numar3 < minim)
            {
                minim = numar3;                
            } else
            {
                Console.WriteLine("Numerele sunt egale");
            }

            Console.WriteLine($"Cel mai mic numar este: {minim}");



        }
    }
}

 // calculul volumului casutei lui Pluto

 double lungime, latime, inaltime, volum;
 string textVolum = "Volumul este: ";
 string unitateMasura = " metri cubi";

 Console.WriteLine("Introduce lungimea");
 lungime = double.Parse(Console.ReadLine());

 Console.WriteLine("Introduce latimea");
 latime = double.Parse(Console.ReadLine());

 Console.WriteLine("introduce inaltimea");
 inaltime = double.Parse(Console.ReadLine());

 volum = lungime * latime * inaltime;

 if (lungime > 0 && latime > 0 && inaltime > 0)
 {
     Console.WriteLine(textVolum + volum + unitateMasura);
     Console.WriteLine("Operatiunea s-a realizat cu succes");
 }
 else if (lungime == 0 || latime == 0 || inaltime == 0)
 {
     Console.WriteLine("Nu puteti introduce valoarea 0");
     Console.WriteLine("Factori invalizi. Operatia nu s-a putut efectua");
 } else 
 {
     Console.WriteLine("Nu puteti introduce numere negative");
     Console.WriteLine("Factori invalizi. Operatia nu s-a putut efectua");
 }


           









