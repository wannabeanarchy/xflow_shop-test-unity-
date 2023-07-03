using GameTest.Core;
using GameTest.Health;

namespace GameTest.Rating
{
    public class FixedHealthReward : IReward
    {
        public void Reward(int value)
        {
            HealthManager.Instance().CurrentValue += value;
        }
    }
}