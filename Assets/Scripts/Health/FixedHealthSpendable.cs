using GameTest.Core;
using GameTest.Health;

namespace GameTest.Rating
{
    public class FixedHealthSpendable : ISpendable
    {
        public bool CanSpend(int value)
        { 
            return HealthManager.Instance().CurrentValue > value;
        } 
        
        public void Spend(int value)
        {
            if (CanSpend(value))
            { 
                HealthManager.Instance().CurrentValue -= value;
            }
        }
    }
}