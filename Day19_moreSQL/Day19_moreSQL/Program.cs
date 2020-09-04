using System;

namespace Day19_moreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = new Connection();
            Console.WriteLine(con.Open());
        }
    }
}
