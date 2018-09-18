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

            // console.log players information
            // Create game loop with win condition
            // When somebody wins -> console.log the winner

            Console.WriteLine("We have a winner!");
        }

        private void GameLoop()
        {
            // For every player:
            // - Chance to meet other player
            // - If not dead
            // - - Chance to find battle item
            // - - Heal
            // - If dead
            // - - Remove from game
        }
    }
}
