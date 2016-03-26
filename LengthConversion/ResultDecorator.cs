using LengthConversion.Models;
using LengthConversion.Decorations;

namespace LengthConversion
{
    public class ResultDecorator
    {
        private Result _result;
        private Unit _unit;

        public ResultDecorator(Result result, Unit unit)
        {
            _result = result;
            _unit = unit;
        }

        public Result Decorate()
        {
            _result = new RoundingDecorator(_result);
            _result = new ExponentialDecorator(_result);
            _result = new UnitDecorator(_result, _unit);

            return _result;
        }
    }
}
