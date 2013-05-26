using System.ComponentModel.Composition;
using CSharpProject;

namespace FSharpProject
{
    [Export(typeof(INumberConverter))]
    public class NumberConverter : INumberConverter
    {
        // Pretend really hard that this is written in F#. :)
        public double Parse(Number number)
        {
            return double.Parse(number.Value);
        }
    }
}