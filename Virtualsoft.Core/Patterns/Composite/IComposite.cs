using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Composite
{
    public interface IComposite : IComponent
    {
        public void Add(IComponent component);

        public void Remove(IComponent component);
    }
}
