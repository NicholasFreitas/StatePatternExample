using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    interface IStatefulObject
    {

        void ChangeState(IObjectState state);

        void DefaultState();

    }
}
