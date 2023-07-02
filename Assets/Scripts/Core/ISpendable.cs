
using System;

namespace GameTest.Core
{
    public interface ISpendable 
    {   
        void Spend(TypeProperties properties, int value);
        bool CanSpend(TypeProperties properties, int value);
    } 
}
