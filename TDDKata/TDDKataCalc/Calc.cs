using System;

namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            string[] arrDigits = digits.Split(',');
            if (arrDigits.Length == 0) return 0;
            int totalSum = 0;
            foreach (var item in arrDigits)
            {
                int result;
                if (int.TryParse(item, out result))
                    totalSum += result;
            }
           return totalSum;
        }
    }
}
