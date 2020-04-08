namespace GamblingGame
{
    internal class Horse
    {
        public string id { get; set; }

        public int LuckScore { get; set; }

        public int RealScore { get; set; }

        public Horse()
        {
        }

        public Horse(string id, int LuckScore) { 
            this.id = id;
            this.LuckScore = LuckScore;
            this.RealScore = 0;
        }
    }
}