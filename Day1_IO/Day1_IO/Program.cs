using System;

namespace Day1_IO
{
	class Program
	{
		static void Main(string[] args)
        {
            int Skaitlis = 1;
            Task1(Skaitlis);

            static void Task1(int n)
            {
                do
                {
                    for (int i = 0; i < n; i++)
                    {
                        if ((n / 3 == 3 && n / 5 == 3))
                        {
                            Console.WriteLine("Skaitlis ir = " + n);
                        }
                        if (n / 5 == 5)
                        {
                            Console.WriteLine("                         Skaitlis ir = " + n);
                        }
                        else
                        {
                            
                        }
                    } //(n / 3 == 3 && n / 5 == 3);
                    
                    n++;
}
                while (true);



        }

			//Console.WriteLine("Hello World!");
			//Console.WriteLine("Are we gonna get up?");
			//Console.WriteLine(1234); //Parasta izvade -skaitļus un simbolus var izvadīt neizmantojot pēdiņas ""
			//abc
		}

       
    }
}
