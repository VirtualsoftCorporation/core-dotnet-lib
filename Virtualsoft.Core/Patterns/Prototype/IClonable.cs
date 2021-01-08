using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Prototype
{
    public interface IClonable<T> where T : IPrototype
    {
        T Clone();
    }
}
