using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_vote_project
{
    public class State
    {
        //properties
        public string Name { get; set; }
        public string Population { get; set; }
        public double DemocratVotes { get; set; }
        public double RepublicanVotes { get; set; }
        public double TotalVotes
        {
            get
            {
                return DemocratVotes + RepublicanVotes;
            }
        }

        //Constructor
        public State(string name, string population)
        {
            Name = name;
            Population = population;

        }


        public override string ToString()//ToString method
        {   //ToString 
            return string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20:P2}{5,-20:P2}{6,-20}{7,-20}",
                Name, Population, DemocratVotes, RepublicanVotes,
                DemocratVotes / TotalVotes, RepublicanVotes / TotalVotes,
                TotalVotes, GetWinner());
        }
        public string GetWinner() //Gets Trump or Biden as winner
        {

            if (DemocratVotes > RepublicanVotes)
                return ("Biden");
            else if (DemocratVotes < RepublicanVotes)
                return ("Trump");
            else
                return "Draw";
        }












    }
}
