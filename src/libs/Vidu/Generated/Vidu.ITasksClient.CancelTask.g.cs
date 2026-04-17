#nullable enable

namespace Vidu
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Cancel task<br/>
        /// Cancels an in-progress task. Some task states cannot be cancelled.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelTaskAsync(
            string id,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}