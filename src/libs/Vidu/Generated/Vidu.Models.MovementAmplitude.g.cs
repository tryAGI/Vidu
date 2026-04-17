
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Camera movement amplitude.
    /// </summary>
    public enum MovementAmplitude
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MovementAmplitudeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MovementAmplitude value)
        {
            return value switch
            {
                MovementAmplitude.Auto => "auto",
                MovementAmplitude.Large => "large",
                MovementAmplitude.Medium => "medium",
                MovementAmplitude.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MovementAmplitude? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MovementAmplitude.Auto,
                "large" => MovementAmplitude.Large,
                "medium" => MovementAmplitude.Medium,
                "small" => MovementAmplitude.Small,
                _ => null,
            };
        }
    }
}