namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            if (digits == null || digits.IndexOf(",,") > -1 || digits.StartsWith(',') || digits.EndsWith(",")) return -1;
            if (digits == string.Empty) return 0;

            string[] arrDigits = digits.Split(',');
            if (arrDigits.Length == 0) return -1;
            int totalSum = 0;
            foreach (var item in arrDigits)
            {
                int result;
                if (int.TryParse(item, out result))
                    totalSum += result;
                else
                {
                    totalSum = -1; break;
                }
            }
            return totalSum;
        }
    }
}
