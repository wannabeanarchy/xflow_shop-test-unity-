using System;

namespace GameTest.Core
{ 
	public interface IReward
	{
		event Action OnRewardGiven;
		void Reward(TypeProperties properties, int value);
	}
}