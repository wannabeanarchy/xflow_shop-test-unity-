
using System;

namespace GameTest.Core
{
    public interface ISpendable 
    {  
        event Action OnSpend;
        void Spend(TypeProperties properties, int value);
        bool CanSpend(TypeProperties properties, int value);
    } 
}
