using Soenneker.Gen.EnumValues;

namespace Soenneker.Stripe.Enums.StripeCollectionMethods;

/// <summary>
/// Stripe invoice collection methods.
/// </summary>
[EnumValue<string>]
public sealed partial class StripeCollectionMethod
{
    public static readonly StripeCollectionMethod ChargeAutomatically = new("charge_automatically");
    public static readonly StripeCollectionMethod SendInvoice = new("send_invoice");
}
