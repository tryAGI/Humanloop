#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PaginatedFileResponse> ListFilesAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::tryAGI.Humanloop.ListFilesType? type = default,
            string? sortBy = default,
            global::tryAGI.Humanloop.ListFilesOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}