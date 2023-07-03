using GameTest.Core;
using GameTest.Gold;

namespace GameTest.Rating
{
    public class GoldSpendable : ISpendable
    {
        public bool CanSpend(int value)
        {
            return GoldManager.Instance().CurrentValue >= value;
        }

        public void Spend(int value)
        {
            if (CanSpend(value))
            {
                GoldManager.Instance().CurrentValue -= value;
            }
        }
    }
}