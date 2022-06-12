using YahtzeeClasses;

namespace Yahtzee
{
    public class YahtzeeTests
    {
        //[Theory]
        //[InlineData(1)]
        //public void ReturnCountOnesIs3Points(List<int> rolls)
        //{
        //    var yahtzee = new YahtzeeClass();
        //    List<int> rolls = new List<int>()
        //    {
        //        1, 4, 2, 5, 2
        //    };
        //    var result = yahtzee.Count(rolls);
        //    Assert.Equal(1, result);
        //}

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
        public void ReturnTrueIfThreeOfAKind()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 3
            };
            var result = yahtzee.IsThreeOfAKind(rolls);
            Assert.True(result);
        }

        [Fact]
        public void ReturnTrueIfFourOfAKind()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 3
            };
            var result = yahtzee.IsFourOfAKind(rolls);
            Assert.True(result);
        }

        [Fact]
        public void ReturnTrueIfFullHouse()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 3
            };
            var result = yahtzee.IsFullHouse(rolls);
            Assert.True(result);
        }

        [Fact]
        public void ReturnTrueIfSmallStraight()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 3
            };
            var result = yahtzee.IsSmallStraight(rolls);
            Assert.True(result);
        }

        [Fact]
        public void ReturnTrueIfLargeStraight()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 3
            };
            var result = yahtzee.IsLargeStraight(rolls);
            Assert.True(result);
        }

        [Fact]
        public void ReturnTrueIfYahtzee()
        {
            var yahtzee = new YahtzeeClass();
            List<int> rolls = new List<int>()
            {
                1, 1, 2, 2, 3
            };
            var result = yahtzee.IsYahtzee(rolls);
            Assert.True(result);
        }
    }
}