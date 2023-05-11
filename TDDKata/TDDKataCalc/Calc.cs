using System.Collections.Generic;

namespace TDDKataCalc
{
    public class Calc
    {
        public int Add(string digits)
        {
            if (digits == null || digits.IndexOf(",,") > -1 || digits.StartsWith(',') || digits.EndsWith(",") || digits.StartsWith("\n") || digits.EndsWith("\n")) return -1;
            if (digits == string.Empty) return 0;
            if (digits.StartsWith("//;") && !digits.StartsWith("//;\n")) return -1;

            if (digits.IndexOf('\n') > -1) { digits = digits.Replace('\n', ','); }
            if (digits.IndexOf(';') > -1) { digits = digits.Replace(';', ','); }

            string[] arrDigits = digits.Split(',');
            if (arrDigits.Length == 0) return -1;
            int totalSum = 0;
            foreach (var item in arrDigits)
            {
                if (string.IsNullOrWhiteSpace(item)) { continue; }
                if (ListOfDelimiters().Contains(item)) { continue; }

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
        private List<string> ListOfDelimiters()
        {
            return new List<string> { ";", "//" };
        }
    }
}
