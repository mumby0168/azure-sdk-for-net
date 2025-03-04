// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class GitHubAccessTokenContent : IUtf8JsonSerializable, IJsonModel<GitHubAccessTokenContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubAccessTokenContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GitHubAccessTokenContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubAccessTokenContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("gitHubAccessCode"u8);
            writer.WriteStringValue(GitHubAccessCode);
            if (Optional.IsDefined(GitHubClientId))
            {
                writer.WritePropertyName("gitHubClientId"u8);
                writer.WriteStringValue(GitHubClientId);
            }
            if (Optional.IsDefined(GitHubClientSecret))
            {
                writer.WritePropertyName("gitHubClientSecret"u8);
                writer.WriteObjectValue(GitHubClientSecret);
            }
            writer.WritePropertyName("gitHubAccessTokenBaseUrl"u8);
            writer.WriteStringValue(GitHubAccessTokenBaseUri.AbsoluteUri);
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

        GitHubAccessTokenContent IJsonModel<GitHubAccessTokenContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubAccessTokenContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubAccessTokenContent(document.RootElement, options);
        }

        internal static GitHubAccessTokenContent DeserializeGitHubAccessTokenContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string gitHubAccessCode = default;
            Optional<string> gitHubClientId = default;
            Optional<FactoryGitHubClientSecret> gitHubClientSecret = default;
            Uri gitHubAccessTokenBaseUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitHubAccessCode"u8))
                {
                    gitHubAccessCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gitHubClientId"u8))
                {
                    gitHubClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gitHubClientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubClientSecret = FactoryGitHubClientSecret.DeserializeFactoryGitHubClientSecret(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHubAccessTokenBaseUrl"u8))
                {
                    gitHubAccessTokenBaseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubAccessTokenContent(gitHubAccessCode, gitHubClientId.Value, gitHubClientSecret.Value, gitHubAccessTokenBaseUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GitHubAccessTokenContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GitHubAccessTokenContent)} does not support '{options.Format}' format.");
            }
        }

        GitHubAccessTokenContent IPersistableModel<GitHubAccessTokenContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubAccessTokenContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGitHubAccessTokenContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GitHubAccessTokenContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GitHubAccessTokenContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
