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

        public bool IsFullHouse(int roll1, int roll2, int roll3, int roll4, int roll5)
        {
            return true;
        }
    }
}