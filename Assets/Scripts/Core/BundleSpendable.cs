using System;
using GameTest.Core;
using Sirenix.Serialization;

namespace GameTest.Core
{
    [Serializable]
    public struct BundleSpendable
    {
        [OdinSerialize] public ISpendable Spendable;
        [OdinSerialize] public int Value; 
    }
}