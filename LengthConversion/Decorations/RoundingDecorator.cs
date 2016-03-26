using System;
using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    public class RoundingDecorator : Decorator
    {
        public RoundingDecorator(IResult result) : base(result)
        {
            Value = Math.Round(result.Value, 2);
        }
    }
}
