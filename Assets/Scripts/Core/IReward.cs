using System;

namespace GameTest.Core
{ 
	public interface IReward
	{
		event Action<TypeProperties, int> OnRewardGiven;
		void Reward(TypeProperties properties, int value);
	}
}