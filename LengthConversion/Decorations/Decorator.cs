using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    public class Decorator : Result
    {
        protected Result _result;

        public Decorator(Result result)
        {
            _result = result;
        }

        public override string GetValue()
        {
            return _result.GetValue();
        }
    }
}
