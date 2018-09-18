namespace HungerGames
{
    class CareerContestant : Contestant
    {
        public CareerContestant()
        {
            BattleItem = BattleItem.GenerateBattleItem();
            AttackLevel = 100;
        }
    }
}
