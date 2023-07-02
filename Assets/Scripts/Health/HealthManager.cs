using System;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Health
{
    public class HealthManager : SingletonOneScene<HealthManager>, ISpendable, IReward
    {  
        private int _health; 
        private event Action _innerChanged;
        public int CurrentValue 
        {
            get
            {
                return _health;
            }
            set
            {
                if (_health != value)
                {
                    _health = value; 
                    _innerChanged?.Invoke();
                }
            }
        } 
        public event Action Changed
        {
            add 
            {
                _innerChanged += value;
                value();
            }
            remove 
            {
                _innerChanged -= value;
            }
        }

        public void InitManager(int value)
        {
            CurrentValue = value;
        }

        public bool CanSpend(TypeProperties properties, int value)
        {
            bool canSpend = false;
            if (properties == TypeProperties.FixedHealth)
            {
                canSpend =  CurrentValue >= value;
            }

            if (properties == TypeProperties.PercentHealth)
            { 
                int healthToSpend = CalculatePercentHealthValue(value / 100f); 
                canSpend = CurrentValue >= healthToSpend;
            }

            return canSpend;
        }
 
        public void Reward(TypeProperties properties, int value)
        {
            if (properties == TypeProperties.FixedHealth)
            {
                CurrentValue += value;  
            }

            if (properties == TypeProperties.PercentHealth)
            { 
                int healthToAdd = CalculatePercentHealthValue(value / 100f); 
                CurrentValue += healthToAdd;  
            } 
        }
    
        public void Spend(TypeProperties properties, int value)
        { 
            if (properties == TypeProperties.FixedHealth)
            {
                if (CanSpend(properties, value))
                {
                    CurrentValue -= value; 
                }
            }

            if (properties == TypeProperties.PercentHealth)
            { 
                int healthToSpend = CalculatePercentHealthValue(value / 100f);

                if (CanSpend(properties, healthToSpend))
                {
                    CurrentValue -= healthToSpend;
                }
            }
            
        }

        private int CalculatePercentHealthValue(float percent)
        {
            int currentHealth = CurrentValue;
            return Mathf.RoundToInt(currentHealth * percent); 
        } 
    } 
}

