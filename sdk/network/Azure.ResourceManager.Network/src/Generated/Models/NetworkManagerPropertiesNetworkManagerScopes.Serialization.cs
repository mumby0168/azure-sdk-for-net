// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkManagerPropertiesNetworkManagerScopes : IUtf8JsonSerializable, IJsonModel<NetworkManagerPropertiesNetworkManagerScopes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkManagerPropertiesNetworkManagerScopes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkManagerPropertiesNetworkManagerScopes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerPropertiesNetworkManagerScopes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ManagementGroups))
            {
                writer.WritePropertyName("managementGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ManagementGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CrossTenantScopes))
            {
                writer.WritePropertyName("crossTenantScopes"u8);
                writer.WriteStartArray();
                foreach (var item in CrossTenantScopes)
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

        NetworkManagerPropertiesNetworkManagerScopes IJsonModel<NetworkManagerPropertiesNetworkManagerScopes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerPropertiesNetworkManagerScopes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkManagerPropertiesNetworkManagerScopes(document.RootElement, options);
        }

        internal static NetworkManagerPropertiesNetworkManagerScopes DeserializeNetworkManagerPropertiesNetworkManagerScopes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> managementGroups = default;
            Optional<IList<string>> subscriptions = default;
            Optional<IReadOnlyList<CrossTenantScopes>> crossTenantScopes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managementGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managementGroups = array;
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("crossTenantScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CrossTenantScopes> array = new List<CrossTenantScopes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CrossTenantScopes.DeserializeCrossTenantScopes(item));
                    }
                    crossTenantScopes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkManagerPropertiesNetworkManagerScopes(Optional.ToList(managementGroups), Optional.ToList(subscriptions), Optional.ToList(crossTenantScopes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerPropertiesNetworkManagerScopes)} does not support '{options.Format}' format.");
            }
        }

        NetworkManagerPropertiesNetworkManagerScopes IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkManagerPropertiesNetworkManagerScopes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerPropertiesNetworkManagerScopes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkManagerPropertiesNetworkManagerScopes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
