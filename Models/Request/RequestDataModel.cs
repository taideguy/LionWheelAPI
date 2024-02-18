namespace LionWheelDataTransform.Models.Request
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RequestDataModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("api_version")]
        public long ApiVersion { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("is_unread")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IsUnread { get; set; }

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("user_contact_number")]
        public string UserContactNumber { get; set; }

        [JsonProperty("user_company_name")]
        public dynamic UserCompanyName { get; set; }

        [JsonProperty("automatic_discount")]
        public dynamic AutomaticDiscount { get; set; }

        [JsonProperty("automatic_discount_code")]
        public dynamic AutomaticDiscountCode { get; set; }

        [JsonProperty("automatic_discount_id")]
        public dynamic AutomaticDiscountId { get; set; }

        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        [JsonProperty("shipping_name")]
        public string ShippingName { get; set; }

        [JsonProperty("shipping_amount")]
        public string ShippingAmount { get; set; }

        [JsonProperty("tax_amount")]
        public string TaxAmount { get; set; }

        [JsonProperty("tax_meta")]
        public dynamic[] TaxMeta { get; set; }

        [JsonProperty("discount_name")]
        public dynamic DiscountName { get; set; }

        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        [JsonProperty("sale_id")]
        public dynamic SaleId { get; set; }

        [JsonProperty("sale_name")]
        public dynamic SaleName { get; set; }

        [JsonProperty("sale_amount")]
        public dynamic SaleAmount { get; set; }

        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        [JsonProperty("seller_charged_name")]
        public dynamic SellerChargedName { get; set; }

        [JsonProperty("seller_charged_amount")]
        public dynamic SellerChargedAmount { get; set; }

        [JsonProperty("currency_paid_in")]
        public string CurrencyPaidIn { get; set; }

        [JsonProperty("currency_paid_in_symbol")]
        public string CurrencyPaidInSymbol { get; set; }

        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }

        [JsonProperty("payment_transaction_id")]
        public string PaymentTransactionId { get; set; }

        [JsonProperty("payment_method_id")]
        public string PaymentMethodId { get; set; }

        [JsonProperty("payment_method_name")]
        public string PaymentMethodName { get; set; }

        [JsonProperty("raw_payment_method_name")]
        public string RawPaymentMethodName { get; set; }

        [JsonProperty("billing_address")]
        public string BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("order_notes")]
        public dynamic OrderNotes { get; set; }

        [JsonProperty("store_environment")]
        public string StoreEnvironment { get; set; }

        [JsonProperty("payment_payload")]
        public PaymentPayload PaymentPayload { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("is_draft")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long IsDraft { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_link")]
        public Uri InvoiceLink { get; set; }

        [JsonProperty("source_url")]
        public Uri SourceUrl { get; set; }

        [JsonProperty("customer_tax_id")]
        public dynamic CustomerTaxId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("v1_ref")]
        public dynamic V1Ref { get; set; }

        [JsonProperty("review_email_at")]
        public dynamic ReviewEmailAt { get; set; }

        [JsonProperty("cart_session")]
        public string CartSession { get; set; }

        [JsonProperty("abandoned_emails_count")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AbandonedEmailsCount { get; set; }

        [JsonProperty("abandoned_at")]
        public dynamic AbandonedAt { get; set; }

        [JsonProperty("deleted_at")]
        public dynamic DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("meta_data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("offers")]
        public dynamic[] Offers { get; set; }

        [JsonProperty("line_items")]
        public LineItem[] LineItems { get; set; }

        [JsonProperty("address")]
        public DataAddress Address { get; set; }

        [JsonProperty("shipping")]
        public Shipping[] Shipping { get; set; }

        [JsonProperty("taxes")]
        public Taxes Taxes { get; set; }
    }

    public partial class DataAddress
    {
        [JsonProperty("billing")]
        public AddressBilling Billing { get; set; }

        [JsonProperty("shipping")]
        public AddressBilling Shipping { get; set; }
    }

    public partial class AddressBilling
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
        public dynamic AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StateId { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_id")]
        public dynamic CountryId { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("contact_number")]
        public string ContactNumber { get; set; }

        [JsonProperty("company_name")]
        public dynamic CompanyName { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("deleted_at")]
        public dynamic DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public dynamic UpdatedAt { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("state_name")]
        public string StateName { get; set; }

        [JsonProperty("state_code")]
        public dynamic StateCode { get; set; }
    }

    public partial class LineItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_sku")]
        public dynamic ItemSku { get; set; }

        [JsonProperty("item_sku_id")]
        public dynamic ItemSkuId { get; set; }

        [JsonProperty("item_sku_attachment")]
        public dynamic ItemSkuAttachment { get; set; }

        [JsonProperty("item_options")]
        public dynamic ItemOptions { get; set; }

        [JsonProperty("item_image")]
        public string ItemImage { get; set; }

        [JsonProperty("unit_price")]
        public string UnitPrice { get; set; }

        [JsonProperty("quantity")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Quantity { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("item_tax_meta")]
        public dynamic ItemTaxMeta { get; set; }

        [JsonProperty("discount_name")]
        public dynamic DiscountName { get; set; }

        [JsonProperty("discount_amount")]
        public dynamic DiscountAmount { get; set; }

        [JsonProperty("sale_amount")]
        public dynamic SaleAmount { get; set; }

        [JsonProperty("item_license_key")]
        public dynamic ItemLicenseKey { get; set; }

        [JsonProperty("item_source_url")]
        public Uri ItemSourceUrl { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("reviewed_at")]
        public dynamic ReviewedAt { get; set; }

        [JsonProperty("deleted_at")]
        public dynamic DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public dynamic UpdatedAt { get; set; }

        [JsonProperty("item_variation_sku")]
        public dynamic ItemVariationSku { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("product_price")]
        public string ProductPrice { get; set; }

        [JsonProperty("product_email_info")]
        public dynamic ProductEmailInfo { get; set; }

        [JsonProperty("product_quantity")]
        public dynamic ProductQuantity { get; set; }

        [JsonProperty("require_delivery_or_collection")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long RequireDeliveryOrCollection { get; set; }

        [JsonProperty("shipping_type")]
        public string ShippingType { get; set; }

        [JsonProperty("min_order_quantity")]
        public dynamic MinOrderQuantity { get; set; }

        [JsonProperty("max_order_quantity")]
        public dynamic MaxOrderQuantity { get; set; }

        [JsonProperty("sku")]
        public dynamic Sku { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_slug")]
        public string CategorySlug { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }
    }

    public partial class MetaData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("ip_lat")]
        public dynamic IpLat { get; set; }

        [JsonProperty("ip_long")]
        public dynamic IpLong { get; set; }

        [JsonProperty("ip_country")]
        public string IpCountry { get; set; }

        [JsonProperty("ip_continent")]
        public dynamic IpContinent { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("deleted_at")]
        public dynamic DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public dynamic UpdatedAt { get; set; }
    }

    public partial class PaymentPayload
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customerId")]
        public dynamic CustomerId { get; set; }

        [JsonProperty("livemode")]
        public string Livemode { get; set; }

        [JsonProperty("receipt_url")]
        public dynamic ReceiptUrl { get; set; }

        [JsonProperty("billing")]
        public PaymentPayloadBilling Billing { get; set; }

        [JsonProperty("shipping")]
        public PaymentPayloadBilling Shipping { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }
    }

    public partial class PaymentPayloadBilling
    {
        [JsonProperty("address")]
        public BillingAddress Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public partial class BillingAddress
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public partial class PaymentMethod
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Shipping
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("item_id")]
        public dynamic ItemId { get; set; }

        [JsonProperty("shipping_name")]
        public string ShippingName { get; set; }

        [JsonProperty("price_type")]
        public string PriceType { get; set; }

        [JsonProperty("base_price")]
        public string BasePrice { get; set; }

        [JsonProperty("weight_multiple")]
        public dynamic WeightMultiple { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Status { get; set; }

        [JsonProperty("deleted_at")]
        public dynamic DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public dynamic UpdatedAt { get; set; }
    }

    public partial class Taxes
    {
        [JsonProperty("inclusive")]
        public dynamic[] Inclusive { get; set; }

        [JsonProperty("exclusive")]
        public dynamic[] Exclusive { get; set; }
    }

    public partial class RequestDataModel
    {
        public static RequestDataModel FromJson(string json) => JsonConvert.DeserializeObject<RequestDataModel>(json, LionWheelDataTransform.Models.Request.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RequestDataModel self) => JsonConvert.SerializeObject(self, LionWheelDataTransform.Models.Request.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
