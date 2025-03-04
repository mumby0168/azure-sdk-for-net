// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForDatabasesGcpOfferingArcAutoProvisioning : IUtf8JsonSerializable, IJsonModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDatabasesGcpOfferingArcAutoProvisioning)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
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

        DefenderForDatabasesGcpOfferingArcAutoProvisioning IJsonModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForDatabasesGcpOfferingArcAutoProvisioning)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForDatabasesGcpOfferingArcAutoProvisioning(document.RootElement, options);
        }

        internal static DefenderForDatabasesGcpOfferingArcAutoProvisioning DeserializeDefenderForDatabasesGcpOfferingArcAutoProvisioning(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<DefenderForDatabasesGcpOfferingArcAutoProvisioningConfiguration> configuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = DefenderForDatabasesGcpOfferingArcAutoProvisioningConfiguration.DeserializeDefenderForDatabasesGcpOfferingArcAutoProvisioningConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForDatabasesGcpOfferingArcAutoProvisioning(Optional.ToNullable(enabled), configuration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForDatabasesGcpOfferingArcAutoProvisioning)} does not support '{options.Format}' format.");
            }
        }

        DefenderForDatabasesGcpOfferingArcAutoProvisioning IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForDatabasesGcpOfferingArcAutoProvisioning(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForDatabasesGcpOfferingArcAutoProvisioning)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForDatabasesGcpOfferingArcAutoProvisioning>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
