using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_vote_project
{
    class State
    {
        //properties
        public string Name { get; set; }
        public int Population { get; set; }
        public int DemocraticVotes { get; set; }
        public int RepublicanVotes { get; set; }
        public int TotalVotes { get; set; }

        //Constructor
        public State(string name, int population)
        {
            Name = name;
            Population = population;
          

        }
       

        public override string ToString()
        {   //ToString 
            return string.Format("State\t\t\tPopulation\tDemocrat\tRepublican\tDemocrat%\tRepublican%\tTotal Votes\tWinner");
        }
        public string GetWinner(string biden, string trump)//trump or biden
        {
            
            if (DemocraticVotes > RepublicanVotes)//returns Biden
                biden = Convert.ToString("Biden");
                
                return biden;

            if (RepublicanVotes > DemocraticVotes)//returns Trump
                trump = Convert.ToString("Trump");
               
                return trump;

        }
        






    }
}
