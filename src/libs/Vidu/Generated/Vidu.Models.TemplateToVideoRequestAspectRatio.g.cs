
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplateToVideoRequestAspectRatio
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
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateToVideoRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateToVideoRequestAspectRatio value)
        {
            return value switch
            {
                TemplateToVideoRequestAspectRatio.x16_9 => "16:9",
                TemplateToVideoRequestAspectRatio.x1_1 => "1:1",
                TemplateToVideoRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateToVideoRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => TemplateToVideoRequestAspectRatio.x16_9,
                "1:1" => TemplateToVideoRequestAspectRatio.x1_1,
                "9:16" => TemplateToVideoRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}