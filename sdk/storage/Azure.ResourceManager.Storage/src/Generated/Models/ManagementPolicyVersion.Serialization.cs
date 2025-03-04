// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyVersion : IUtf8JsonSerializable, IJsonModel<ManagementPolicyVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementPolicyVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementPolicyVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TierToCool))
            {
                writer.WritePropertyName("tierToCool"u8);
                writer.WriteObjectValue(TierToCool);
            }
            if (Optional.IsDefined(TierToArchive))
            {
                writer.WritePropertyName("tierToArchive"u8);
                writer.WriteObjectValue(TierToArchive);
            }
            if (Optional.IsDefined(TierToCold))
            {
                writer.WritePropertyName("tierToCold"u8);
                writer.WriteObjectValue(TierToCold);
            }
            if (Optional.IsDefined(TierToHot))
            {
                writer.WritePropertyName("tierToHot"u8);
                writer.WriteObjectValue(TierToHot);
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete);
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

        ManagementPolicyVersion IJsonModel<ManagementPolicyVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementPolicyVersion(document.RootElement, options);
        }

        internal static ManagementPolicyVersion DeserializeManagementPolicyVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateAfterCreation> tierToCool = default;
            Optional<DateAfterCreation> tierToArchive = default;
            Optional<DateAfterCreation> tierToCold = default;
            Optional<DateAfterCreation> tierToHot = default;
            Optional<DateAfterCreation> delete = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tierToCool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCool = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToArchive = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToCold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToCold = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToHot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tierToHot = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementPolicyVersion(tierToCool.Value, tierToArchive.Value, tierToCold.Value, tierToHot.Value, delete.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementPolicyVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{options.Format}' format.");
            }
        }

        ManagementPolicyVersion IPersistableModel<ManagementPolicyVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementPolicyVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyVersion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementPolicyVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
