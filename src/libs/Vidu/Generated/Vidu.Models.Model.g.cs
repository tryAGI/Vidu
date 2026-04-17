
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Vidu model name.
    /// </summary>
    public enum Model
    {
        /// <summary>
        /// 
        /// </summary>
        Vidu20,
        /// <summary>
        /// 
        /// </summary>
        Viduq1,
        /// <summary>
        /// 
        /// </summary>
        Viduq2,
        /// <summary>
        /// 
        /// </summary>
        Viduq2Pro,
        /// <summary>
        /// 
        /// </summary>
        Viduq3,
        /// <summary>
        /// 
        /// </summary>
        Viduq3Mix,
        /// <summary>
        /// 
        /// </summary>
        Viduq3Pro,
        /// <summary>
        /// 
        /// </summary>
        Viduq3Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Model value)
        {
            return value switch
            {
                Model.Vidu20 => "vidu2.0",
                Model.Viduq1 => "viduq1",
                Model.Viduq2 => "viduq2",
                Model.Viduq2Pro => "viduq2-pro",
                Model.Viduq3 => "viduq3",
                Model.Viduq3Mix => "viduq3-mix",
                Model.Viduq3Pro => "viduq3-pro",
                Model.Viduq3Turbo => "viduq3-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Model? ToEnum(string value)
        {
            return value switch
            {
                "vidu2.0" => Model.Vidu20,
                "viduq1" => Model.Viduq1,
                "viduq2" => Model.Viduq2,
                "viduq2-pro" => Model.Viduq2Pro,
                "viduq3" => Model.Viduq3,
                "viduq3-mix" => Model.Viduq3Mix,
                "viduq3-pro" => Model.Viduq3Pro,
                "viduq3-turbo" => Model.Viduq3Turbo,
                _ => null,
            };
        }
    }
}