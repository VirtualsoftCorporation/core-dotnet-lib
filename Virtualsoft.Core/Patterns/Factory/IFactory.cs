using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Factory
{
    public interface IFactory
    {
        public bool isProducer(Guid id);
        
        public IProduct CreateProduct();
    }
}
