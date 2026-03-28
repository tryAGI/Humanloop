#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// List Evaluators
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PaginatedEvaluatorResponse> ListEvaluatorsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? sortBy = default,
            global::tryAGI.Humanloop.ListEvaluatorsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}