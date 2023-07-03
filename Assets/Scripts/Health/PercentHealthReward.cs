using GameTest.Core;
using GameTest.Health;

namespace GameTest.Rating
{
    public class PercentHealthReward : IReward
    {
        public void Reward(int value)
        {  
            int healthToAdd = HealthManager.Instance().CalculatePercentHealthValue(value / 100f); 
            HealthManager.Instance().CurrentValue += healthToAdd;  
        }
    }
}