// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchDeploymentConfiguration : IUtf8JsonSerializable, IJsonModel<BatchDeploymentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchDeploymentConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchDeploymentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchDeploymentConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CloudServiceConfiguration))
            {
                writer.WritePropertyName("cloudServiceConfiguration"u8);
                writer.WriteObjectValue(CloudServiceConfiguration);
            }
            if (Optional.IsDefined(VmConfiguration))
            {
                writer.WritePropertyName("virtualMachineConfiguration"u8);
                writer.WriteObjectValue(VmConfiguration);
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

        BatchDeploymentConfiguration IJsonModel<BatchDeploymentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchDeploymentConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchDeploymentConfiguration(document.RootElement, options);
        }

        internal static BatchDeploymentConfiguration DeserializeBatchDeploymentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchCloudServiceConfiguration> cloudServiceConfiguration = default;
            Optional<BatchVmConfiguration> virtualMachineConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudServiceConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudServiceConfiguration = BatchCloudServiceConfiguration.DeserializeBatchCloudServiceConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineConfiguration = BatchVmConfiguration.DeserializeBatchVmConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchDeploymentConfiguration(cloudServiceConfiguration.Value, virtualMachineConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchDeploymentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchDeploymentConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchDeploymentConfiguration IPersistableModel<BatchDeploymentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchDeploymentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchDeploymentConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchDeploymentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
