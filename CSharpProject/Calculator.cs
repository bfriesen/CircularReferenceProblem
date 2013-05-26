namespace CSharpProject
{
    public class Calculator
    {
        private readonly INumberConverter _numberConverter;

        public Calculator(INumberConverter numberConverter)
        {
            _numberConverter = numberConverter;
        }

        public Calculator()
            : this(ServiceLocator.Get<INumberConverter>())
        {
        }

        public double Add(Number lhs, Number rhs)
        {
            return _numberConverter.Parse(lhs) + _numberConverter.Parse(rhs);
        }
    }
}