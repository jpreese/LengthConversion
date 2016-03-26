using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LengthConversion.Models;

namespace LengthConversion.Decorations
{
    public class Decorator : IResult
    {
        protected IResult _result;

        public Decorator(IResult result)
        {
            _result = result;
        }
        public double Value
        {
            get
            {
                return _result.Value;
            }

            set
            {
                _result.Value = value;
            }
        }
    }
}
