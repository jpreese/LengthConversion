using System;
using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    public class RoundingDecorator : Decorator
    {
        public RoundingDecorator(Result result) : base(result)
        {
            Value = Math.Round(result.Value, 2);
        }

        public override string GetValue()
        {
            return Value.ToString();
        }
    }
}
