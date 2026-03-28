#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Create Directory
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.DirectoryResponse> CreateDirectoryAsync(

            global::tryAGI.Humanloop.CreateDirectoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Directory
        /// </summary>
        /// <param name="path">
        /// Path for the directory.
        /// </param>
        /// <param name="parentId">
        /// ID of the parent directory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.DirectoryResponse> CreateDirectoryAsync(
            string path,
            string? parentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}