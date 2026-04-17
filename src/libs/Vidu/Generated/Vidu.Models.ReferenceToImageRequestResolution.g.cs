
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReferenceToImageRequestResolution
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferenceToImageRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferenceToImageRequestResolution value)
        {
            return value switch
            {
                ReferenceToImageRequestResolution.x1080p => "1080p",
                ReferenceToImageRequestResolution.x2k => "2K",
                ReferenceToImageRequestResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferenceToImageRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => ReferenceToImageRequestResolution.x1080p,
                "2K" => ReferenceToImageRequestResolution.x2k,
                "4K" => ReferenceToImageRequestResolution.x4k,
                _ => null,
            };
        }
    }
}