using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace platform.payments.external.protocol.enums;

/// <summary>
/// Represents the available subscription tiers for licensed software access.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SubscriptionTier
{
    /// <summary>
    /// Unknown or invalid entry
    /// </summary>
    [Description("Uknown subscription tier.")]
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Free version with limited features and access.
    /// </summary>
    [Description("Free version with limited features and access.")]
    [EnumMember(Value = "freemium")]
    Freemium,

    /// <summary>
    /// Entry-level subscription with core functionality.
    /// </summary>
    [Description("Entry-level subscription with core functionality.")]
    [EnumMember(Value = "core")]
    Core,

    /// <summary>
    /// Full-featured version with access to all major capabilities.
    /// </summary>
    [Description("Full-featured version with access to all major capabilities.")]
    [EnumMember(Value = "pro")]
    Pro,

    /// <summary>
    /// Enhanced version with multi-threaded performance and advanced features.
    /// </summary>
    [Description("Enhanced version with multi-threaded performance and advanced features.")]
    [EnumMember(Value = "turbo")]
    Turbo,

    /// <summary>
    /// Enterprise-grade tier with API access, multi-threading, and all premium features.
    /// </summary>
    [Description("Enterprise-grade tier with API access, multi-threading, and all premium features.")]
    [EnumMember(Value = "enterprise")]
    Enterprise
}
