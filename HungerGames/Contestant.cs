namespace HungerGames
{
    class Contestant
    {
        public Gender Gender { get; set; }
        public int AttackLevel { get; set; }
        public int DefenseLevel { get; set; }
        public int Health { get; set; }
        public BattleItem BattleItem { get; set; }

        public static Contestant CreateDistrictContestant()
        {
            return new DistrictContestant();
        }

        public static Contestant CreateCareerContestant()
        {
            return new CareerContestant();
        }

        public static Contestant CreateContestant()
        {
            return new Contestant();;
        }
    }
}
