using System;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Gold
{
    public class GoldManager : SingletonOneScene<GoldManager>, ISpendable, IReward
    {
        private int _gold; 
        private event Action _innerChanged;
        public int CurrentValue 
        {
            get
            {
                return _gold;
            }
            set
            {
                if (_gold != value)
                {
                    _gold = value; 
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
            if (properties == TypeProperties.FixedGold)
            { 
                CurrentValue += value;
            } 
        }

        public event Action<TypeProperties, int> OnSpend;
        public void Spend(TypeProperties properties, int value)
        {
            if (properties == TypeProperties.FixedGold)
            {
                if (CanSpend(value))
                {
                    CurrentValue -= value;
                }
            } 
        }
    } 
}
