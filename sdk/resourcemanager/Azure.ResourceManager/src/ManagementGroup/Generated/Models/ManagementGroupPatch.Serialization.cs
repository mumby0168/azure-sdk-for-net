// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupPatch : IUtf8JsonSerializable, IJsonModel<ManagementGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementGroupPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(ParentGroupId))
            {
                if (ParentGroupId != null)
                {
                    writer.WritePropertyName("parentGroupId"u8);
                    writer.WriteStringValue(ParentGroupId);
                }
                else
                {
                    writer.WriteNull("parentGroupId");
                }
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

        ManagementGroupPatch IJsonModel<ManagementGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupPatch(document.RootElement, options);
        }

        internal static ManagementGroupPatch DeserializeManagementGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> parentGroupId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parentGroupId = null;
                        continue;
                    }
                    parentGroupId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementGroupPatch(displayName.Value, parentGroupId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        ManagementGroupPatch IPersistableModel<ManagementGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
