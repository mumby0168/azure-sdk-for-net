// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class Representing Solution for problems detected. </summary>
    public partial class DiagnosticSolution
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

        /// <summary> Initializes a new instance of <see cref="DiagnosticSolution"/>. </summary>
        public DiagnosticSolution()
        {
            Data = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
            Metadata = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticSolution"/>. </summary>
        /// <param name="id"> Solution Id. </param>
        /// <param name="displayName"> Display Name of the solution. </param>
        /// <param name="order"> Order of the solution. </param>
        /// <param name="description"> Description of the solution. </param>
        /// <param name="solutionType"> Type of Solution. </param>
        /// <param name="data"> Solution Data. </param>
        /// <param name="metadata"> Solution Metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticSolution(double? id, string displayName, double? order, string description, DiagnosticSolutionType? solutionType, IList<IList<AppServiceNameValuePair>> data, IList<IList<AppServiceNameValuePair>> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            DisplayName = displayName;
            Order = order;
            Description = description;
            SolutionType = solutionType;
            Data = data;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Solution Id. </summary>
        public double? Id { get; set; }
        /// <summary> Display Name of the solution. </summary>
        public string DisplayName { get; set; }
        /// <summary> Order of the solution. </summary>
        public double? Order { get; set; }
        /// <summary> Description of the solution. </summary>
        public string Description { get; set; }
        /// <summary> Type of Solution. </summary>
        public DiagnosticSolutionType? SolutionType { get; set; }
        /// <summary> Solution Data. </summary>
        public IList<IList<AppServiceNameValuePair>> Data { get; }
        /// <summary> Solution Metadata. </summary>
        public IList<IList<AppServiceNameValuePair>> Metadata { get; }
    }
}
