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

        public bool CanSpend(int value)
        {
            return CurrentValue >= value;
        }

        public event Action<TypeProperties, int> OnRewardGiven;

        public void Reward(TypeProperties properties, int value)
        {
            if (properties == TypeProperties.FixedHealth)
            {
                CurrentValue += value;  
            }

            if (properties == TypeProperties.PercentHealth)
            {
                float percent = value / 100f;
                int currentHealth = HealthManager.Instance().CurrentValue;
                int healthToAdd = Mathf.RoundToInt(currentHealth * percent);

                CurrentValue += healthToAdd;  
            }
        }
        
        public event Action<TypeProperties, int> OnSpend;
        public void Spend(TypeProperties properties, int value)
        { 
            if (properties == TypeProperties.FixedHealth)
            {
                if (CanSpend(value))
                {
                    CurrentValue -= value;
                }
            }

            if (properties == TypeProperties.PercentHealth)
            {
                float percent = value / 100f;
                int currentHealth = HealthManager.Instance().CurrentValue;
                int healthToSpend = Mathf.RoundToInt(currentHealth * percent);

                if (CanSpend(healthToSpend))
                {
                    CurrentValue -= healthToSpend;
                }
            }
        }
    } 
}

