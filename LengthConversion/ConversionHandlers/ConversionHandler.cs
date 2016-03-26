using LengthConversion.Models;

namespace LengthConversion.ConversionHandlers
{
    public abstract class ConversionHandler
    {
        protected ConversionHandler _next;

        public abstract Result Convert(Kilometer kilometer);

        public void SetNext(ConversionHandler next)
        {
            _next = next;
        }
    }
}
