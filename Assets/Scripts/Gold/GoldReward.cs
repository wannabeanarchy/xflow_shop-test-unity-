using GameTest.Core;
using GameTest.Gold;

namespace GameTest.Rating
{
    public class GoldReward : IReward
    {
        public void Reward(int value)
        {  
            GoldManager.Instance(). CurrentValue += value;
        }
    }
}