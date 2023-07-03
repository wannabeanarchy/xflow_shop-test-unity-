using GameTest.Core;

namespace GameTest.Rating
{
    public class RatingReward : IReward
    {
        public void Reward(int value)
        {  
              RatingManager.Instance(). CurrentValue += value;
        }
    }
}