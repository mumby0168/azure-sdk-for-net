// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigrateSqlServerSqlMITaskOutput))]
    public partial class MigrateSqlServerSqlMITaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlMITaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlMITaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlMITaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSqlServerSqlMITaskOutput IJsonModel<MigrateSqlServerSqlMITaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMITaskOutput(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlMITaskOutput DeserializeMigrateSqlServerSqlMITaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AgentJobLevelOutput": return MigrateSqlServerSqlMITaskOutputAgentJobLevel.DeserializeMigrateSqlServerSqlMITaskOutputAgentJobLevel(element);
                    case "DatabaseLevelOutput": return MigrateSqlServerSqlMITaskOutputDatabaseLevel.DeserializeMigrateSqlServerSqlMITaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateSqlServerSqlMITaskOutputError.DeserializeMigrateSqlServerSqlMITaskOutputError(element);
                    case "LoginLevelOutput": return MigrateSqlServerSqlMITaskOutputLoginLevel.DeserializeMigrateSqlServerSqlMITaskOutputLoginLevel(element);
                    case "MigrationLevelOutput": return MigrateSqlServerSqlMITaskOutputMigrationLevel.DeserializeMigrateSqlServerSqlMITaskOutputMigrationLevel(element);
                }
            }
            return UnknownMigrateSqlServerSqlMITaskOutput.DeserializeUnknownMigrateSqlServerSqlMITaskOutput(element);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlMITaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutput)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlMITaskOutput IPersistableModel<MigrateSqlServerSqlMITaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlMITaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlMITaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
