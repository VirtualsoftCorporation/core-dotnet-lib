using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Factory
{
    public interface IFactory
    {
        bool isProducer(IProductId id);
        
        IProduct CreateProduct();
    }
}
