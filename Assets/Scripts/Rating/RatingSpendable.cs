using GameTest.Core;

namespace GameTest.Rating
{
    public class RatingSpendable : ISpendable
    {
        public bool CanSpend(int value)
        {
              return RatingManager.Instance().CurrentValue >= value;
        }
        
        public void Spend(int value)
        {
            if (CanSpend(value))
            {
                RatingManager.Instance().CurrentValue -= value;
            }
        }
    }
}