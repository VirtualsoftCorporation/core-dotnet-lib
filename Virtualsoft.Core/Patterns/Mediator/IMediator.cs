using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualsoft.Core.Patterns.Mediator
{
    public interface IMediator
    {
        public void AddHandler<E, K>(IHandler<E, K> handler)
            where E : IRequest
            where K : IResponse;

        public IHandler<E, K> Mediate<E, K>(E request)
            where E : IRequest
            where K : IResponse;
    }
}
