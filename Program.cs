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

            
            //double y, x, calculN;

            //Console.WriteLine("Introduceti y");
            //y = double.Parse(Console.ReadLine());

            //Console.WriteLine("Introduceti x");
            //x = double.Parse(Console.ReadLine());

            //calculN = y / x;

            //if (calculN > 0 && x != 0 && y > 0 && x > 0)
            //{
            //    Console.WriteLine($"Valoarea lui N este: {calculN}");
            //}
            //else if (x == 0)
            //{
            //    Console.WriteLine("Impartirea la 0 este o eroare");
            //}
            //else
            //{
            //    Console.WriteLine("Eroare! Date introduse, invalide in raport cu operatia. " +
            //        "Introduceti doar valori pozitive ");
            //}


            // Aplicatia 2:

            //double numarAniAna, numarAniMihai, rezultat1, rezultat2;

            //Console.WriteLine("Introduceti varsta Anei");
            //numarAniAna = double.Parse(Console.ReadLine());

            //Console.WriteLine("Introduceti varsta lui Mihai");
            //numarAniMihai = double.Parse(Console.ReadLine());

            //rezultat1 = numarAniAna - numarAniMihai;
            //rezultat2 = numarAniMihai - numarAniAna;


            //if (numarAniAna > numarAniMihai && rezultat1 == rezultat2)
            //{
              
            //    Console.WriteLine("Ana este mai mare decat Mihai cu  " + rezultat1 + " ani.");
            //}
            //else if (numarAniMihai > numarAniAna)
            //{
            //    Console.WriteLine("Mihai este mai mare decat Ana cu  " + rezultat2 + " ani.");
            //}
            //else
            //{
            //    Console.WriteLine("Varstele sunt egale");
            //}

            // TEME - exe2, exe3 si exe 4

             // Exe 2:

 //double lungime, latime, inaltime, mediaAritmetica;
 //int impartitor;
 //string mesajText;


 //Console.WriteLine("Introduceti lungimea");
 //lungime = double.Parse(Console.ReadLine());

 //Console.WriteLine("Introduceti latimea");
 //latime = double.Parse(Console.ReadLine());

 //Console.WriteLine("Introduceti inaltimea");
 //inaltime = double.Parse(Console.ReadLine());

 //impartitor = 3;
 //mesajText = "Media aritmetica este:";
 //mediaAritmetica = (lungime + latime + inaltime) / 3;


 //if (mediaAritmetica > 0 && lungime > 0 && latime > 0 && inaltime > 0)
 //{
 //    Console.WriteLine(mesajText + mediaAritmetica);
 //}
 //else if (lungime < 0 || latime < 0 || inaltime < 0)
 //{

 //    Console.WriteLine("Operatie incorecta. Dimensiunile nu pot fi negative");
 //}
 //else if (lungime == 0 || latime == 0 || inaltime == 0)
 //{
 //    Console.WriteLine("Dimensiunile nu pot fi egale cu 0");
 //}


 // exe 3:  


 //string mesajText;
 //int numarMagic, ultimaCifra;

 //Console.WriteLine("Introduceti numarul Magic");
 //numarMagic = int.Parse(Console.ReadLine());

 //ultimaCifra = numarMagic%10;
 //mesajText = "Ultima cifra este:";

 //if (numarMagic > 10)
 //{
 //    Console.WriteLine(mesajText + ultimaCifra);
 //}
 //else 
 //{
 //    Console.WriteLine("operatie imposibila");
 //}
 // Am pus conditia nrMagic > 10 pt a avea cifra zecilor si a unitatilor, altfel cum extragem modulo 10?


 // exe 4:


 string mesajText;
 int numarIntrodus, numar1, numar2, rezultat;

 Console.WriteLine("Introduceti un numar format din 2 cifre");
 numarIntrodus = int.Parse(Console.ReadLine());

 // Aflam numarul 1
 numar1 = numarIntrodus / 10;

 // Aflam numarul 2
 numar2 = numarIntrodus % 10;

 // Calculam numarul magic
 rezultat = numar1 + numar2;

 

 if ( numarIntrodus > 10 && numarIntrodus < 99 )
 {    
       Console.WriteLine($"Numarul Magic este : {rezultat}");
 }
 else 
 {
       Console.WriteLine("Operatia nu corespunde cerintei initiale");
 }




            // Aplicatia 1:

            
            double volumActivare, volumRecipient, numarVolumeRecipient;

            Console.WriteLine("Introduceti cantitatea necesara pentru activarea vasului");
            volumActivare = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti cantitatea in litri continuta de un recipient");
            volumRecipient = double.Parse(Console.ReadLine());

            numarVolumeRecipient = volumActivare / volumRecipient;

            if (numarVolumeRecipient > 0 && volumActivare != 0 && volumActivare > 0 && volumRecipient > 0)
            {
                Console.WriteLine($"Numarul de volume necesar pentru atingerea cantitatii necesare activarii este: {numarVolumeRecipient}");
            }
            else if (volumRecipient == 0)
            {
                Console.WriteLine("Impartirea la 0 este o eroare");
            }
            else
            {
                Console.WriteLine("Eroare! Date introduse, invalide in raport cu operatia. " +
                    "Introduceti doar valori pozitive ");
            }


            Aplicatia 2:

            double numarAniAna, numarAniMihai, rezultat1, rezultat2;

            Console.WriteLine("Introduceti varsta Anei");
            numarAniAna = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti varsta lui Mihai");
            numarAniMihai = double.Parse(Console.ReadLine());

            rezultat1 = numarAniAna - numarAniMihai;
            rezultat2 = numarAniMihai - numarAniAna;


            if (numarAniAna > numarAniMihai && rezultat1 == rezultat2)
            {

                Console.WriteLine("Ana este mai mare decat Mihai cu  " + rezultat1 + " ani.");
            }
            else if (numarAniMihai > numarAniAna)
            {
                Console.WriteLine("Mihai este mai mare decat Ana cu  " + rezultat2 + " ani.");
            }
            else if (numarAniAna <= 0 && numarAniMihai <= 0)
            {
                Console.WriteLine("Varsta nu poate fi negativa sau egala cu 0.");
            }
            else if (numarAniAna == numarAniMihai)
            {
                Console.WriteLine("Varstele sunt egale");
            }

        }
    }
}












