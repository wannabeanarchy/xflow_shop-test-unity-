using System;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Rating
{
    public class RatingManager : SingletonOneScene<RatingManager>, ISpendable, IReward
    {
        private int _rating;
        private event Action _innerChanged;

        public int CurrentValue
        {
            get
            {
                return _rating;
            }
            set
            {
                if (_rating != value)
                {
                    _rating = value; 
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
        public bool CanSpend(TypeProperties properties, int value)
        {
            bool canSpend = false;
            if (properties == TypeProperties.FixedRating)
            {
                canSpend =  CurrentValue >= value;
            }

            return canSpend;
        }

        public event Action<TypeProperties, int> OnRewardGiven;
        public void Reward(TypeProperties properties, int value)
        { 
            if (properties == TypeProperties.FixedRating)
            {
                CurrentValue += value;
            } 
        }
        
        public event Action<TypeProperties, int> OnSpend;
        public void Spend(TypeProperties properties, int value)
        {
            if (properties == TypeProperties.FixedRating)
            {
                if (CanSpend(properties, value))
                {
                    CurrentValue -= value;
                }
            } 
        }
    } 
}

