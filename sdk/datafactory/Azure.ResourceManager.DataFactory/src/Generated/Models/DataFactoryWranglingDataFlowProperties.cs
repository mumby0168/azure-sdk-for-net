// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Power Query data flow. </summary>
    public partial class DataFactoryWranglingDataFlowProperties : DataFactoryDataFlowProperties
    {
        /// <summary> Initializes a new instance of <see cref="DataFactoryWranglingDataFlowProperties"/>. </summary>
        public DataFactoryWranglingDataFlowProperties()
        {
            Sources = new ChangeTrackingList<PowerQuerySource>();
            DataFlowType = "WranglingDataFlow";
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryWranglingDataFlowProperties"/>. </summary>
        /// <param name="dataFlowType"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sources"> List of sources in Power Query. </param>
        /// <param name="script"> Power query mashup script. </param>
        /// <param name="documentLocale"> Locale of the Power query mashup document. </param>
        internal DataFactoryWranglingDataFlowProperties(string dataFlowType, string description, IList<BinaryData> annotations, DataFlowFolder folder, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<PowerQuerySource> sources, string script, string documentLocale) : base(dataFlowType, description, annotations, folder, serializedAdditionalRawData)
        {
            Sources = sources;
            Script = script;
            DocumentLocale = documentLocale;
            DataFlowType = dataFlowType ?? "WranglingDataFlow";
        }

        /// <summary> List of sources in Power Query. </summary>
        public IList<PowerQuerySource> Sources { get; }
        /// <summary> Power query mashup script. </summary>
        public string Script { get; set; }
        /// <summary> Locale of the Power query mashup document. </summary>
        public string DocumentLocale { get; set; }
    }
}
