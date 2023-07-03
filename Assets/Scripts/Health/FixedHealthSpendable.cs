using System;
using GameTest.Core;
using GameTest.Health;

namespace GameTest.Rating
{
    public class FixedHealthSpendable : ISpendable
    {    
        public bool CanSpend(int value)
        { 
            return HealthManager.Instance().CurrentValue >= value;
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
                HealthManager.Instance().CurrentValue -= value; 
            }
        }
    } 
}