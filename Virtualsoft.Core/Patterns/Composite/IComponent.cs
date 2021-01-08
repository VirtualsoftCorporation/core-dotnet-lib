using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Composite
{
    public interface IComponent
    {
        IOperationResponse Operation(params IOperationArgument[] args);
    }
}
