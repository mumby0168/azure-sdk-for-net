// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class RunbookParameterDefinition : IUtf8JsonSerializable, IJsonModel<RunbookParameterDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunbookParameterDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RunbookParameterDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunbookParameterDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RunbookParameterType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RunbookParameterType);
            }
            if (Optional.IsDefined(IsMandatory))
            {
                writer.WritePropertyName("isMandatory"u8);
                writer.WriteBooleanValue(IsMandatory.Value);
            }
            if (Optional.IsDefined(Position))
            {
                writer.WritePropertyName("position"u8);
                writer.WriteNumberValue(Position.Value);
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
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

        RunbookParameterDefinition IJsonModel<RunbookParameterDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunbookParameterDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunbookParameterDefinition(document.RootElement, options);
        }

        internal static RunbookParameterDefinition DeserializeRunbookParameterDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<bool> isMandatory = default;
            Optional<int> position = default;
            Optional<string> defaultValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMandatory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunbookParameterDefinition(type.Value, Optional.ToNullable(isMandatory), Optional.ToNullable(position), defaultValue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunbookParameterDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunbookParameterDefinition)} does not support '{options.Format}' format.");
            }
        }

        RunbookParameterDefinition IPersistableModel<RunbookParameterDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunbookParameterDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunbookParameterDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunbookParameterDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
