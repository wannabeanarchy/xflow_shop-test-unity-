using GameTest.Common;
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
                shopItem.ButtonItem.onClick.AddListener(item.BuyItem);
                shopItem.TextItem.text = item.Name;  
            }
        }

        private void BuyItem()
        {
            Debug.Log("Buy Item!");
        }
    }
}