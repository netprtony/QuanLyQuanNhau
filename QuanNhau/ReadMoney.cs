using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanNhau
{
    public class ReadMoney
    {
        public string ReadAmountInWords(decimal amount)
        {
            if (amount == 0)
            {
                return "Không đồng";
            }

            string[] units = { "", "nghìn", "triệu", "tỷ", "nghìn tỷ", "triệu tỷ", "tỷ tỷ" };

            int digitGroup = 0;
            string result = "";

            while (amount > 0)
            {
                int threeDigits = (int)(amount % 1000);
                if (threeDigits > 0)
                {
                    result = ReadThreeDigits(threeDigits) + " " + units[digitGroup] + " " + result;
                }

                amount /= 1000;
                digitGroup++;
            }

            return result.Trim();
        }

        static string ReadThreeDigits(int threeDigits)
        {
            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string result = "";

            int hundreds = threeDigits / 100;
            int tens = threeDigits % 100 / 10;
            int onesDigit = threeDigits % 10;

            if (hundreds > 0)
            {
                result += ones[hundreds] + " trăm ";
            }

            if (tens > 1)
            {
                result += ones[tens] + " mươi ";
            }
            else if (tens == 1)
            {
                result += "mười ";
            }

            if (onesDigit > 1)
            {
                result += ones[onesDigit];
            }
            else if (onesDigit == 1)
            {
                result += "một";
            }

            return result.Trim();
        }

    }
}
