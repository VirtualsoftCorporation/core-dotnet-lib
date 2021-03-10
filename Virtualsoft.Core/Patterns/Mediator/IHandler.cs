using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Virtualsoft.Core.Patterns.Mediator
{
    public interface IHandler<E, K>
        where E : IRequest
        where K : IResponse
    {
        public Guid Id { get; }

        public bool IsRequestHandler(Guid id);

        public Task<K> Handle(E request);
    }
}
