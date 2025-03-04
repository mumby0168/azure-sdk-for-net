// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A Class representing an EventHub along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="EventHubResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetEventHubResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventHubsNamespaceResource"/> using the GetEventHub method.
    /// </summary>
    public partial class EventHubResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EventHubResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="namespaceName"> The namespaceName. </param>
        /// <param name="eventHubName"> The eventHubName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string eventHubName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _eventHubClientDiagnostics;
        private readonly EventHubsRestOperations _eventHubRestClient;
        private readonly EventHubData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventHub/namespaces/eventhubs";

        /// <summary> Initializes a new instance of the <see cref="EventHubResource"/> class for mocking. </summary>
        protected EventHubResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EventHubResource(ArmClient client, EventHubData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EventHubResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string eventHubApiVersion);
            _eventHubRestClient = new EventHubsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventHubData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of EventHubAuthorizationRuleResources in the EventHub. </summary>
        /// <returns> An object representing collection of EventHubAuthorizationRuleResources and their operations over a EventHubAuthorizationRuleResource. </returns>
        public virtual EventHubAuthorizationRuleCollection GetEventHubAuthorizationRules()
        {
            return GetCachedClient(client => new EventHubAuthorizationRuleCollection(client, Id));
        }

        /// <summary>
        /// Gets an AuthorizationRule for an Event Hub by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EventHubAuthorizationRuleResource>> GetEventHubAuthorizationRuleAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            return await GetEventHubAuthorizationRules().GetAsync(authorizationRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an AuthorizationRule for an Event Hub by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_GetAuthorizationRule</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubAuthorizationRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<EventHubAuthorizationRuleResource> GetEventHubAuthorizationRule(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            return GetEventHubAuthorizationRules().Get(authorizationRuleName, cancellationToken);
        }

        /// <summary> Gets a collection of EventHubsConsumerGroupResources in the EventHub. </summary>
        /// <returns> An object representing collection of EventHubsConsumerGroupResources and their operations over a EventHubsConsumerGroupResource. </returns>
        public virtual EventHubsConsumerGroupCollection GetEventHubsConsumerGroups()
        {
            return GetCachedClient(client => new EventHubsConsumerGroupCollection(client, Id));
        }

        /// <summary>
        /// Gets a description for the specified consumer group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsConsumerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<EventHubsConsumerGroupResource>> GetEventHubsConsumerGroupAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            return await GetEventHubsConsumerGroups().GetAsync(consumerGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a description for the specified consumer group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}/consumergroups/{consumerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsConsumerGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<EventHubsConsumerGroupResource> GetEventHubsConsumerGroup(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            return GetEventHubsConsumerGroups().Get(consumerGroupName, cancellationToken);
        }

        /// <summary>
        /// Gets an Event Hubs description for the specified Event Hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EventHubResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubResource.Get");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Event Hubs description for the specified Event Hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EventHubResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubResource.Get");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Event Hub from the specified Namespace and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubResource.Delete");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Event Hub from the specified Namespace and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubResource.Delete");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventHubsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a new Event Hub as a nested resource within a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubResource>> UpdateAsync(WaitUntil waitUntil, EventHubData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubResource.Update");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubResource>(Response.FromValue(new EventHubResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a new Event Hub as a nested resource within a Namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EventHubs_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubResource> Update(WaitUntil waitUntil, EventHubData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubResource.Update");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubResource>(Response.FromValue(new EventHubResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
