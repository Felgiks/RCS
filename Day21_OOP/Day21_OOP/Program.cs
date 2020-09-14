using System;

namespace Day21_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        private static void Task2()
        {
            Car car1 = new Car("VW", "Gold", 4);
            car1.Drive();
            Console.WriteLine(car1.Brand); //nevar .Model

            Car car2 = new Car();

            Bike b1 = new Bike("Test1", "Modelss");
            b1.Drive();

        }

        private static void Task3()
        {
            Test a = new Child();

            int choise = 5;
            Test a;
            if(choise > 1) { a = new Child(); }
            else { a = new Child2(); }
            a.PrintTest();
        }

        private static void Task1()
        {
            Student st = new Student("Janis", "Berzins", 4);
            st.SetName("Juris");
            st.LastName = "Klava";
            st.Course = 2;

            st.PrintInfo();
        }
    }
}
