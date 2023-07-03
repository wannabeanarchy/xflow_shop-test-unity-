using System;
using GameTest.Core;

namespace GameTest.Rating
{
    public class RatingSpendable : ISpendable
    {
        public bool CanSpend(int value)
        {
              return RatingManager.Instance().CurrentValue >= value;
        }

        public event Action OnSpended       
        {
            add 
            {
                RatingManager.Instance().Changed += value;
                value();
            }
            remove 
            {
                RatingManager.Instance().Changed -= value;
            }
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