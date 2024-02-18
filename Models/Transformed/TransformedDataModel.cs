namespace LionWheelDataTransform.Models.Transformed
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

     
    

    public partial class TransformedDataModel
{
        [JsonProperty("pickup_at")]
        public string PickupAt { get; set; }

        [JsonProperty("company_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CompanyId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("original_order_id")]
        public string OriginalOrderId { get; set; }

        [JsonProperty("source_city")]
        public string SourceCity { get; set; }

        [JsonProperty("source_street")]
        public string SourceStreet { get; set; }

        [JsonProperty("source_number")]
        public string SourceNumber { get; set; }

        [JsonProperty("source_zip_code")]
        public string SourceZipCode { get; set; }

        [JsonProperty("source_floor")]
        public string SourceFloor { get; set; }

        [JsonProperty("source_apartment")]
        public string SourceApartment { get; set; }

        [JsonProperty("source_notes")]
        public string SourceNotes { get; set; }

        [JsonProperty("source_recipient_name")]
        public string SourceRecipientName { get; set; }

        [JsonProperty("source_phone")]
        public string SourcePhone { get; set; }

        [JsonProperty("source_email")]
        public string SourceEmail { get; set; }

        [JsonProperty("source_latitude")]
        public string SourceLatitude { get; set; }

        [JsonProperty("source_longitude")]
        public string SourceLongitude { get; set; }

        [JsonProperty("destination_city")]
        public string DestinationCity { get; set; }

        [JsonProperty("destination_street")]
        public string DestinationStreet { get; set; }

        [JsonProperty("destination_number")]
        public string DestinationNumber { get; set; }

        [JsonProperty("destination_zip_code")]
        public string DestinationZipCode { get; set; }

        [JsonProperty("destination_floor")]
        public string DestinationFloor { get; set; }

        [JsonProperty("destination_apartment")]
        public string DestinationApartment { get; set; }

        [JsonProperty("destination_notes")]
        public string DestinationNotes { get; set; }

        [JsonProperty("destination_recipient_name")]
        public string DestinationRecipientName { get; set; }

        [JsonProperty("destination_phone")]
        public string DestinationPhone { get; set; }

        [JsonProperty("destination_phone2")]
        public string DestinationPhone2 { get; set; }

        [JsonProperty("destination_email")]
        public string DestinationEmail { get; set; }

        [JsonProperty("destination_latitude")]
        public string DestinationLatitude { get; set; }

        [JsonProperty("destination_longitude")]
        public string DestinationLongitude { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("gifter_name")]
        public string GifterName { get; set; }

        [JsonProperty("gifter_phone")]
        public string GifterPhone { get; set; }

        [JsonProperty("is_roundtrip")]
        public bool IsRoundtrip { get; set; }

        [JsonProperty("packages_quantity")]
        public long PackagesQuantity { get; set; }

        [JsonProperty("money_collect")]
        public long MoneyCollect { get; set; }

        [JsonProperty("is_self_pickup")]
        public bool IsSelfPickup { get; set; }

        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("line_items")]
        public LineItem[] LineItems { get; set; }

        [JsonProperty("urgency")]
        public long Urgency { get; set; }

        [JsonProperty("driver_id")]
        public string DriverId { get; set; }
    }

    public partial class LineItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
    }

    public partial class TransformedDataModel
    {
        public static TransformedDataModel FromJson(string json) => JsonConvert.DeserializeObject<TransformedDataModel>(json, LionWheelDataTransform.Models.Transformed.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TransformedDataModel self) => JsonConvert.SerializeObject(self, LionWheelDataTransform.Models.Transformed.Converter.Settings);
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


