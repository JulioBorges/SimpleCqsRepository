using System;
using SimpleCqsRepository.Core.Data;

namespace SimpleCqsRepository.Data
{
    public abstract class Request : IRequest
    {
        protected Request()
        {
            RequestId = Guid.NewGuid();
        }

        public Guid RequestId { get; set; }
    }
}