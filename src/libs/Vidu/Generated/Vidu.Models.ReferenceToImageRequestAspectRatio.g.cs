
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReferenceToImageRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferenceToImageRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferenceToImageRequestAspectRatio value)
        {
            return value switch
            {
                ReferenceToImageRequestAspectRatio.x16_9 => "16:9",
                ReferenceToImageRequestAspectRatio.x1_1 => "1:1",
                ReferenceToImageRequestAspectRatio.x3_4 => "3:4",
                ReferenceToImageRequestAspectRatio.x4_3 => "4:3",
                ReferenceToImageRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferenceToImageRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ReferenceToImageRequestAspectRatio.x16_9,
                "1:1" => ReferenceToImageRequestAspectRatio.x1_1,
                "3:4" => ReferenceToImageRequestAspectRatio.x3_4,
                "4:3" => ReferenceToImageRequestAspectRatio.x4_3,
                "9:16" => ReferenceToImageRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}