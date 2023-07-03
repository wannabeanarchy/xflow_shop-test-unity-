using System;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Health
{
    public class HealthManager : SingletonOneScene<HealthManager> 
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

        public int CalculatePercentHealthValue(float percent)
        {
            int currentHealth = CurrentValue;
            return Mathf.CeilToInt(currentHealth * percent); 
        } 
    } 
}

