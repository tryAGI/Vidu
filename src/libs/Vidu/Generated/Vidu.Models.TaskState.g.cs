
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Task lifecycle state.
    /// </summary>
    public enum TaskState
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Queueing,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskState value)
        {
            return value switch
            {
                TaskState.Created => "created",
                TaskState.Failed => "failed",
                TaskState.Processing => "processing",
                TaskState.Queueing => "queueing",
                TaskState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskState? ToEnum(string value)
        {
            return value switch
            {
                "created" => TaskState.Created,
                "failed" => TaskState.Failed,
                "processing" => TaskState.Processing,
                "queueing" => TaskState.Queueing,
                "success" => TaskState.Success,
                _ => null,
            };
        }
    }
}