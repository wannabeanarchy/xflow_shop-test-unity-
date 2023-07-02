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
 
        public void BuyItem()
        {   
            foreach (Bundle bundle in _priceProperties)
            {
                foreach (ISpendable spendable in ShopManager.Instance().ListSpendable)
                { 
                    spendable.Spend(bundle.Type, bundle.Value); 
                }
            }
            foreach (Bundle bundle in _rewardProperties)
            { 
                foreach (IReward reward in ShopManager.Instance().ListRewards)
                { 
                    reward.Reward(bundle.Type, bundle.Value); 
                }
            }
        } 
    }
}