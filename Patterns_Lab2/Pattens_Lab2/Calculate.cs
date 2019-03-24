using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattens_Lab2
{
    // The 'Target' class
    class HexadecimalCalculator
    {
        public virtual string Calculate(string hexadecimalNumber1, string hexadecimalNumber2)
        {
            return "";
        }
    }

    class RichHexadecimalCalculator : HexadecimalCalculator
    {
        private OctalCalculator _octalCalc = new OctalCalculator();

        public override string Calculate(string hexadecimalNumber1, string hexadecimalNumber2)
        {
            if (hexadecimalNumber1.Length > 7 || hexadecimalNumber2.Length > 7) // проверяем розрядность
                return ""; // в случае ошибки выходим из функции, возвращая пустую строку

            int decimalNumber1 = Convert.ToInt32(hexadecimalNumber1, 16); // переводим 16 -> 10
            int decimalNumber2 = Convert.ToInt32(hexadecimalNumber2, 16);

            string octalNumber1 = Convert.ToString(decimalNumber1, 8); // переводим 10 -> 8
            string octalNumber2 = Convert.ToString(decimalNumber2, 8);

            string octalResult = _octalCalc.Calculate(octalNumber1, octalNumber2); // получаем рузельтат из восьмиричного калькулятора
            int decimalResult = Convert.ToInt32(octalResult, 8); // переводим результат 8 -> 10

            return Convert.ToString(decimalResult, 16); // возвращаем результат в шестнадцатеричной СЧ
        }
    }

    // The 'Adaptee' class
    class OctalCalculator
    {
        public string Calculate(string octalNumber1, string octalNumber2)
        {
            if (octalNumber1.Length > 10 || octalNumber2.Length > 10) // проверяем разрядность
                return "";

            int decimalNumber1 = Convert.ToInt32(octalNumber1, 8); // переводим 8 -> 10
            int decimalNumber2 = Convert.ToInt32(octalNumber2, 8);

            return Convert.ToString(decimalNumber1 + decimalNumber2, 8); // суммируем десятичные числа и возвращаем результат в восьмиричной СЧ
        }
    }
}
