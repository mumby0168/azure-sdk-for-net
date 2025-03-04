// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RestoreFilesTargetDetails : IUtf8JsonSerializable, IJsonModel<RestoreFilesTargetDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreFilesTargetDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestoreFilesTargetDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreFilesTargetDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("filePrefix"u8);
            writer.WriteStringValue(FilePrefix);
            writer.WritePropertyName("restoreTargetLocationType"u8);
            writer.WriteStringValue(RestoreTargetLocationType.ToString());
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(TargetResourceArmId))
            {
                writer.WritePropertyName("targetResourceArmId"u8);
                writer.WriteStringValue(TargetResourceArmId);
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

        RestoreFilesTargetDetails IJsonModel<RestoreFilesTargetDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreFilesTargetDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreFilesTargetDetails(document.RootElement, options);
        }

        internal static RestoreFilesTargetDetails DeserializeRestoreFilesTargetDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filePrefix = default;
            RestoreTargetLocationType restoreTargetLocationType = default;
            Uri url = default;
            Optional<ResourceIdentifier> targetResourceArmId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePrefix"u8))
                {
                    filePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTargetLocationType"u8))
                {
                    restoreTargetLocationType = new RestoreTargetLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestoreFilesTargetDetails(filePrefix, restoreTargetLocationType, url, targetResourceArmId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestoreFilesTargetDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestoreFilesTargetDetails)} does not support '{options.Format}' format.");
            }
        }

        RestoreFilesTargetDetails IPersistableModel<RestoreFilesTargetDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreFilesTargetDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestoreFilesTargetDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreFilesTargetDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreFilesTargetDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
