// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementGroups.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagementGroups
{
    /// <summary>
    /// A Class representing a ManagementGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagementGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagementGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetManagementGroup method.
    /// </summary>
    public partial class ManagementGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagementGroupResource"/> instance. </summary>
        /// <param name="groupId"> The groupId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string groupId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managementGroupClientDiagnostics;
        private readonly ManagementGroupsRestOperations _managementGroupRestClient;
        private readonly ManagementGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Management/managementGroups";

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResource"/> class for mocking. </summary>
        protected ManagementGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagementGroupResource(ArmClient client, ManagementGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagementGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managementGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagementGroups", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managementGroupApiVersion);
            _managementGroupRestClient = new ManagementGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagementGroupData Data
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

        /// <summary>
        /// Get the details of the management group.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand=children query string parameter allows clients to request inclusion of children in the response payload.  $expand=path includes the path from the root group to the current group.  $expand=ancestors includes the ancestor Ids of the current group. </param>
        /// <param name="recurse"> The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload. Note that  $expand=children must be passed up if $recurse is set to true. </param>
        /// <param name="filter"> A filter which allows the exclusion of subscriptions from results (i.e. '$filter=children.childType ne Subscription'). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagementGroupResource>> GetAsync(ManagementGroupExpandType? expand = null, bool? recurse = null, string filter = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _managementGroupRestClient.GetAsync(Id.Name, expand, recurse, filter, cacheControl, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the management group.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The $expand=children query string parameter allows clients to request inclusion of children in the response payload.  $expand=path includes the path from the root group to the current group.  $expand=ancestors includes the ancestor Ids of the current group. </param>
        /// <param name="recurse"> The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload. Note that  $expand=children must be passed up if $recurse is set to true. </param>
        /// <param name="filter"> A filter which allows the exclusion of subscriptions from results (i.e. '$filter=children.childType ne Subscription'). </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementGroupResource> Get(ManagementGroupExpandType? expand = null, bool? recurse = null, string filter = null, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroupResource.Get");
            scope.Start();
            try
            {
                var response = _managementGroupRestClient.Get(Id.Name, expand, recurse, filter, cacheControl, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete management group.
        /// If a management group contains child resources, the request will fail.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _managementGroupRestClient.DeleteAsync(Id.Name, cacheControl, cancellationToken).ConfigureAwait(false);
                var operation = new ManagementGroupsArmOperation(_managementGroupClientDiagnostics, Pipeline, _managementGroupRestClient.CreateDeleteRequest(Id.Name, cacheControl).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete management group.
        /// If a management group contains child resources, the request will fail.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _managementGroupRestClient.Delete(Id.Name, cacheControl, cancellationToken);
                var operation = new ManagementGroupsArmOperation(_managementGroupClientDiagnostics, Pipeline, _managementGroupRestClient.CreateDeleteRequest(Id.Name, cacheControl).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Update a management group.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Management group patch parameters. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<ManagementGroupResource>> UpdateAsync(ManagementGroupPatch patch, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _managementGroupRestClient.UpdateAsync(Id.Name, patch, cacheControl, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a management group.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Management group patch parameters. </param>
        /// <param name="cacheControl"> Indicates whether the request should utilize any caches. Populate the header with 'no-cache' value to bypass existing caches. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<ManagementGroupResource> Update(ManagementGroupPatch patch, string cacheControl = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _managementGroupClientDiagnostics.CreateScope("ManagementGroupResource.Update");
            scope.Start();
            try
            {
                var response = _managementGroupRestClient.Update(Id.Name, patch, cacheControl, cancellationToken);
                return Response.FromValue(new ManagementGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all entities that descend from a management group.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/descendants</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_GetDescendants</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DescendantData"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DescendantData> GetDescendantsAsync(string skipToken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupRestClient.CreateGetDescendantsRequest(Id.Name, skipToken, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupRestClient.CreateGetDescendantsNextPageRequest(nextLink, Id.Name, skipToken, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => DescendantData.DeserializeDescendantData(e), _managementGroupClientDiagnostics, Pipeline, "ManagementGroupResource.GetDescendants", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all entities that descend from a management group.
        ///
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/descendants</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagementGroups_GetDescendants</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagementGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken">
        /// Page continuation token is only used if a previous operation returned a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.
        ///
        /// </param>
        /// <param name="top"> Number of elements to return when retrieving results. Passing this in will override $skipToken. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DescendantData"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DescendantData> GetDescendants(string skipToken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managementGroupRestClient.CreateGetDescendantsRequest(Id.Name, skipToken, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managementGroupRestClient.CreateGetDescendantsNextPageRequest(nextLink, Id.Name, skipToken, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => DescendantData.DeserializeDescendantData(e), _managementGroupClientDiagnostics, Pipeline, "ManagementGroupResource.GetDescendants", "value", "nextLink", cancellationToken);
        }
    }
}
