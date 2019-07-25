using System;

namespace SimpleCqsRepository.Core.Data
{
    public interface IRequest
    {
        Guid RequestId { get; set; }
    }
}