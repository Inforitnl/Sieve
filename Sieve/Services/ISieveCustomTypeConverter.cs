using System;

namespace Sieve.Services
{
    /// <summary>
    /// Interface for implementing custom type conversions to be able to filter or sort on a non system type.
    /// </summary>
    public interface ISieveCustomTypeConverter
    {
        /// <summary>
        /// Determines wether this converter is able to convert given type.
        /// </summary>
        /// <param name="targetType"></param>
        /// <returns></returns>
        bool CanConvert(Type targetType);

        /// <summary>
        /// Converts value to target type.
        /// </summary>
        object Convert(string value);
    }
}
