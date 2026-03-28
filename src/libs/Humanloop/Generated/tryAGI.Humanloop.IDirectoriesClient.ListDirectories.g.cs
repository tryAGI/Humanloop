#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// List Directories
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.Humanloop.DirectoryResponse>> ListDirectoriesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}