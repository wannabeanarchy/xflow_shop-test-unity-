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

        private Dictionary<TypeProperties, IReward> _dictionaryRewards = new();
        private Dictionary<TypeProperties, ISpendable> _dictionarySpendable = new();

        public Dictionary<TypeProperties, IReward> DictionaryRewards => _dictionaryRewards;
        public Dictionary<TypeProperties, ISpendable> DictionarySpendable => _dictionarySpendable;
        
        public void AddReward(TypeProperties type, IReward reward)
        {
            _dictionaryRewards.Add(type, reward);
        }
         
        public void AddSpendable(TypeProperties type, ISpendable spendable)
        {
            _dictionarySpendable.Add(type, spendable);
        } 

    } 
}