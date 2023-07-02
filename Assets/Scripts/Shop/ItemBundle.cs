using System;
using System.Collections.Generic;
using GameTest.Core;
using GameTest.Shop;
using UnityEngine;

namespace GameTest.Common
{
    [Serializable]
    public class ItemBundle
    {
        [SerializeField] private string _name;

        [SerializeField]
        private List<Bundle> _priceProperties = new List<Bundle>();
        
        [SerializeField]
        private List<Bundle> _rewardProperties = new List<Bundle>();

        public string Name => _name;

        private bool _available; 
  
        public bool Available 
        {
            get
            {
                return _available;
            }
            set
            {
                if (_available != value)
                {
                    _available = value; 
                    _innerChanged?.Invoke(_available);
                }
            }
        }

        private event Action<bool> _innerChanged;
        public event Action<bool> Changed {
            add 
            {
                _innerChanged += value;
                value(true);
            }
            remove 
            {
                _innerChanged -= value;
            }
        }   

        public void BuyItem()
        {   
            foreach (Bundle bundle in _priceProperties)
            {
                ISpendable spendable = ShopManager.Instance().DictionarySpendable[bundle.Type]; 
                spendable.Spend(bundle.Type, bundle.Value);  
            }

            foreach (Bundle bundle in _rewardProperties)
            {
                IReward reward = ShopManager.Instance().DictionaryRewards[bundle.Type];
                reward.Reward(bundle.Type, bundle.Value); 
            } 
        }

        public void CanBuy()
        { 
            foreach (Bundle bundle in _priceProperties)
            {
                ISpendable spendable = ShopManager.Instance().DictionarySpendable[bundle.Type];
                Available = spendable.CanSpend(bundle.Type, bundle.Value);

                if (!Available)
                    break;
            }  
        }
    }
}