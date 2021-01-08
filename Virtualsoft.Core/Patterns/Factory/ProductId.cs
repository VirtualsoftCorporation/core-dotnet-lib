using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Factory
{
    public class ProductId : IProductId
    {
        public Guid Id { get; }

        public ProductId(Guid id)
        {
            this.Id = id;
        }
    }
}
