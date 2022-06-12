using YahtzeeClasses;

namespace Yahtzee
{
    public class YahtzeeTests
    {
        [Fact]
        public void ReturnCountOnesIs3Points()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 6, 1, 5
            };
            var result = yahtzee.CountOnes(rolls);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ReturnCountTwoIs4Points()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 4, 2, 5, 2
            };
            var result = yahtzee.CountTwos(rolls);
            Assert.Equal(4, result);
        }

        [Fact]
        public void ReturnCountThreesIs6Points()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 3, 3, 6, 2
            };
            var result = yahtzee.CountThrees(rolls);
            Assert.Equal(6, result);
        }

        [Fact]
        public void ReturnCountFoursIs12Points()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                4, 1, 4, 4, 3
            };
            var result = yahtzee.CountFours(rolls);
            Assert.Equal(12, result);
        }

        [Fact]
        public void ReturnCountFivesIs10Points()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                4, 6, 5, 2, 5
            };
            var result = yahtzee.CountFives(rolls);
            Assert.Equal(10, result);
        }

        [Fact]
        public void ReturnCountSixesIs24Points()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                6, 6, 2, 6, 6
            };
            var result = yahtzee.CountSixes(rolls);
            Assert.Equal(24, result);
        }

        [Fact]
        public void ReturnCountChancePoints()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 4, 4, 6, 4
            };
            var result = yahtzee.Chance(rolls);
            Assert.Equal(19, result);
        }

        [Fact]
        public void Return_Sum_points_three_of_a_kind()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 4, 2, 5, 2
            };
            var result = yahtzee.ScoreCombination(rolls);
            Assert.Equal(rolls.Sum(), result);
        }

        [Fact]
        public void Return_Sum_points_four_of_a_kind()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 2, 2, 5, 3
            };
            var result = yahtzee.ScoreCombination(rolls);
            Assert.Equal(rolls.Sum(), result);
        }

        [Fact]
        public void Return_25_points_Full_House()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 5
            };
            var result = yahtzee.ScoreCombination(rolls);
            Assert.Equal(25, result);
        }

        [Fact]
        public void Return_30_points_small_straight()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 5, 3
            };
            var result = yahtzee.ScoreStraight(rolls);
            Assert.Equal(30, result);
        }

        [Fact]
        public void Return_40_points_large_straight()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 6, 2, 4, 3
            };
            var result = yahtzee.ScoreStraight(rolls);
            Assert.Equal(40, result);
        }

        [Fact]
        public void Return_50_points_Yahtzee()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                6, 6, 6, 6, 5
            };
            var result = yahtzee.ScoreCombination(rolls);
            Assert.Equal(50, result);
        }
    }
}