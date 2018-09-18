namespace HungerGames
{
    class BattleItem
    {
        private int _attackBonus;
        public int AttackBonus
        {
            get { return _attackBonus; }
            set
            {
                _attackBonus = value;
                if (_attackBonus > 100)
                {
                    _attackBonus = 100;
                }
            }
        }

        private int _defenseBonus;
        public int DefenseBonus
        {
            get { return _defenseBonus; }
            set
            {
                _defenseBonus = value;
                if (_defenseBonus > 100)
                {
                    _defenseBonus = 100;
                }
            }
        }

        public static BattleItem GenerateBattleItem()
        {
            BattleItem battleItem = new BattleItem();
            battleItem.AttackBonus = RandomGenerator.GenerateRandomNumber();
            battleItem.DefenseBonus = RandomGenerator.GenerateRandomNumber();
            return battleItem;
        }
    }
}
