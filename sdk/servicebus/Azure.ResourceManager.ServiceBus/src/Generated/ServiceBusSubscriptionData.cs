// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing the ServiceBusSubscription data model.
    /// Description of subscription resource.
    /// </summary>
    public partial class ServiceBusSubscriptionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ServiceBusSubscriptionData"/>. </summary>
        public ServiceBusSubscriptionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusSubscriptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="messageCount"> Number of messages. </param>
        /// <param name="createdOn"> Exact time the message was created. </param>
        /// <param name="accessedOn"> Last time there was a receive request to this subscription. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="countDetails"> Message count details. </param>
        /// <param name="lockDuration"> ISO 8061 lock duration timespan for the subscription. The default value is 1 minute. </param>
        /// <param name="requiresSession"> Value indicating if a subscription supports the concept of sessions. </param>
        /// <param name="defaultMessageTimeToLive"> ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </param>
        /// <param name="deadLetteringOnFilterEvaluationExceptions"> Value that indicates whether a subscription has dead letter support on filter evaluation exceptions. </param>
        /// <param name="deadLetteringOnMessageExpiration"> Value that indicates whether a subscription has dead letter support when a message expires. </param>
        /// <param name="duplicateDetectionHistoryTimeWindow"> ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </param>
        /// <param name="maxDeliveryCount"> Number of maximum deliveries. </param>
        /// <param name="status"> Enumerates the possible values for the status of a messaging entity. </param>
        /// <param name="enableBatchedOperations"> Value that indicates whether server-side batched operations are enabled. </param>
        /// <param name="autoDeleteOnIdle"> ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </param>
        /// <param name="forwardTo"> Queue/Topic name to forward the messages. </param>
        /// <param name="forwardDeadLetteredMessagesTo"> Queue/Topic name to forward the Dead Letter message. </param>
        /// <param name="isClientAffine"> Value that indicates whether the subscription has an affinity to the client id. </param>
        /// <param name="clientAffineProperties"> Properties specific to client affine subscriptions. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusSubscriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? messageCount, DateTimeOffset? createdOn, DateTimeOffset? accessedOn, DateTimeOffset? updatedOn, MessageCountDetails countDetails, TimeSpan? lockDuration, bool? requiresSession, TimeSpan? defaultMessageTimeToLive, bool? deadLetteringOnFilterEvaluationExceptions, bool? deadLetteringOnMessageExpiration, TimeSpan? duplicateDetectionHistoryTimeWindow, int? maxDeliveryCount, ServiceBusMessagingEntityStatus? status, bool? enableBatchedOperations, TimeSpan? autoDeleteOnIdle, string forwardTo, string forwardDeadLetteredMessagesTo, bool? isClientAffine, ServiceBusClientAffineProperties clientAffineProperties, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            MessageCount = messageCount;
            CreatedOn = createdOn;
            AccessedOn = accessedOn;
            UpdatedOn = updatedOn;
            CountDetails = countDetails;
            LockDuration = lockDuration;
            RequiresSession = requiresSession;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DeadLetteringOnFilterEvaluationExceptions = deadLetteringOnFilterEvaluationExceptions;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            MaxDeliveryCount = maxDeliveryCount;
            Status = status;
            EnableBatchedOperations = enableBatchedOperations;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            ForwardTo = forwardTo;
            ForwardDeadLetteredMessagesTo = forwardDeadLetteredMessagesTo;
            IsClientAffine = isClientAffine;
            ClientAffineProperties = clientAffineProperties;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of messages. </summary>
        public long? MessageCount { get; }
        /// <summary> Exact time the message was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last time there was a receive request to this subscription. </summary>
        public DateTimeOffset? AccessedOn { get; }
        /// <summary> The exact time the message was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Message count details. </summary>
        public MessageCountDetails CountDetails { get; }
        /// <summary> ISO 8061 lock duration timespan for the subscription. The default value is 1 minute. </summary>
        public TimeSpan? LockDuration { get; set; }
        /// <summary> Value indicating if a subscription supports the concept of sessions. </summary>
        public bool? RequiresSession { get; set; }
        /// <summary> ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </summary>
        public TimeSpan? DefaultMessageTimeToLive { get; set; }
        /// <summary> Value that indicates whether a subscription has dead letter support on filter evaluation exceptions. </summary>
        public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }
        /// <summary> Value that indicates whether a subscription has dead letter support when a message expires. </summary>
        public bool? DeadLetteringOnMessageExpiration { get; set; }
        /// <summary> ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </summary>
        public TimeSpan? DuplicateDetectionHistoryTimeWindow { get; set; }
        /// <summary> Number of maximum deliveries. </summary>
        public int? MaxDeliveryCount { get; set; }
        /// <summary> Enumerates the possible values for the status of a messaging entity. </summary>
        public ServiceBusMessagingEntityStatus? Status { get; set; }
        /// <summary> Value that indicates whether server-side batched operations are enabled. </summary>
        public bool? EnableBatchedOperations { get; set; }
        /// <summary> ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </summary>
        public TimeSpan? AutoDeleteOnIdle { get; set; }
        /// <summary> Queue/Topic name to forward the messages. </summary>
        public string ForwardTo { get; set; }
        /// <summary> Queue/Topic name to forward the Dead Letter message. </summary>
        public string ForwardDeadLetteredMessagesTo { get; set; }
        /// <summary> Value that indicates whether the subscription has an affinity to the client id. </summary>
        public bool? IsClientAffine { get; set; }
        /// <summary> Properties specific to client affine subscriptions. </summary>
        public ServiceBusClientAffineProperties ClientAffineProperties { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
