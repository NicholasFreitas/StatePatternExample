using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    class ClassStateOne : IObjectState
    {
        IStatefulObject _statefulObject;

        public ClassStateOne(IStatefulObject statefulObject)
        {
            _statefulObject = statefulObject;
        }

        public void AlgorithmA()
        {            
            _statefulObject.ChangeState(new ClassStateTwo(_statefulObject));

        }

        public void AlgorithmB()
        {
            _statefulObject.ChangeState(new ClassStateOne(_statefulObject));
            
        }

        public void AlgorithmC()
        {
            _statefulObject.DefaultState();
            
        }
    }
}
