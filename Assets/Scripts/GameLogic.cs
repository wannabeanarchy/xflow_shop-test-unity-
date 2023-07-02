using GameTest.Gold;
using GameTest.Health;
using GameTest.Rating; 
using UnityEngine;

public class GameLogic : MonoBehaviour
{  
    void Start()
    {
        HealthManager.Instance().InitManager(100);  
        GoldManager.Instance().InitManager(500);  
        RatingManager.Instance().InitManager(50);  
    } 
}
