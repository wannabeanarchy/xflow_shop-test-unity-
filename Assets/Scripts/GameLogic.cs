using GameTest.Core;
using GameTest.Gold;
using GameTest.Health;
using GameTest.Rating;
using GameTest.Shop;
using UnityEngine;

public class GameLogic : MonoBehaviour
{  
    void Start()
    {
        HealthManager.Instance().CurrentValue = 100;
        GoldManager.Instance().CurrentValue = 500;
        RatingManager.Instance().CurrentValue = 50;
        
        ShopManager.Instance().AddReward(TypeProperties.FixedHealth, HealthManager.Instance());
        ShopManager.Instance().AddReward(TypeProperties.PercentHealth, HealthManager.Instance());
        ShopManager.Instance().AddReward(TypeProperties.FixedGold, GoldManager.Instance());
        ShopManager.Instance().AddReward(TypeProperties.FixedRating, RatingManager.Instance()); 
        
        ShopManager.Instance().AddSpendable(TypeProperties.FixedHealth, HealthManager.Instance());
        ShopManager.Instance().AddSpendable(TypeProperties.PercentHealth, HealthManager.Instance());
        ShopManager.Instance().AddSpendable(TypeProperties.FixedGold, GoldManager.Instance());
        ShopManager.Instance().AddSpendable(TypeProperties.FixedRating, RatingManager.Instance());
 
    } 
}
