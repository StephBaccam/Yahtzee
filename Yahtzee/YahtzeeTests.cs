using YahtzeeClasses;

namespace Yahtzee
{
    public class YahtzeeTests
    {
        [Fact]
        public void ReturnTrueIfFullHouse()
        {
            var yahtzee = new YahtzeeClass();
            var result = yahtzee.IsFullHouse(1, 2, 3, 4, 5);
            Assert.False(result);
        }
    }
}