using System.Collections.Generic; 
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace GameTest.Shop
{
    [CreateAssetMenu(fileName = "ShopItems", menuName = "Shop/ShopItems")]
    public class ShopItems : SerializedScriptableObject
    { 
        [OdinSerialize]   public List<ItemBundle> ListItems = new List<ItemBundle>();
    }
}