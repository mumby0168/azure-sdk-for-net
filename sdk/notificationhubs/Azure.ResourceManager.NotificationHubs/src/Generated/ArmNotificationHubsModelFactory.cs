// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NotificationHubs;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmNotificationHubsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubAvailabilityContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <param name="isAvailiable"> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </param>
        /// <returns> A new <see cref="Models.NotificationHubAvailabilityContent"/> instance for mocking. </returns>
        public static NotificationHubAvailabilityContent NotificationHubAvailabilityContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NotificationHubSku sku = null, bool? isAvailiable = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubAvailabilityContent(id, name, resourceType, systemData, tags, location, sku, isAvailiable, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubAvailabilityResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="isAvailiable"> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubAvailabilityResult"/> instance for mocking. </returns>
        public static NotificationHubAvailabilityResult NotificationHubAvailabilityResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, bool? isAvailiable = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubAvailabilityResult(id, name, resourceType, systemData, tags, location, isAvailiable, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubNamespaceCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namespaceName"> The name of the namespace. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="region"> Specifies the targeted region in which the namespace should be created. It can be any of the following values: Australia East, Australia Southeast, Central US, East US, East US 2, West US, North Central US, South Central US, East Asia, Southeast Asia, Brazil South, Japan East, Japan West, North Europe, West Europe. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="status"> Status of the namespace. It can be any of these values:1 = Created/Active2 = Creating3 = Suspended4 = Deleting. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform NotificationHub operations. </param>
        /// <param name="subscriptionId"> The Id of the Azure subscription associated with the namespace. </param>
        /// <param name="scaleUnit"> ScaleUnit where the namespace gets created. </param>
        /// <param name="isEnabled"> Whether or not the namespace is currently enabled. </param>
        /// <param name="isCritical"> Whether or not the namespace is set as Critical. </param>
        /// <param name="dataCenter"> Data center for the namespace. </param>
        /// <param name="namespaceType"> The namespace type. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubNamespaceCreateOrUpdateContent"/> instance for mocking. </returns>
        public static NotificationHubNamespaceCreateOrUpdateContent NotificationHubNamespaceCreateOrUpdateContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string namespaceName = null, string provisioningState = null, string region = null, string metricId = null, string status = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, Uri serviceBusEndpoint = null, string subscriptionId = null, string scaleUnit = null, bool? isEnabled = null, bool? isCritical = null, string dataCenter = null, NotificationHubNamespaceType? namespaceType = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubNamespaceCreateOrUpdateContent(id, name, resourceType, systemData, tags, location, namespaceName, provisioningState, region, metricId, status, createdOn, updatedOn, serviceBusEndpoint, subscriptionId, scaleUnit, isEnabled, isCritical, dataCenter, namespaceType, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubNamespaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namespaceName"> The name of the namespace. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="region"> Specifies the targeted region in which the namespace should be created. It can be any of the following values: Australia East, Australia Southeast, Central US, East US, East US 2, West US, North Central US, South Central US, East Asia, Southeast Asia, Brazil South, Japan East, Japan West, North Europe, West Europe. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="status"> Status of the namespace. It can be any of these values:1 = Created/Active2 = Creating3 = Suspended4 = Deleting. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform NotificationHub operations. </param>
        /// <param name="subscriptionId"> The Id of the Azure subscription associated with the namespace. </param>
        /// <param name="scaleUnit"> ScaleUnit where the namespace gets created. </param>
        /// <param name="isEnabled"> Whether or not the namespace is currently enabled. </param>
        /// <param name="isCritical"> Whether or not the namespace is set as Critical. </param>
        /// <param name="dataCenter"> Data center for the namespace. </param>
        /// <param name="namespaceType"> The namespace type. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubNamespaceData"/> instance for mocking. </returns>
        public static NotificationHubNamespaceData NotificationHubNamespaceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string namespaceName = null, string provisioningState = null, string region = null, string metricId = null, string status = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, Uri serviceBusEndpoint = null, string subscriptionId = null, string scaleUnit = null, bool? isEnabled = null, bool? isCritical = null, string dataCenter = null, NotificationHubNamespaceType? namespaceType = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubNamespaceData(id, name, resourceType, systemData, tags, location, namespaceName, provisioningState, region, metricId, status, createdOn, updatedOn, serviceBusEndpoint, subscriptionId, scaleUnit, isEnabled, isCritical, dataCenter, namespaceType, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SharedAccessAuthorizationRuleProperties"/>. </summary>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the authorization rule. </param>
        /// <param name="claimType"> A string that describes the claim type. </param>
        /// <param name="claimValue"> A string that describes the claim value. </param>
        /// <param name="modifiedOn"> The last modified time for this rule. </param>
        /// <param name="createdOn"> The created time for this rule. </param>
        /// <param name="revision"> The revision number for the rule. </param>
        /// <returns> A new <see cref="Models.SharedAccessAuthorizationRuleProperties"/> instance for mocking. </returns>
        public static SharedAccessAuthorizationRuleProperties SharedAccessAuthorizationRuleProperties(IEnumerable<AuthorizationRuleAccessRight> rights = null, string primaryKey = null, string secondaryKey = null, string keyName = null, string claimType = null, string claimValue = null, DateTimeOffset? modifiedOn = null, DateTimeOffset? createdOn = null, int? revision = null)
        {
            rights ??= new List<AuthorizationRuleAccessRight>();

            return new SharedAccessAuthorizationRuleProperties(rights?.ToList(), primaryKey, secondaryKey, keyName, claimType, claimValue, modifiedOn, createdOn, revision, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubAuthorizationRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the authorization rule. </param>
        /// <param name="claimType"> A string that describes the claim type. </param>
        /// <param name="claimValue"> A string that describes the claim value. </param>
        /// <param name="modifiedOn"> The last modified time for this rule. </param>
        /// <param name="createdOn"> The created time for this rule. </param>
        /// <param name="revision"> The revision number for the rule. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubAuthorizationRuleData"/> instance for mocking. </returns>
        public static NotificationHubAuthorizationRuleData NotificationHubAuthorizationRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<AuthorizationRuleAccessRight> rights = null, string primaryKey = null, string secondaryKey = null, string keyName = null, string claimType = null, string claimValue = null, DateTimeOffset? modifiedOn = null, DateTimeOffset? createdOn = null, int? revision = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();
            rights ??= new List<AuthorizationRuleAccessRight>();

            return new NotificationHubAuthorizationRuleData(id, name, resourceType, systemData, tags, location, rights?.ToList(), primaryKey, secondaryKey, keyName, claimType, claimValue, modifiedOn, createdOn, revision, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubResourceKeys"/>. </summary>
        /// <param name="primaryConnectionString"> PrimaryConnectionString of the AuthorizationRule. </param>
        /// <param name="secondaryConnectionString"> SecondaryConnectionString of the created AuthorizationRule. </param>
        /// <param name="primaryKey"> PrimaryKey of the created AuthorizationRule. </param>
        /// <param name="secondaryKey"> SecondaryKey of the created AuthorizationRule. </param>
        /// <param name="keyName"> KeyName of the created AuthorizationRule. </param>
        /// <returns> A new <see cref="Models.NotificationHubResourceKeys"/> instance for mocking. </returns>
        public static NotificationHubResourceKeys NotificationHubResourceKeys(string primaryConnectionString = null, string secondaryConnectionString = null, string primaryKey = null, string secondaryKey = null, string keyName = null)
        {
            return new NotificationHubResourceKeys(primaryConnectionString, secondaryConnectionString, primaryKey, secondaryKey, keyName, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="notificationHubName"> The NotificationHub name. </param>
        /// <param name="registrationTtl"> The RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> The AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubCreateOrUpdateContent"/> instance for mocking. </returns>
        public static NotificationHubCreateOrUpdateContent NotificationHubCreateOrUpdateContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string notificationHubName = null, TimeSpan? registrationTtl = null, IEnumerable<SharedAccessAuthorizationRuleProperties> authorizationRules = null, NotificationHubApnsCredential apnsCredential = null, NotificationHubWnsCredential wnsCredential = null, NotificationHubGcmCredential gcmCredential = null, NotificationHubMpnsCredential mpnsCredential = null, NotificationHubAdmCredential admCredential = null, NotificationHubBaiduCredential baiduCredential = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();
            authorizationRules ??= new List<SharedAccessAuthorizationRuleProperties>();

            return new NotificationHubCreateOrUpdateContent(id, name, resourceType, systemData, tags, location, notificationHubName, registrationTtl, authorizationRules?.ToList(), apnsCredential, wnsCredential, gcmCredential, mpnsCredential, admCredential, baiduCredential, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubs.NotificationHubData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="notificationHubName"> The NotificationHub name. </param>
        /// <param name="registrationTtl"> The RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> The AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="NotificationHubs.NotificationHubData"/> instance for mocking. </returns>
        public static NotificationHubData NotificationHubData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string notificationHubName = null, TimeSpan? registrationTtl = null, IEnumerable<SharedAccessAuthorizationRuleProperties> authorizationRules = null, NotificationHubApnsCredential apnsCredential = null, NotificationHubWnsCredential wnsCredential = null, NotificationHubGcmCredential gcmCredential = null, NotificationHubMpnsCredential mpnsCredential = null, NotificationHubAdmCredential admCredential = null, NotificationHubBaiduCredential baiduCredential = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();
            authorizationRules ??= new List<SharedAccessAuthorizationRuleProperties>();

            return new NotificationHubData(id, name, resourceType, systemData, tags, location, notificationHubName, registrationTtl, authorizationRules?.ToList(), apnsCredential, wnsCredential, gcmCredential, mpnsCredential, admCredential, baiduCredential, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="notificationHubName"> The NotificationHub name. </param>
        /// <param name="registrationTtl"> The RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> The AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubPatch"/> instance for mocking. </returns>
        public static NotificationHubPatch NotificationHubPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string notificationHubName = null, TimeSpan? registrationTtl = null, IEnumerable<SharedAccessAuthorizationRuleProperties> authorizationRules = null, NotificationHubApnsCredential apnsCredential = null, NotificationHubWnsCredential wnsCredential = null, NotificationHubGcmCredential gcmCredential = null, NotificationHubMpnsCredential mpnsCredential = null, NotificationHubAdmCredential admCredential = null, NotificationHubBaiduCredential baiduCredential = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();
            authorizationRules ??= new List<SharedAccessAuthorizationRuleProperties>();

            return new NotificationHubPatch(id, name, resourceType, systemData, tags, location, notificationHubName, registrationTtl, authorizationRules?.ToList(), apnsCredential, wnsCredential, gcmCredential, mpnsCredential, admCredential, baiduCredential, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubTestSendResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="success"> successful send. </param>
        /// <param name="failure"> send failure. </param>
        /// <param name="results"> actual failure description. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubTestSendResult"/> instance for mocking. </returns>
        public static NotificationHubTestSendResult NotificationHubTestSendResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? success = null, int? failure = null, BinaryData results = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubTestSendResult(id, name, resourceType, systemData, tags, location, success, failure, results, sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NotificationHubPnsCredentials"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <returns> A new <see cref="Models.NotificationHubPnsCredentials"/> instance for mocking. </returns>
        public static NotificationHubPnsCredentials NotificationHubPnsCredentials(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, NotificationHubApnsCredential apnsCredential = null, NotificationHubWnsCredential wnsCredential = null, NotificationHubGcmCredential gcmCredential = null, NotificationHubMpnsCredential mpnsCredential = null, NotificationHubAdmCredential admCredential = null, NotificationHubBaiduCredential baiduCredential = null, NotificationHubSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new NotificationHubPnsCredentials(id, name, resourceType, systemData, tags, location, apnsCredential, wnsCredential, gcmCredential, mpnsCredential, admCredential, baiduCredential, sku, serializedAdditionalRawData: null);
        }
    }
}
