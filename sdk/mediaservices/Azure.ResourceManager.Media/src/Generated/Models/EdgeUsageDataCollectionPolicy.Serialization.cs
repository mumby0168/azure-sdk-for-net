// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class EdgeUsageDataCollectionPolicy : IUtf8JsonSerializable, IJsonModel<EdgeUsageDataCollectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeUsageDataCollectionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeUsageDataCollectionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataCollectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeUsageDataCollectionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DataCollectionFrequency))
            {
                writer.WritePropertyName("dataCollectionFrequency"u8);
                writer.WriteStringValue(DataCollectionFrequency);
            }
            if (Optional.IsDefined(DataReportingFrequency))
            {
                writer.WritePropertyName("dataReportingFrequency"u8);
                writer.WriteStringValue(DataReportingFrequency);
            }
            if (Optional.IsDefined(MaxAllowedUnreportedUsageDuration))
            {
                writer.WritePropertyName("maxAllowedUnreportedUsageDuration"u8);
                writer.WriteStringValue(MaxAllowedUnreportedUsageDuration.Value, "P");
            }
            if (Optional.IsDefined(EventHubDetails))
            {
                writer.WritePropertyName("eventHubDetails"u8);
                writer.WriteObjectValue(EventHubDetails);
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

        EdgeUsageDataCollectionPolicy IJsonModel<EdgeUsageDataCollectionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataCollectionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeUsageDataCollectionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeUsageDataCollectionPolicy(document.RootElement, options);
        }

        internal static EdgeUsageDataCollectionPolicy DeserializeEdgeUsageDataCollectionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dataCollectionFrequency = default;
            Optional<string> dataReportingFrequency = default;
            Optional<TimeSpan> maxAllowedUnreportedUsageDuration = default;
            Optional<EdgeUsageDataEventHub> eventHubDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataCollectionFrequency"u8))
                {
                    dataCollectionFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataReportingFrequency"u8))
                {
                    dataReportingFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxAllowedUnreportedUsageDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAllowedUnreportedUsageDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("eventHubDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventHubDetails = EdgeUsageDataEventHub.DeserializeEdgeUsageDataEventHub(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeUsageDataCollectionPolicy(dataCollectionFrequency.Value, dataReportingFrequency.Value, Optional.ToNullable(maxAllowedUnreportedUsageDuration), eventHubDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeUsageDataCollectionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataCollectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeUsageDataCollectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        EdgeUsageDataCollectionPolicy IPersistableModel<EdgeUsageDataCollectionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeUsageDataCollectionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeUsageDataCollectionPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeUsageDataCollectionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeUsageDataCollectionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
