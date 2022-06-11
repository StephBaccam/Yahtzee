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
                1, 1, 2, 2, 3
            };
            var result = yahtzee.CountOnes(rolls);
            Assert.Equal(3, result);
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
            Assert.False(result);
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
            Assert.False(result);
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
            Assert.False(result);
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
            Assert.False(result);
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
            Assert.False(result);
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
            Assert.False(result);
        }
    }
}