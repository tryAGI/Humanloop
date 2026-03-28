#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get File by Path
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.FileResponse> GetFileByPathAsync(
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}