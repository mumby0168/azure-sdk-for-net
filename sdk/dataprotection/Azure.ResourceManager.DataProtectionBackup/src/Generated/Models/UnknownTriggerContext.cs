// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownTriggerContext. </summary>
    internal partial class UnknownTriggerContext : DataProtectionBackupTriggerContext
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTriggerContext"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTriggerContext(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(objectType, serializedAdditionalRawData)
        {
            ObjectType = objectType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTriggerContext"/> for deserialization. </summary>
        internal UnknownTriggerContext()
        {
        }
    }
}
