using System.Linq;

namespace YahtzeeClasses
{
    public class YahtzeeClass
    {
        public int CountOnes(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll == 1)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }

        public int CountTwos(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll == 2)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }


        public int CountThrees(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll == 3)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }

        public int CountFours(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll == 4)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }

        public int CountFives(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll == 5)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }

        public int CountSixes(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll == 6)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }

        public int Chance(List<int> rolls)
        {
            var resToReturn = 0;
            foreach (var roll in rolls)
            {
                if (roll != roll)
                {
                    continue;
                }
                resToReturn += roll;
            }

            return resToReturn;
        }

        public bool IsThreeOfAKind(List<int> rolls)
        {
            var req = rolls.GroupBy(roll => roll).Where(roll => roll.Count() == 3).ToList();
            if(req.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFourOfAKind(List<int> rolls)
        {
            var req = rolls.GroupBy(roll => roll).Where(roll => roll.Count() == 4).ToList();
            if (req.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(List<int> rolls)
        {
            var req1 = rolls.GroupBy(roll => roll).Where(roll => roll.Count() == 3).ToList();
            var req2 = rolls.GroupBy(roll => roll).Where(roll => roll.Count() == 2).ToList();
            if (req1.Any() && req2.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSmallStraight(List<int> rolls)
        {
            return true;
        }

        public bool IsLargeStraight(List<int> rolls)
        {
            return true;
        }

        public bool IsYahtzee(List<int> rolls)
        {
            var req = rolls.GroupBy(roll => roll).Where(roll => roll.Count() == 5).ToList();
            if (req.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}