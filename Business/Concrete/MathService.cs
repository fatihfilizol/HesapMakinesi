using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MathService : IMathService
    {
        public double Addition(Numbers numbers)
        {
            numbers.Total = numbers.Number1 + numbers.Number2;
            return numbers.Total;
        }

        public double Division(Numbers numbers)
        {
            numbers.Division = numbers.Number1 / numbers.Number2;
            return numbers.Division;
        }

        public double ExtractionProcess(Numbers numbers)
        {
            numbers.Extraction = numbers.Number1 - numbers.Number2;
            return numbers.Extraction;
        }

        public double Multiplication(Numbers numbers)
        {
            numbers.Multiplication = numbers.Number1 * numbers.Number2;
            return numbers.Multiplication;
        }
    }
}
