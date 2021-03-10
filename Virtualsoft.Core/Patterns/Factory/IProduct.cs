using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Factory
{
    public interface IProduct
    {
        public Guid ProductId { get; }
    }
}
