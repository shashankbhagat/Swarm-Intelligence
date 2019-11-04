using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSwarmIntelligence
{
    class SwarmResult:IComparable<SwarmResult>
    {
        public int SwarmId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double FunctionValue { get; set; }

        public int CompareTo(SwarmResult other)
        {
            return FunctionValue.CompareTo(other.FunctionValue);
        }

        public override string ToString()
        {
            return "SwarmId: " + SwarmId.ToString() + " X: " + X.ToString() + " Y: " + Y.ToString() + " Function Value: " + FunctionValue.ToString();
        }


    }
}
