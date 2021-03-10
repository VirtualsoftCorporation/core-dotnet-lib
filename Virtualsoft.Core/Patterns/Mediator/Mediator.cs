using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualsoft.Core.Patterns.Mediator
{
    public class Mediator : IMediator
    {
        private IDictionary<Guid, object> handlers;
        private IDictionary<Guid, object> Handlers
        {
            get
            {
                if (this.handlers == null)
                {
                    this.handlers = new Dictionary<Guid, object>();
                }
                return this.handlers;
            }
        }

        public void AddHandler<E, K>(IHandler<E, K> handler)
            where E : IRequest
            where K : IResponse
        {
            this.Handlers.Add(handler.Id, handler);
        }

        public IHandler<E, K> Mediate<E, K>(E request)
            where E : IRequest
            where K : IResponse
        {
            object handler;
            if (this.Handlers.TryGetValue(request.Id, out handler))
            {
                try
                {
                    return (IHandler<E, K>)handler;
                }
                catch
                {
                    return null;
                }
            }

            return null;
        }
    }
}
