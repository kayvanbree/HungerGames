using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames
{
    class GameController
    {
        public List<Contestant> Contestants { get; set; }

        public GameController()
        {
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
            Console.WriteLine(Contestants);
        }

        private void gameLoop()
        {

        }
    }
}
