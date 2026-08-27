
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Image generation model (viduq1 or viduq2).
    /// </summary>
    public enum ReferenceToImageRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        Viduq1,
        /// <summary>
        ///
        /// </summary>
        Viduq2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferenceToImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferenceToImageRequestModel value)
        {
            return value switch
            {
                ReferenceToImageRequestModel.Viduq1 => "viduq1",
                ReferenceToImageRequestModel.Viduq2 => "viduq2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferenceToImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "viduq1" => ReferenceToImageRequestModel.Viduq1,
                "viduq2" => ReferenceToImageRequestModel.Viduq2,
                _ => null,
            };
        }
    }
}