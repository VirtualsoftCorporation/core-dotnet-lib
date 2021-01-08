using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Builder
{
    public interface IBuilder<T> where T : IBuild
    {
        T build();
    }
}
