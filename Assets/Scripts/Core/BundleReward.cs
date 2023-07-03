using System;
using GameTest.Core;
using Sirenix.Serialization;

namespace GameTest.Common
{
    [Serializable]
    public struct BundleReward
    {
        [OdinSerialize] public IReward Reward;
        [OdinSerialize] public int Value; 
    }
}