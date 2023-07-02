
using System;

namespace GameTest.Core
{
    public interface ISpendable 
    {  
        event Action<TypeProperties, int> OnSpend;
        void Spend(TypeProperties properties, int value);
    } 
}
