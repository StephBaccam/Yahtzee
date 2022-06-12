using System.Linq;

namespace YahtzeeClasses
{
    public class YahtzeeClass
    {


        Dictionary<string, int> Combinations = new Dictionary<string, int>()
        {
            {"Pair", 2 },
            {"Three of a Kind", 3 },
            {"Four of a Kind", 4 },
            {"Yahtzee", 5 },
        };

        Dictionary<string, int> CountValues = new Dictionary<string, int>()
        {
            { "Face1", 1 },
            { "Face2", 2 },
            { "Face3", 3 },
            { "Face4", 4 },
            { "Face5", 5 },
            { "Face6", 6 },


        };

        public int Count(List<int> rolls, string Face)
        {
            var resToReturn = 0;

            foreach (var De in CountValues)
            {
                if (Face.Equals(De.Key))
                {
                    resToReturn = rolls.Where(roll => roll == De.Value).Sum();
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