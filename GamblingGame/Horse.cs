namespace GamblingGame
{
    internal class Horse
    {
        //Arklio klasė, naudojam "id" sekti arkliuka,
        //"LuckScore" sprendžiant kuris arkliukas judės ir
        //"RealScore" sekti kiek jau pajudėjo arkliukas
        public string id { get; set; }

        public int LuckScore { get; set; }

        public int RealScore { get; set; }

        public Horse(string id, int LuckScore) { 
            this.id = id;
            this.LuckScore = LuckScore;
            this.RealScore = 0;
        }
    }
}