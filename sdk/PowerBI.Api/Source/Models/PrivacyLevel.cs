// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for PrivacyLevel.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(PrivacyLevelConverter))]
    public struct PrivacyLevel : System.IEquatable<PrivacyLevel>
    {
        private PrivacyLevel(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly PrivacyLevel None = "None";

        public static readonly PrivacyLevel Public = "Public";

        public static readonly PrivacyLevel Organizational = "Organizational";

        public static readonly PrivacyLevel Private = "Private";


        /// <summary>
        /// Underlying value of enum PrivacyLevel
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for PrivacyLevel
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type PrivacyLevel
        /// </summary>
        public bool Equals(PrivacyLevel e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to PrivacyLevel
        /// </summary>
        public static implicit operator PrivacyLevel(string value)
        {
            return new PrivacyLevel(value);
        }

        /// <summary>
        /// Implicit operator to convert PrivacyLevel to string
        /// </summary>
        public static implicit operator string(PrivacyLevel e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum PrivacyLevel
        /// </summary>
        public static bool operator == (PrivacyLevel e1, PrivacyLevel e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum PrivacyLevel
        /// </summary>
        public static bool operator != (PrivacyLevel e1, PrivacyLevel e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for PrivacyLevel
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is PrivacyLevel && Equals((PrivacyLevel)obj);
        }

        /// <summary>
        /// Returns for hashCode PrivacyLevel
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
