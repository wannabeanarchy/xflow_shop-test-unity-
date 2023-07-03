using System.Collections.Generic;
using GameTest.Core; 
using UnityEngine;

namespace GameTest.Shop
{
    public class ShopManager : SingletonOneScene<ShopManager>
    {
        [SerializeField] private ShopItems _shopItems;

        public List<ItemBundle> ListItems => _shopItems.ListItems;

        private void Start()
        {
            foreach (ItemBundle item in ListItems)
            {
                foreach (BundleSpendable bundlePrice in item.ListPricesProperties)
                {
                    bundlePrice.Spendable.OnSpended += item.CanBuy;
                }
            }
        }

        private void OnDisable()
        {
            foreach (ItemBundle item in ListItems)
            {
                foreach (BundleSpendable bundlePrice in item.ListPricesProperties)
                {
                    bundlePrice.Spendable.OnSpended -= item.CanBuy;
                }
            }
        }
    }
}