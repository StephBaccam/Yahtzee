namespace YahtzeeClasses
{
    public class YahtzeeClass
    {
        public int CountOnes(List<int> rolls)
        {
            var resToReturn = 0;
            foreach(var roll in rolls)
            {
                if(roll == 1)
                {
                    resToReturn += roll;
                }
            }

            return resToReturn;
        }

        public bool IsThreeOfAKind(List<int> rolls)
        {
            return true;
        }

        public bool IsFourOfAKind(List<int> rolls)
        {
            return true;
        }

        public bool IsFullHouse(List<int> rolls)
        {
            return true;
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
            return true;
        }
    }
}