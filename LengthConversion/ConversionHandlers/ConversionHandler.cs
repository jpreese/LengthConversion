using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public abstract class ConversionHandler
    {
        protected ConversionHandler _next;

        public abstract IResult Convert(Kilometer kilometer);

        public void SetNext(ConversionHandler next)
        {
            _next = next;
        }
    }
}
