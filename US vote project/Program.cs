using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace US_vote_project
{
    class Program
    {
        static void Main(string[] args)
        {
            State s1 = GetInfo();
            State s2 = GetInfo();
            State s3 = GetInfo();
            State s4 = GetInfo();

            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}{6,-20}{7,-20}",
            "State", "Population", "Democrat Votes", "Republican Votes",
            "Democrat %", "Republican %", "Total Votes", "Winner");
            

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.ReadLine();

        }
        public static State GetInfo() //Method for getting state info from user
        {   // Enter state name
            
            Console.WriteLine("Please enter state name>> ");
            string name = Console.ReadLine();

            // Enter population
            Console.WriteLine("Please enter state population>> ");
            string population = Console.ReadLine();
            double populationCount = Convert.ToDouble(population);

            // Enter democratic votes
            Console.WriteLine("Please enter democratic votes>> ");
            string democratVotes = Console.ReadLine();
            double democratVotesCount = Convert.ToDouble(democratVotes);

            // Enter republican votes
            Console.WriteLine("Please enter republican votes>> ");
            string republicanVotes = Console.ReadLine();
            double republicanVotesCount = Convert.ToDouble(republicanVotes);

            State state1 = new State(name, population);
           
            state1.DemocratVotes = democratVotesCount;
            state1.RepublicanVotes = republicanVotesCount;
            

            return state1;





        }


    }
}
