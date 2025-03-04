// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Test failover workflow model custom properties. </summary>
    public partial class TestFailoverWorkflowModelCustomProperties : WorkflowModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="TestFailoverWorkflowModelCustomProperties"/>. </summary>
        internal TestFailoverWorkflowModelCustomProperties()
        {
            ProtectedItemDetails = new ChangeTrackingList<FailoverProtectedItemProperties>();
            InstanceType = "TestFailoverWorkflowDetails";
        }

        /// <summary> Initializes a new instance of <see cref="TestFailoverWorkflowModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="affectedObjectDetails"> Gets or sets any custom properties of the affected object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="protectedItemDetails"> Gets or sets the test VM details. </param>
        internal TestFailoverWorkflowModelCustomProperties(string instanceType, IReadOnlyDictionary<string, string> affectedObjectDetails, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<FailoverProtectedItemProperties> protectedItemDetails) : base(instanceType, affectedObjectDetails, serializedAdditionalRawData)
        {
            ProtectedItemDetails = protectedItemDetails;
            InstanceType = instanceType ?? "TestFailoverWorkflowDetails";
        }

        /// <summary> Gets or sets the test VM details. </summary>
        public IReadOnlyList<FailoverProtectedItemProperties> ProtectedItemDetails { get; }
    }
}
