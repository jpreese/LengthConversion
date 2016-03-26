namespace LengthConversion.Models
{
    public class Result
    {
        public double Value { get; set; }

        public virtual string GetValue()
        {
            return Value.ToString();
        }
    }
}
