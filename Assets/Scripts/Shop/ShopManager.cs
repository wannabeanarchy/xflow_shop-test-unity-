using System.Collections.Generic;
using GameTest.Common;
using GameTest.Core;
using UnityEngine;

namespace GameTest.Shop
{
    public class ShopManager : SingletonOneScene<ShopManager>
    {
        [SerializeField] private ShopItems _shopItems; 
        public List<ItemBundle>  ListItems => _shopItems.ListItems;

        private List<IReward> _listRewards = new();
        private List<ISpendable> _listSpendable = new();

        public List<IReward> ListRewards => _listRewards;
        public List<ISpendable> ListSpendable => _listSpendable;
        
        public void AddReward(IReward reward)
        {
            _listRewards.Add(reward);
        }
         
        public void AddSpendable(ISpendable spendable)
        {
            _listSpendable.Add(spendable);
        }
 
    } 
}