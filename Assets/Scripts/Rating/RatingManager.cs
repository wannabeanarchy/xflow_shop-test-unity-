using System;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Rating
{
    public class RatingManager : SingletonOneScene<RatingManager> 
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

        public void InitManager(int value)
        {
            CurrentValue = value;
        } 
    } 
}

