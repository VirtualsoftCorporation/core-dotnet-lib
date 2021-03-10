using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Composite
{
    public interface IComponent
    {
        public IOperationResponse Operation(params IOperationArgument[] args);
    }
}
