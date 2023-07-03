using System;
using System.Collections.Generic;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Shop
{
    [Serializable]
    public class ItemBundle  
    {
        [SerializeField] private string _name;
        [SerializeField] private List<BundleSpendable> _priceProperties = new ();
        [SerializeField] private List<BundleReward> _rewardProperties = new ();
     
        private bool _available; 

        public string Name => _name;

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
            foreach (BundleSpendable bundle in _priceProperties)
            { 
                bundle.Spendable.Spend(bundle.Value);  
            }

            foreach (BundleReward bundle in _rewardProperties)
            {
                bundle.Reward.Reward(bundle.Value); 
            } 
        }

        public void CanBuy()
        { 
            foreach (BundleSpendable bundle in _priceProperties)
            { 
                Available = bundle.Spendable.CanSpend(bundle.Value);

                if (!Available)
                    break;
            }  
        }
    }
}