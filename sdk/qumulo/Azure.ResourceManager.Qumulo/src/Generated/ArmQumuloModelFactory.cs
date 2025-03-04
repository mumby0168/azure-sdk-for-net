// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Qumulo;

namespace Azure.ResourceManager.Qumulo.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmQumuloModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Qumulo.QumuloFileSystemResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="marketplaceDetails"> Marketplace details. </param>
        /// <param name="provisioningState"> Provisioning State of the resource. </param>
        /// <param name="storageSku"> Storage Sku. </param>
        /// <param name="userDetailsEmail"> User Details. </param>
        /// <param name="delegatedSubnetId"> Delegated subnet id for Vnet injection. </param>
        /// <param name="clusterLoginUri"> File system Id of the resource. </param>
        /// <param name="privateIPs"> Private IPs of the resource. </param>
        /// <param name="adminPassword"> Initial administrator password of the resource. </param>
        /// <param name="initialCapacity"> Storage capacity in TB. </param>
        /// <param name="availabilityZone"> Availability zone. </param>
        /// <returns> A new <see cref="Qumulo.QumuloFileSystemResourceData"/> instance for mocking. </returns>
        public static QumuloFileSystemResourceData QumuloFileSystemResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, MarketplaceDetails marketplaceDetails = null, QumuloProvisioningState? provisioningState = null, StorageSku storageSku = default, string userDetailsEmail = null, string delegatedSubnetId = null, Uri clusterLoginUri = null, IEnumerable<IPAddress> privateIPs = null, string adminPassword = null, int initialCapacity = default, string availabilityZone = null)
        {
            tags ??= new Dictionary<string, string>();
            privateIPs ??= new List<IPAddress>();

            return new QumuloFileSystemResourceData(id, name, resourceType, systemData, tags, location, identity, marketplaceDetails, provisioningState, storageSku, userDetailsEmail != null ? new QumuloUserDetails(userDetailsEmail, serializedAdditionalRawData: null) : null, delegatedSubnetId, clusterLoginUri, privateIPs?.ToList(), adminPassword, initialCapacity, availabilityZone, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MarketplaceDetails"/>. </summary>
        /// <param name="marketplaceSubscriptionId"> Marketplace Subscription Id. </param>
        /// <param name="planId"> Plan Id. </param>
        /// <param name="offerId"> Offer Id. </param>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="marketplaceSubscriptionStatus"> Marketplace subscription status. </param>
        /// <returns> A new <see cref="Models.MarketplaceDetails"/> instance for mocking. </returns>
        public static MarketplaceDetails MarketplaceDetails(string marketplaceSubscriptionId = null, string planId = null, string offerId = null, string publisherId = null, MarketplaceSubscriptionStatus? marketplaceSubscriptionStatus = null)
        {
            return new MarketplaceDetails(marketplaceSubscriptionId, planId, offerId, publisherId, marketplaceSubscriptionStatus, serializedAdditionalRawData: null);
        }
    }
}
