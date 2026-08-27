
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Target resolution. Must be higher than the source resolution.
    /// </summary>
    public enum UpscaleRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        x1080p,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x8k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleRequestResolution value)
        {
            return value switch
            {
                UpscaleRequestResolution.x1080p => "1080p",
                UpscaleRequestResolution.x2k => "2K",
                UpscaleRequestResolution.x4k => "4K",
                UpscaleRequestResolution.x8k => "8K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => UpscaleRequestResolution.x1080p,
                "2K" => UpscaleRequestResolution.x2k,
                "4K" => UpscaleRequestResolution.x4k,
                "8K" => UpscaleRequestResolution.x8k,
                _ => null,
            };
        }
    }
}