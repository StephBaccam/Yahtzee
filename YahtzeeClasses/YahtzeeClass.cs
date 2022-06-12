using System.Linq;

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

        Dictionary<string, int> Combinations = new Dictionary<string, int>()
        {
            {"Pair", 2 },
            {"Three of a Kind", 3 },
            {"Four of a Kind", 4 },
            {"Yahtzee", 5 },
        };
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

        public int ScoreStraight(List<int> rolls)
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
                return 30;
            }
            else if (straightLength == 5)
            {
                return 40;
            }
            else
            {
                return 0;
            }
        }

        public int ScoreCombination(List<int> rolls)
        {
            var pairDetected = false;
            foreach(var combination in Combinations)
            {
                var req = rolls.GroupBy(roll => roll).Where(roll => roll.Count() == combination.Value).ToList();
                if (req.Any())
                {
                    switch(combination.Key)
                    {
                        case "Pair":
                            pairDetected = true;
                            break;
                        case "Three of a Kind":
                            if(pairDetected)
                            {
                                return 25;
                            }
                            else
                            {
                                return rolls.Sum();
                            }
                        case "Four of a Kind":
                            return rolls.Sum();
                        case "Yahtzee":
                            return 50;
                        default:
                            return 0;
                    }
                }
            }
            return 0;
        }
    }
}