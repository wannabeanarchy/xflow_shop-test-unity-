using System;
using System.Collections.Generic;
using GameTest.Common;
using GameTest.Core;
using Sirenix.Serialization;
using UnityEngine;

namespace GameTest.Shop
{
    public class ShopManager : SingletonOneScene<ShopManager>
    {
        [SerializeField] private ShopItems _shopItems; 

        [OdinSerialize] private Dictionary<TypeProperties, IReward> _dictionaryRewards = new();
        [OdinSerialize] private Dictionary<TypeProperties, ISpendable> _dictionarySpendable = new();
       
        
        public Dictionary<TypeProperties, IReward> DictionaryRewards => _dictionaryRewards;
        public Dictionary<TypeProperties, ISpendable> DictionarySpendable => _dictionarySpendable;
        public List<ItemBundle>  ListItems => _shopItems.ListItems;
         
    } 
}