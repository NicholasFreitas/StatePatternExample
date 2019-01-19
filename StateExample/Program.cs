using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var statefulObject = new ConcreteObjectWithState();

            statefulObject.AlgoOne();
            
            statefulObject.DefaultState();

            statefulObject.AlgoTwo();

            statefulObject.DefaultState();

        }
    }
}
