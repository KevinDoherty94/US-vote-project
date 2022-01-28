using System;

namespace US_vote_project
{
    internal class Program
    {
        /// <summary>
        /// Window loaded startup method
        /// </summary>
        private static void Main()
        {
            State s1 = GetInfo();
            State s2 = GetInfo();
            State s3 = GetInfo();
            State s4 = GetInfo();
            Console.Clear();

            Console.WriteLine("{0,-14}{1,-14}{2,-14}{3,-14}{4,-14}{5,-14}{6,-14}{7,-14}",
            "State", "Population", "Democrat", "Republican",
            "Democrat %", "Republican %", "Total Votes", "Winner");

            Console.Write(s1);
            SetBoxColour(s1);

            Console.Write(s2);
            SetBoxColour(s2);

            Console.Write(s3);
            SetBoxColour(s3);

            Console.Write(s4);
            SetBoxColour(s4);

            Console.ReadLine();
        }

        /// <summary>
        /// Method for getting state info from user
        /// </summary>
        /// <returns>return state value</returns>
        public static State GetInfo()
        {
            // Enter state name
            Console.WriteLine("Please enter state name>> ");
            string name = Console.ReadLine();

            // Enter population
            Console.WriteLine("Please enter state population>> ");
            double population = Convert.ToDouble(Console.ReadLine());

            // Enter democratic votes
            Console.WriteLine("Please enter democratic votes>> ");
            string democratVotes = Console.ReadLine();
            double democratVotesCount = Convert.ToDouble(democratVotes);

            // Enter republican votes
            Console.WriteLine("Please enter republican votes>> ");
            string republicanVotes = Console.ReadLine();
            double republicanVotesCount = Convert.ToDouble(republicanVotes);

            // Create a new line
            Console.WriteLine();

            State stateDetails = new State(name, population)
            {
                DemocratVotes = democratVotesCount,
                RepublicanVotes = republicanVotesCount,
                TotalVotes = democratVotesCount + republicanVotesCount
            };

            return stateDetails;
        }

        /// <summary>
        /// Set Box Colour
        /// </summary>
        /// <param name="stateInfo">State Info</param>
        private static void SetBoxColour(State stateInfo)
        {
            Console.BackgroundColor = stateInfo.DemocratVotes > stateInfo.RepublicanVotes ? ConsoleColor.Blue : ConsoleColor.Red;
            Console.WriteLine("   ");
            Console.ResetColor();
        }
    }
}