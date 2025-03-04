// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformGatewayOperatorResourceRequirements : IUtf8JsonSerializable, IJsonModel<AppPlatformGatewayOperatorResourceRequirements>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformGatewayOperatorResourceRequirements>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformGatewayOperatorResourceRequirements>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayOperatorResourceRequirements)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu"u8);
                writer.WriteStringValue(Cpu);
            }
            if (options.Format != "W" && Optional.IsDefined(Memory))
            {
                writer.WritePropertyName("memory"u8);
                writer.WriteStringValue(Memory);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
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

        AppPlatformGatewayOperatorResourceRequirements IJsonModel<AppPlatformGatewayOperatorResourceRequirements>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformGatewayOperatorResourceRequirements)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformGatewayOperatorResourceRequirements(document.RootElement, options);
        }

        internal static AppPlatformGatewayOperatorResourceRequirements DeserializeAppPlatformGatewayOperatorResourceRequirements(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cpu = default;
            Optional<string> memory = default;
            Optional<int> instanceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformGatewayOperatorResourceRequirements(cpu.Value, memory.Value, Optional.ToNullable(instanceCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayOperatorResourceRequirements)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformGatewayOperatorResourceRequirements IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformGatewayOperatorResourceRequirements(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformGatewayOperatorResourceRequirements)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformGatewayOperatorResourceRequirements>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
