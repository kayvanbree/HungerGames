using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames
{
    class RandomGenerator
    {
        private static readonly Random Random = new Random();
        private static readonly object SysLock = new object();

        public static int GenerateRandomNumber()
        {
            lock (SysLock)
            {
                return Random.Next(0, 100);
            }
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            lock (SysLock)
            {
                return Random.Next(min, max);
            }
        }

        public static Gender GenerateGender()
        {
            int randomNr;
            lock (SysLock)
            {
                randomNr = Random.Next(0, 1);
            }
            return randomNr == 0 ? Gender.Male : Gender.Female;
        }
    }
}
