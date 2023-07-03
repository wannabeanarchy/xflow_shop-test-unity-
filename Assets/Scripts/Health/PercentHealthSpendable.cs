using System;
using GameTest.Core;
using GameTest.Health;

namespace GameTest.Rating
{
    public class PercentHealthSpendable : ISpendable
    {
        public bool CanSpend(int value)
        {
            int healthToSpend = HealthManager.Instance().CalculatePercentHealthValue(value / 100f);
            return HealthManager.Instance().CurrentValue >= healthToSpend;
        }

        public event Action OnSpended   
        {
            add 
            {
                HealthManager.Instance().Changed += value;
                value();
            }
            remove 
            {
                HealthManager.Instance().Changed -= value;
            }
        } 

        public void Spend(int value)
        {
            if (CanSpend(value))
            {
                int healthToSpend = HealthManager.Instance().CalculatePercentHealthValue(value / 100f);
                HealthManager.Instance().CurrentValue -= healthToSpend; 
            }
        }
    }
}