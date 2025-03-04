// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PlanRequesterInfo : IUtf8JsonSerializable, IJsonModel<PlanRequesterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlanRequesterInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PlanRequesterInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanRequesterInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlanRequesterInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (options.Format != "W" && Optional.IsDefined(Date))
            {
                writer.WritePropertyName("date"u8);
                writer.WriteStringValue(Date);
            }
            if (options.Format != "W" && Optional.IsDefined(Justification))
            {
                writer.WritePropertyName("justification"u8);
                writer.WriteStringValue(Justification);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(SubscriptionName))
            {
                writer.WritePropertyName("subscriptionName"u8);
                writer.WriteStringValue(SubscriptionName);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PlanRequesterInfo IJsonModel<PlanRequesterInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanRequesterInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlanRequesterInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlanRequesterInfo(document.RootElement, options);
        }

        internal static PlanRequesterInfo DeserializePlanRequesterInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> user = default;
            Optional<string> date = default;
            Optional<string> justification = default;
            Optional<string> subscriptionId = default;
            Optional<string> subscriptionName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("date"u8))
                {
                    date = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justification"u8))
                {
                    justification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PlanRequesterInfo(user.Value, date.Value, justification.Value, subscriptionId.Value, subscriptionName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlanRequesterInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanRequesterInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PlanRequesterInfo)} does not support '{options.Format}' format.");
            }
        }

        PlanRequesterInfo IPersistableModel<PlanRequesterInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanRequesterInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlanRequesterInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlanRequesterInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlanRequesterInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
