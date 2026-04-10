#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List Evaluation Logs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PaginatedLogResponse> ListEvaluationLogsAsync(
            string id,
            int? page = default,
            int? size = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}