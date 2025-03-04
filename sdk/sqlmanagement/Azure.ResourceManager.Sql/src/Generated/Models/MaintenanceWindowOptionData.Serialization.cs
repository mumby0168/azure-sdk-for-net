// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class MaintenanceWindowOptionData : IUtf8JsonSerializable, IJsonModel<MaintenanceWindowOptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceWindowOptionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaintenanceWindowOptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceWindowOptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceWindowOptionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(MaintenanceWindowCycles))
            {
                writer.WritePropertyName("maintenanceWindowCycles"u8);
                writer.WriteStartArray();
                foreach (var item in MaintenanceWindowCycles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinDurationInMinutes))
            {
                writer.WritePropertyName("minDurationInMinutes"u8);
                writer.WriteNumberValue(MinDurationInMinutes.Value);
            }
            if (Optional.IsDefined(DefaultDurationInMinutes))
            {
                writer.WritePropertyName("defaultDurationInMinutes"u8);
                writer.WriteNumberValue(DefaultDurationInMinutes.Value);
            }
            if (Optional.IsDefined(MinCycles))
            {
                writer.WritePropertyName("minCycles"u8);
                writer.WriteNumberValue(MinCycles.Value);
            }
            if (Optional.IsDefined(TimeGranularityInMinutes))
            {
                writer.WritePropertyName("timeGranularityInMinutes"u8);
                writer.WriteNumberValue(TimeGranularityInMinutes.Value);
            }
            if (Optional.IsDefined(AllowMultipleMaintenanceWindowsPerCycle))
            {
                writer.WritePropertyName("allowMultipleMaintenanceWindowsPerCycle"u8);
                writer.WriteBooleanValue(AllowMultipleMaintenanceWindowsPerCycle.Value);
            }
            writer.WriteEndObject();
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

        MaintenanceWindowOptionData IJsonModel<MaintenanceWindowOptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceWindowOptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceWindowOptionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceWindowOptionData(document.RootElement, options);
        }

        internal static MaintenanceWindowOptionData DeserializeMaintenanceWindowOptionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isEnabled = default;
            Optional<IList<MaintenanceWindowTimeRange>> maintenanceWindowCycles = default;
            Optional<int> minDurationInMinutes = default;
            Optional<int> defaultDurationInMinutes = default;
            Optional<int> minCycles = default;
            Optional<int> timeGranularityInMinutes = default;
            Optional<bool> allowMultipleMaintenanceWindowsPerCycle = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindowCycles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MaintenanceWindowTimeRange> array = new List<MaintenanceWindowTimeRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MaintenanceWindowTimeRange.DeserializeMaintenanceWindowTimeRange(item));
                            }
                            maintenanceWindowCycles = array;
                            continue;
                        }
                        if (property0.NameEquals("minDurationInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minDurationInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("defaultDurationInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultDurationInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minCycles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minCycles = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("timeGranularityInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeGranularityInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("allowMultipleMaintenanceWindowsPerCycle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowMultipleMaintenanceWindowsPerCycle = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaintenanceWindowOptionData(id, name, type, systemData.Value, Optional.ToNullable(isEnabled), Optional.ToList(maintenanceWindowCycles), Optional.ToNullable(minDurationInMinutes), Optional.ToNullable(defaultDurationInMinutes), Optional.ToNullable(minCycles), Optional.ToNullable(timeGranularityInMinutes), Optional.ToNullable(allowMultipleMaintenanceWindowsPerCycle), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaintenanceWindowOptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceWindowOptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaintenanceWindowOptionData)} does not support '{options.Format}' format.");
            }
        }

        MaintenanceWindowOptionData IPersistableModel<MaintenanceWindowOptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceWindowOptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaintenanceWindowOptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaintenanceWindowOptionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaintenanceWindowOptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
