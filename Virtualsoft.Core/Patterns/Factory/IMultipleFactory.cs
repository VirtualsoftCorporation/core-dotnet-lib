using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Factory
{
    public interface IMultipleFactory : IFactory
    {
        public bool IsProducer(IEnumerable<Guid> ids);

        public IEnumerable<IProduct> CreateProducts();
    }
}
