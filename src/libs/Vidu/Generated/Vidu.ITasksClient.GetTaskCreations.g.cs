#nullable enable

namespace Vidu
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get task creations<br/>
        /// Retrieves the status and generated output URLs for a task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.TaskCreations> GetTaskCreationsAsync(
            string id,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}