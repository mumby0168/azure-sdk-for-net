// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ClassificationModelPerformanceMetricThreshold : IUtf8JsonSerializable, IJsonModel<ClassificationModelPerformanceMetricThreshold>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClassificationModelPerformanceMetricThreshold>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClassificationModelPerformanceMetricThreshold>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationModelPerformanceMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationModelPerformanceMetricThreshold)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metric"u8);
            writer.WriteStringValue(Metric.ToString());
            writer.WritePropertyName("modelType"u8);
            writer.WriteStringValue(ModelType.ToString());
            if (Optional.IsDefined(Threshold))
            {
                if (Threshold != null)
                {
                    writer.WritePropertyName("threshold"u8);
                    writer.WriteObjectValue(Threshold);
                }
                else
                {
                    writer.WriteNull("threshold");
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

        ClassificationModelPerformanceMetricThreshold IJsonModel<ClassificationModelPerformanceMetricThreshold>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationModelPerformanceMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassificationModelPerformanceMetricThreshold)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClassificationModelPerformanceMetricThreshold(document.RootElement, options);
        }

        internal static ClassificationModelPerformanceMetricThreshold DeserializeClassificationModelPerformanceMetricThreshold(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClassificationModelPerformanceMetric metric = default;
            MonitoringModelType modelType = default;
            Optional<MonitoringThreshold> threshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = new ClassificationModelPerformanceMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelType"u8))
                {
                    modelType = new MonitoringModelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        threshold = null;
                        continue;
                    }
                    threshold = MonitoringThreshold.DeserializeMonitoringThreshold(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClassificationModelPerformanceMetricThreshold(modelType, threshold.Value, serializedAdditionalRawData, metric);
        }

        BinaryData IPersistableModel<ClassificationModelPerformanceMetricThreshold>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationModelPerformanceMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClassificationModelPerformanceMetricThreshold)} does not support '{options.Format}' format.");
            }
        }

        ClassificationModelPerformanceMetricThreshold IPersistableModel<ClassificationModelPerformanceMetricThreshold>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassificationModelPerformanceMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClassificationModelPerformanceMetricThreshold(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClassificationModelPerformanceMetricThreshold)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClassificationModelPerformanceMetricThreshold>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
