using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    class ClassStateTwo : IObjectState
    {
        IStatefulObject _statefulObject;

        public ClassStateTwo(IStatefulObject stateful)
        {
            _statefulObject = stateful;
        }

        public void AlgorithmA()
        {
            _statefulObject.ChangeState(new ClassStateOne(_statefulObject));

        }

        public void AlgorithmB()
        {
            _statefulObject.ChangeState(new ClassStateTwo(_statefulObject));

        }

        public void AlgorithmC()
        {
            _statefulObject.DefaultState();
            
        }
    }
}
