using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_vote_project
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo();
            State s1 = new State("California", 39937500);
            Console.ReadLine();
            

        }
        public static void GetInfo() //Method for getting state info
        {   // Enter state name
            Console.WriteLine("Please enter state name>> ");
            Console.ReadLine();


            // Enter population
            Console.WriteLine("Please enter state population>>  ");
            Console.ReadLine();

            // Enter democratic votes
            Console.WriteLine("Please enter democratic votes>> ");
            Console.ReadLine();

            // Enter republican votes
            Console.WriteLine("Please enter republican votes>> ");
            Console.ReadLine();



        }


    }
}
