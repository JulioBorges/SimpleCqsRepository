using SimpleCqsRepository.Core.Data;
using System.Threading.Tasks;

namespace SimpleCqsRepository.Core.Cqs
{
    /// <summary>
    /// Passed around to all allow dispatching a command and to be mocked by unit tests
    /// </summary>
    public interface ICommandDispatcher
    {
        /// <summary>
        /// Dispatches a command to its handler
        /// </summary>
        /// <typeparam name="TParameter">Command Type</typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command">The command to be passed to the handler</param>
        TResult Dispatch<TParameter, TResult>(TParameter command) where TParameter : ICommand where TResult : IResult;


        /// <summary>
        /// Dispatches an async command to its handler
        /// </summary>
        /// <typeparam name="TParameter">Command Type</typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="command">The command to be passed to the handler</param>
        Task<TResult> DispatchAsync<TParameter, TResult>(TParameter command) where TParameter : ICommand where TResult : IResult;
    }
}