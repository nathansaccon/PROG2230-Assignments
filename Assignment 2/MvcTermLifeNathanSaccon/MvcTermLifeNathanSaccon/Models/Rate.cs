using System;

namespace MvcTermLifeNathanSaccon
{
    public class Rate
    {
        private static readonly decimal[] table =
            {.50m, .52m, .70m, .87m, 1.22m, 1.57m, 2.26m, 4.35m, 6.61m, 12.53m};

        public static decimal MonthlyPremium(int age, decimal amount)
        {
            int j = index(age);
            if (j == -1)
                throw new Exception("Age out of range");
            return amount * table[j] / 10000m;
        }

        private static int index(int age)
        {
            if (age < 20 || age >= 70)
                return -1;
            else
                return (age - 20) / 5;
        }
    }
}