using System.Collections.Generic;
using GameTest.Core; 
using UnityEngine;

namespace GameTest.Shop
{
    public class ShopManager : SingletonOneScene<ShopManager>
    {
        [SerializeField] private ShopItems _shopItems; 
 
        public List<ItemBundle>  ListItems => _shopItems.ListItems;
         
    } 
}