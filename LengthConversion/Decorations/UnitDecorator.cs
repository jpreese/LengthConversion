using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    class UnitDecorator : Decorator
    {
        private readonly Unit _unit;

        public UnitDecorator(Result result, Unit unit) : base (result)
        {
            _unit = unit;
            Value = result.Value;
        }

        public override string GetValue()
        {
            return string.Join(" ", _result.GetValue(), _unit);
        }
    }
}
