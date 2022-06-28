using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace пр15
{
    class ComplexNum
    {
        public string Plus(Complex firstNum, Complex secondNum)
        {
            Complex sum = Complex.Add(firstNum, secondNum);
            return $"{firstNum} + {secondNum} = {sum}";
        }
        public string Minus(Complex firstNum, Complex secondNum)
        {
            Complex subst = Complex.Subtract(firstNum, secondNum);
            return $"{firstNum} - {secondNum} = {subst}";
        }
        public string Ymnozh(Complex firstNum, Complex secondNum)
        {
            Complex mult = Complex.Multiply(firstNum, secondNum);
            return $"{firstNum} * {secondNum} = {mult}";
        }
    }
}
