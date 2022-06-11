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
        public void ReturnTrueIfFullHouse()
        {
            var yahtzee = new YahtzeeClass();
            var result = yahtzee.IsFullHouse(1, 2, 3, 4, 5);
            Assert.False(result);
        }
    }
}