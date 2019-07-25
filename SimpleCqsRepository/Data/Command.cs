using SimpleCqsRepository.Core.Data;

namespace SimpleCqsRepository.Data
{
    public abstract class Command : Request, ICommand
    {
    }
}