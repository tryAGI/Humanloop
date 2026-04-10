#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PaginatedDatasetResponse> ListDatasetsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? sortBy = default,
            global::tryAGI.Humanloop.ListDatasetsOrder? order = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}