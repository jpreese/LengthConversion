using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    class ExponentialDecorator : Decorator
    {
        public ExponentialDecorator(Result result) : base(result)
        {
            Value = result.Value;
        }

        public override string GetValue()
        {
            return Value.ToString("0.0000e0");
        }
    }
}