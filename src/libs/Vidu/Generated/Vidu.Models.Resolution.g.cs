
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Output video resolution.
    /// </summary>
    public enum Resolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x360p,
        /// <summary>
        ///
        /// </summary>
        x540p,
        /// <summary>
        ///
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Resolution value)
        {
            return value switch
            {
                Resolution.x1080p => "1080p",
                Resolution.x360p => "360p",
                Resolution.x540p => "540p",
                Resolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Resolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => Resolution.x1080p,
                "360p" => Resolution.x360p,
                "540p" => Resolution.x540p,
                "720p" => Resolution.x720p,
                _ => null,
            };
        }
    }
}