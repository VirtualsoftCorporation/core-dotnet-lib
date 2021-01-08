using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Composite
{
    public interface IComposite : IComponent
    {
        void Add(IComponent component);

        void Remove(IComponent component);
    }
}
