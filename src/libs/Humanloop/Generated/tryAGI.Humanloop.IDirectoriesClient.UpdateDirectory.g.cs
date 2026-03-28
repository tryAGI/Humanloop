#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Update Directory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.DirectoryResponse> UpdateDirectoryAsync(
            string id,

            global::tryAGI.Humanloop.UpdateDirectoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Directory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path"></param>
        /// <param name="parentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.DirectoryResponse> UpdateDirectoryAsync(
            string id,
            string? path = default,
            string? parentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}