using System;
using System.Collections.Generic;
using System.Text;

namespace Virtualsoft.Core.Patterns.Mediator
{
    public interface IRequest
    {
        public Guid Id { get; }
    }
}
