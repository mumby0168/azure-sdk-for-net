// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FileShareRestoreContent : IUtf8JsonSerializable, IJsonModel<FileShareRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileShareRestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FileShareRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileShareRestoreContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryType))
            {
                writer.WritePropertyName("recoveryType"u8);
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(CopyOptions))
            {
                writer.WritePropertyName("copyOptions"u8);
                writer.WriteStringValue(CopyOptions.Value.ToString());
            }
            if (Optional.IsDefined(RestoreRequestType))
            {
                writer.WritePropertyName("restoreRequestType"u8);
                writer.WriteStringValue(RestoreRequestType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RestoreFileSpecs))
            {
                writer.WritePropertyName("restoreFileSpecs"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreFileSpecs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetDetails))
            {
                writer.WritePropertyName("targetDetails"u8);
                writer.WriteObjectValue(TargetDetails);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        FileShareRestoreContent IJsonModel<FileShareRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileShareRestoreContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileShareRestoreContent(document.RootElement, options);
        }

        internal static FileShareRestoreContent DeserializeFileShareRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FileShareRecoveryType> recoveryType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<FileShareCopyOption> copyOptions = default;
            Optional<FileShareRestoreType> restoreRequestType = default;
            Optional<IList<RestoreFileSpecs>> restoreFileSpecs = default;
            Optional<TargetAfsRestoreInfo> targetDetails = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryType = new FileShareRecoveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("copyOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyOptions = new FileShareCopyOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreRequestType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreRequestType = new FileShareRestoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreFileSpecs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestoreFileSpecs> array = new List<RestoreFileSpecs>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.RestoreFileSpecs.DeserializeRestoreFileSpecs(item));
                    }
                    restoreFileSpecs = array;
                    continue;
                }
                if (property.NameEquals("targetDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDetails = TargetAfsRestoreInfo.DeserializeTargetAfsRestoreInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FileShareRestoreContent(objectType, serializedAdditionalRawData, Optional.ToNullable(recoveryType), sourceResourceId.Value, Optional.ToNullable(copyOptions), Optional.ToNullable(restoreRequestType), Optional.ToList(restoreFileSpecs), targetDetails.Value);
        }

        BinaryData IPersistableModel<FileShareRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileShareRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        FileShareRestoreContent IPersistableModel<FileShareRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileShareRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileShareRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileShareRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileShareRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
