
using System;

namespace GameTest.Core
{
    public interface ISpendable 
    {   
        void Spend(int value);
        bool CanSpend(int value);
        event Action OnSpended;  
    } 
}
