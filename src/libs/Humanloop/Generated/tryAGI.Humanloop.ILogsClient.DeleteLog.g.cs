#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Delete Log
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLogAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}