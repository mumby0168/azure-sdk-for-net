// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageDiskExclusionContent : IUtf8JsonSerializable, IJsonModel<InMageDiskExclusionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageDiskExclusionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageDiskExclusionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskExclusionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDiskExclusionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VolumeOptions))
            {
                writer.WritePropertyName("volumeOptions"u8);
                writer.WriteStartArray();
                foreach (var item in VolumeOptions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DiskSignatureOptions))
            {
                writer.WritePropertyName("diskSignatureOptions"u8);
                writer.WriteStartArray();
                foreach (var item in DiskSignatureOptions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        InMageDiskExclusionContent IJsonModel<InMageDiskExclusionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskExclusionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageDiskExclusionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageDiskExclusionContent(document.RootElement, options);
        }

        internal static InMageDiskExclusionContent DeserializeInMageDiskExclusionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<InMageVolumeExclusionOptions>> volumeOptions = default;
            Optional<IList<InMageDiskSignatureExclusionOptions>> diskSignatureOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageVolumeExclusionOptions> array = new List<InMageVolumeExclusionOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageVolumeExclusionOptions.DeserializeInMageVolumeExclusionOptions(item));
                    }
                    volumeOptions = array;
                    continue;
                }
                if (property.NameEquals("diskSignatureOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageDiskSignatureExclusionOptions> array = new List<InMageDiskSignatureExclusionOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageDiskSignatureExclusionOptions.DeserializeInMageDiskSignatureExclusionOptions(item));
                    }
                    diskSignatureOptions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageDiskExclusionContent(Optional.ToList(volumeOptions), Optional.ToList(diskSignatureOptions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageDiskExclusionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskExclusionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageDiskExclusionContent)} does not support '{options.Format}' format.");
            }
        }

        InMageDiskExclusionContent IPersistableModel<InMageDiskExclusionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageDiskExclusionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageDiskExclusionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageDiskExclusionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageDiskExclusionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
