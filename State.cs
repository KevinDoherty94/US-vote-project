namespace US_vote_project
{
    public class State
    {
        #region Constant

        /// <summary>
        /// Gets or sets State padding
        /// </summary>
        public const int Padding = -14;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets State Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Population
        /// </summary>
        public double Population { get; set; }

        /// <summary>
        /// Gets or sets Democrat Votes
        /// </summary>
        public double DemocratVotes { get; set; }

        /// <summary>
        /// Gets or sets Republican Votes
        /// </summary>
        public double RepublicanVotes { get; set; }

        /// <summary>
        /// Gets or sets election Total Votes
        /// </summary>
        public double TotalVotes { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Initialises a new instance of the <see cref="State" /> class.
        /// </summary>
        /// <param name="name">name of state</param>
        /// <param name="population">population of state</param>
        public State(string name, double population)
        {
            Name = name;
            Population = population;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Gets Trump or Biden as winner
        /// </summary>
        /// <returns>string, winner last name</returns>
        public string GetWinner()
        {
            return DemocratVotes > RepublicanVotes ? "Biden" : "Trump";
        }

        /// <summary>
        /// Override default ToString()
        /// </summary>
        /// <returns>string value of new format</returns>
        public override string ToString()
        {
            return $"{Name,Padding}{Population,Padding:n0}{DemocratVotes,Padding:n0}{RepublicanVotes,Padding:n0}{DemocratVotes / TotalVotes,Padding:P2}{RepublicanVotes / TotalVotes,Padding:P2}{TotalVotes,Padding:n0}{GetWinner(),-10}"; // padding reduced to suit UI better
        }

        #endregion Methods
    }
}