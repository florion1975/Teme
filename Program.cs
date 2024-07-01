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


           
namespace ProgramPicnic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrie un program care sa preia 2 nr de la utilizator si sa permita utilizatorului sa aleaga o operatie aritmetica
            // pt a fi efectuata cu cele 2 numere.
            // operatiile disponibile: adunare, scadere, inmultire, impartire.
            // Programul va afisa rezultatul ales de utilizator.

            // Ce stim:
            // - operatiile disponibile:
            // - cele 2 numere sunt introduse de utilizator.
            // - operatia aritmetica va fi aleasa de utilizator.

            // Ce nu stim:
            // - ce numere va introduce utilizatorul.
            // - ce operatie aritmetica va alege din optiunile oferite.

            // Algoritm:

            // declaram variabilele:
            // numar1 si numar2
            // operatiaAritmetica

            // mesaj pt utilizator sa introduca primul numar.
            // codul specific.

            // mesaj pt utilizator sa introduca al doilea numar.
            // codul specific.

            // mesaj pentru utilizator in care cerem sa aleaga optiunea dorita.

            // prezentarea optiunilor de operatii utilizatorului intr-un menu.
            // pt a evita ca utilizatorul nu poate in acest caz sa introduca "stringuri" de la tastatura pt optiuni ("adunare", "scadere"...etc),
            // vom nota fiecare optiune cu un numar de la 1 la 4.

            // declararea variabilei "optiune" , de tip "int" si pe care o vom folosi in structuri decizionale.
            // declararea variabilei "optiuneValida" de tip bool pe care o vom folosi in structuri decizionale, 
            // pt a evita introducerea de catre utilizator a unui alt numar decat cele din menu.
            // declaram variabila "rezultat" , de tip double pt a o folosi in structuri decizionale.
            // mesaj final daca optiunea este valida, mesaj ce indica succesul operatiei alese sau insuccesul daca numarul 2 este egal cu 0.



            double numar1, numar2;
            double operatieAritmetica;

            Console.WriteLine("Introduceti primul numar ");
            numar1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar ");
            numar2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Alegeti operatia aritmetica ");

            Console.WriteLine("1.Adunare");
            Console.WriteLine("2.Scadere");
            Console.WriteLine("3.Inmultire");
            Console.WriteLine("4.Impartire");

            int optiune = int.Parse(Console.ReadLine());

            bool optiuneValida = true;

            double rezultat = 0;

            if (optiune == 1)
            {
                rezultat = numar1 + numar2;
                Console.WriteLine($"Rezultatul adunarii este:  {rezultat}");
            }
            else if (optiune == 2)
            {
                rezultat = numar1 - numar2;
                Console.WriteLine($"Rezultat scaderii este:  {rezultat}");
            }
            else if (optiune == 3)
            {
                rezultat = numar1 * numar2;
                Console.WriteLine($"Rezultatul inmultirii este: {rezultat}");
            }
            else if (optiune == 4)
            {
                if (numar2 != 0)
                {
                    rezultat = numar1 / numar2;
                    Console.WriteLine($"Rezultatul impartirii este: {rezultat}");
                }
                else
                {
                    Console.WriteLine("Operatiunea invalida.Nu se poate imparti la 0");
                }
            }
            else
            {
                optiuneValida = false;
                Console.WriteLine("Optiune invalida. Va rugam sa selectati o operatiune de la 1 la 4.");
            }

            if (optiuneValida && numar2 != 0)
            {
                Console.WriteLine("Operatiunea a fost realizata cu succes!");

            }
            else if (optiuneValida && numar2 == 0)
            {
                Console.WriteLine("Operatiunea nu a putut fi realizata.");
            }
        }
    }
}












