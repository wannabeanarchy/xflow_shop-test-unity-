using System.Collections.Generic; 
using UnityEngine;

namespace GameTest.Common
{
    [CreateAssetMenu(fileName = "ShopItems", menuName = "Shop/ShopItems")]
    public class ShopItems : ScriptableObject
    {
        public List<ItemBundle> ListItems = new List<ItemBundle>();
    }
}