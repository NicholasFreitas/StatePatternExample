using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    class ConcreteObjectWithState : IStatefulObject
    {
        IObjectState _currentState;

        public ConcreteObjectWithState()
        {
            DefaultState();
        }

        public void ChangeState(IObjectState state)
        {
            _currentState = state;
        }

        public void DefaultState()
        {
            _currentState = new DefaultState(this);   
        }

        public void AlgoOne()
        {
            _currentState.AlgorithmA();
            Console.WriteLine(_currentState.GetType().ToString());
        }

        public void AlgoTwo()
        {
            _currentState.AlgorithmB();
            Console.WriteLine(_currentState.GetType().ToString());
        }

        public void AlgoThree()
        {
            _currentState.AlgorithmC();
            Console.WriteLine(_currentState.GetType().ToString());
        }

    }
}
