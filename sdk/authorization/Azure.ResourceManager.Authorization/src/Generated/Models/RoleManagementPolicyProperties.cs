// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Expanded info of resource scope. </summary>
    public partial class RoleManagementPolicyProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyProperties"/>. </summary>
        internal RoleManagementPolicyProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyProperties"/>. </summary>
        /// <param name="scopeId"> Scope id of the resource. </param>
        /// <param name="scopeDisplayName"> Display name of the resource. </param>
        /// <param name="scopeType"> Type of the scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleManagementPolicyProperties(ResourceIdentifier scopeId, string scopeDisplayName, RoleManagementScopeType? scopeType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScopeId = scopeId;
            ScopeDisplayName = scopeDisplayName;
            ScopeType = scopeType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Scope id of the resource. </summary>
        public ResourceIdentifier ScopeId { get; }
        /// <summary> Display name of the resource. </summary>
        public string ScopeDisplayName { get; }
        /// <summary> Type of the scope. </summary>
        public RoleManagementScopeType? ScopeType { get; }
    }
}
