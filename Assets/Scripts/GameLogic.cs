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
        
        ShopManager.Instance().AddReward(HealthManager.Instance());
        ShopManager.Instance().AddReward(GoldManager.Instance());
        ShopManager.Instance().AddReward(RatingManager.Instance()); 
        
        ShopManager.Instance().AddSpendable(HealthManager.Instance());
        ShopManager.Instance().AddSpendable(GoldManager.Instance());
        ShopManager.Instance().AddSpendable(RatingManager.Instance());
         
    } 
}
