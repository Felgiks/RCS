using System;

namespace Day2_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("12 + 2");
            Console.WriteLine(12 + 2);
            Console.WriteLine('a');

            // komentaars - ja vēlies aizkomentēt vairākas rindas ->
            // izmanto "/ *" + "* /"

            //Console.WriteLine("Ievadiet simbolu virkni!");
            //Console.ReadLine();

                String a = "abc"; 
            //strings(mainīgā deklerācija) ir mainīgais un tikai simbolu virknes
            Console.WriteLine(a);
            a = "Mainitā vērtība";
                Console.WriteLine(a);

            Console.WriteLine("Ievadiet simbolu virkni!");
            String b = Console.ReadLine(); 
            //saglaba konsoles darbību kā vērtību un iegūsti saglabātu lietotāja ievadi

            Console.WriteLine(b);
            String c = a + b;
            Console.WriteLine(c); */


            //---------------------------->
            //Pirmais uzdevums

            /* String a = "Sveicināts,";
        Console.WriteLine("Sveiki, lūdzu ievadiet savu vārdu!");
             String b = Console.ReadLine();
             String c = a + b + "!";
        Console.WriteLine(c); 

        Console.WriteLine("IEvadiet vardu!");  //Skolotaja piemers
             String name = Console.ReadLine();
        Console.WriteLine("Sveiki, " + name + "!");  */


            //int - Integer (Vesels skaitlis) piem.: -1, -22, 0, 156,
            //float, double - skaitlis ar komatu (-1.5 , 20.57)
            //String - simbolu virkne
            //char - viens simbols (sharacter) piem: 'a', '4', '>',
            //bool (boolean) - true vai false

            /*
            Console.WriteLine("Ievadiet skaitli!"); //nepieciesams ievadit skaitli
            String input = Console.ReadLine(); // sataisam vietu kur saglabat ievadīto simbolu virkni

            int number = Convert.ToInt32(input); //kovertejam ievadītos simbolus uz skaitli

            Console.WriteLine(number + 2); //talak iespejams strādāt kā ar skaitli 
            */

            /*
            // Majasdarbs v1.1
            Console.WriteLine("Ievadiet pirmo skaitli!");
            String Skaitlis1 = Console.ReadLine();
            int A = Convert.ToInt32(Skaitlis1);

            Console.WriteLine("Ievadiet otro skaitli!");
            String Skaitlis2 = Console.ReadLine();
            int B = Convert.ToInt32(Skaitlis2);

            Console.Write("Summa = ");
            Console.WriteLine(A + B);
            Console.Write("Starpiba = ");
            Console.WriteLine(A - B);
            */
            
            // Majasdarbs v1.2
            Console.WriteLine("Ievadiet pirmo skaitli!");
            String Skaitlis1 = Console.ReadLine();
            int A = Convert.ToInt32(Skaitlis1);

            Console.WriteLine("Ievadiet otro skaitli!");
            String Skaitlis2 = Console.ReadLine();
            int B = Convert.ToInt32(Skaitlis2);

            
            Console.Write("Summa: " + Skaitlis1 + " + " + Skaitlis2 + " = ");
            Console.WriteLine(A + B);

            Console.Write("Starpiba: " + Skaitlis1 + " - " + Skaitlis2 + " = ");
            Console.WriteLine(A - B);

            Console.Write("Reizinājums: " + Skaitlis1 + " x " + Skaitlis2 + " = ");
            Console.WriteLine(A * B);

            Console.Write("Dalījums: " + Skaitlis1 + " / " + Skaitlis2 + " = ");
            Console.WriteLine(A / B);
            /*
            Console.WriteLine("Write number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Summa = ");
            Console.WriteLine(n1 + n2);

            Console.Write("Starpiba = ");
            Console.WriteLine(n1 - n2);
            */
        }
    }
}
