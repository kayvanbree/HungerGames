using System;
using System.Collections.Generic;

namespace HungerGames
{
    class GameController
    {
        public List<Contestant> Contestants { get; set; }

        public GameController()
        {
            Console.WriteLine("Contestants arriving");
            Contestants = new List<Contestant>();

            for (int i = 0; i < 12; i++)
            {
                Contestants.Add(Contestant.CreateDistrictContestant());
            }

            for (int i = 0; i < 6; i++)
            {
                Contestants.Add(Contestant.CreateCareerContestant());
                Contestants.Add(Contestant.CreateContestant());
            }
        }

        public void Run()
        {
            Console.WriteLine("Starting the hunger games!");

            for (int i = 0; i < Contestants.Count; i++)
            {
                Console.WriteLine(Contestants[i]);
            }

            while (Contestants.Count != 1)
            {
                GameLoop();
            }

            Console.WriteLine("We have a winner!");
        }

        private void GameLoop()
        {
            for (int i = 0; i < Contestants.Count; i++)
            {
                // Chance to meet other dead/alive player
                Contestant contestant = Contestants[i];

                // Get another player, not self
                int meetsNr = -1;
                while (meetsNr == i || meetsNr == -1)
                {
                    meetsNr = RandomGenerator.GenerateRandomNumber(0, Contestants.Count);
                }
                Contestant other = Contestants[meetsNr];

                if (other.Alive)
                {
                    // Kill or get killed
                }

                if (contestant.Alive)
                {
                    // Chance to find battle item
                }
            }

            Contestants.RemoveAll(item => !item.Alive);

        }
    }
}
