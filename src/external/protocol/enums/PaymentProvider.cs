using System.ComponentModel;
using System.Runtime.Serialization;

namespace platform.payments.external.protocol.enums;

/// <summary>
/// Defines supported external payment providers for subscription processing.
/// </summary>
public enum PaymentProvider
{
    /// <summary>
    /// Unknown or invalid entry
    /// </summary>
    [Description("Uknown payment provider.")]
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Stripe payment gateway.
    /// </summary>
    [Description("Stripe payment gateway")]
    [EnumMember(Value = "stripe")]
    Stripe,

    /// <summary>
    /// PayPal payment gateway.
    /// </summary>
    [Description("PayPal payment gateway")]
    [EnumMember(Value = "paypal")]
    PayPal
}
