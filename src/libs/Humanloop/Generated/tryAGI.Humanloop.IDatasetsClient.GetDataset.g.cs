#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="includeDatapoints"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.DatasetResponse> GetDatasetAsync(
            string id,
            string? versionId = default,
            bool? includeDatapoints = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}