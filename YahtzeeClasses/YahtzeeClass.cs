﻿using System.Linq;

namespace YahtzeeClasses
{
    public class YahtzeeClass
    {
        //Dictionary<string, List<int>> CountValues = new Dictionary<string, List<int>>()
        //{
        //    { "Roll1", new List<int>(){ 1,2,3,4,5,6 } },
        //    //{"Face1", 1},
        //    //{"Face2", 2},
        //    //{"Face3", 3},
        //    //{"Face4", 4},
        //    //{"Face5", 5},
        //    //{"Face6", 6},

        //};
        //public string Count(int rolls)
        //{
        //    var resToReturn = 0;
        //    //foreach (var roll in rolls)
        //    //{
        //    //    if (roll == 1)
        //    //    {
        //    //        resToReturn += roll;
        //    //    }
        //    //}

        //    foreach (var roll in CountValues)
        //    {
        //        if (rolls == 1)
        //        {
        //            continue;
        //        }
        //        resToReturn += rolls;
        //    }

        //    return "";
        //}

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
            var straightLength = 1;
            rolls.Sort();
            var uniqueRolls = rolls.Distinct();

            foreach (var roll in uniqueRolls)
            {
                if (rolls.Contains(roll + 1))
                {
                    straightLength++;
                }
            }

            if (straightLength == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLargeStraight(List<int> rolls)
        {
            var straightLength = 1;
            rolls.Sort();
            var uniqueRolls = rolls.Distinct();

            foreach (var roll in uniqueRolls)
            {
                if (rolls.Contains(roll + 1))
                {
                    straightLength++;
                }
            }

            if (straightLength == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
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