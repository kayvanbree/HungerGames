using System;

namespace HungerGames
{
    class Contestant
    {
        public Boolean Alive { get; set; }
        public Gender Gender { get; set; }

        private int _defenseLevel;
        public int DefenseLevel
        {
            get { return _defenseLevel; }
            set
            {
                _defenseLevel = value;
                if (_defenseLevel > 100)
                {
                    _defenseLevel = 100;
                }
            }
        }

        private int _attackLevel;
        public int AttackLevel
        {
            get { return _attackLevel; }
            set
            {
                _attackLevel = value;
                if (_attackLevel > 100)
                {
                    _attackLevel = 100;
                }
            }
        }

        private int _health;
        public int Health
        {
            get { return _health; }
            set
            {
                _health = value;
                if (_health > 100)
                {
                    _health = 100;
                }
            }
        }

        public BattleItem BattleItem { get; set; }

        public Contestant()
        {
            Alive = true;
            Gender = GenerateGender();
            AttackLevel = GenerateRandomNumber();
            DefenseLevel = GenerateRandomNumber();
            Health = 100;
        }

        private Gender GenerateGender()
        {
            return Gender.Male;
        }

        private int GenerateRandomNumber()
        {
            return 50;
        }

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
