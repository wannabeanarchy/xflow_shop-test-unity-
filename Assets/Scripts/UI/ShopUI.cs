using System;
using GameTest.Core;
using GameTest.Gold;
using GameTest.Health;
using GameTest.Rating;
using GameTest.Shop;
using UnityEngine;

namespace GameTest.UI
{
    public class ShopUI : MonoBehaviour
    {
        [SerializeField] private Transform _containerItemsShop;
        [SerializeField] private ItemUI _prefabItem;
        
        public void Start()
        {
            foreach (ItemBundle item in ShopManager.Instance().ListItems)
            { 
                ItemUI shopItem = Instantiate(_prefabItem, _containerItemsShop); 
                shopItem.TextItem.text = item.Name;  
                shopItem.ButtonItem.onClick.AddListener(item.BuyItem);
             
                item.Changed += shopItem.SetInteractable; 
            }
        } 
    }
}