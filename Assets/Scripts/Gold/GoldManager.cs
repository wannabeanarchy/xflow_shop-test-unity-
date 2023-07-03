using System;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Gold
{
    public class GoldManager : SingletonOneScene<GoldManager> 
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

        public void InitManager(int value)
        {
            CurrentValue = value;
        } 
    } 
}

