// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceNetworking.Mocking;

namespace Azure.ResourceManager.ServiceNetworking
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceNetworking. </summary>
    public static partial class ServiceNetworkingExtensions
    {
        private static MockableServiceNetworkingArmClient GetMockableServiceNetworkingArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableServiceNetworkingArmClient(client0));
        }

        private static MockableServiceNetworkingResourceGroupResource GetMockableServiceNetworkingResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceNetworkingResourceGroupResource(client, resource.Id));
        }

        private static MockableServiceNetworkingSubscriptionResource GetMockableServiceNetworkingSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableServiceNetworkingSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrafficControllerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficControllerResource.CreateResourceIdentifier" /> to create a <see cref="TrafficControllerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingArmClient.GetTrafficControllerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficControllerResource"/> object. </returns>
        public static TrafficControllerResource GetTrafficControllerResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceNetworkingArmClient(client).GetTrafficControllerResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AssociationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssociationResource.CreateResourceIdentifier" /> to create an <see cref="AssociationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingArmClient.GetAssociationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AssociationResource"/> object. </returns>
        public static AssociationResource GetAssociationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceNetworkingArmClient(client).GetAssociationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontendResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontendResource.CreateResourceIdentifier" /> to create a <see cref="FrontendResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingArmClient.GetFrontendResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FrontendResource"/> object. </returns>
        public static FrontendResource GetFrontendResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceNetworkingArmClient(client).GetFrontendResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ApplicationGatewayForContainersSecurityPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApplicationGatewayForContainersSecurityPolicyResource.CreateResourceIdentifier" /> to create an <see cref="ApplicationGatewayForContainersSecurityPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingArmClient.GetApplicationGatewayForContainersSecurityPolicyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ApplicationGatewayForContainersSecurityPolicyResource"/> object. </returns>
        public static ApplicationGatewayForContainersSecurityPolicyResource GetApplicationGatewayForContainersSecurityPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableServiceNetworkingArmClient(client).GetApplicationGatewayForContainersSecurityPolicyResource(id);
        }

        /// <summary>
        /// Gets a collection of TrafficControllerResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingResourceGroupResource.GetTrafficControllers()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of TrafficControllerResources and their operations over a TrafficControllerResource. </returns>
        public static TrafficControllerCollection GetTrafficControllers(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableServiceNetworkingResourceGroupResource(resourceGroupResource).GetTrafficControllers();
        }

        /// <summary>
        /// Get a TrafficController
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficControllerInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingResourceGroupResource.GetTrafficControllerAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="trafficControllerName"> traffic controller name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="trafficControllerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trafficControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<TrafficControllerResource>> GetTrafficControllerAsync(this ResourceGroupResource resourceGroupResource, string trafficControllerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableServiceNetworkingResourceGroupResource(resourceGroupResource).GetTrafficControllerAsync(trafficControllerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a TrafficController
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficControllerInterface_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingResourceGroupResource.GetTrafficController(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="trafficControllerName"> traffic controller name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="trafficControllerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trafficControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<TrafficControllerResource> GetTrafficController(this ResourceGroupResource resourceGroupResource, string trafficControllerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableServiceNetworkingResourceGroupResource(resourceGroupResource).GetTrafficController(trafficControllerName, cancellationToken);
        }

        /// <summary>
        /// List TrafficController resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceNetworking/trafficControllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficControllerInterface_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingSubscriptionResource.GetTrafficControllers(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="TrafficControllerResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TrafficControllerResource> GetTrafficControllersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableServiceNetworkingSubscriptionResource(subscriptionResource).GetTrafficControllersAsync(cancellationToken);
        }

        /// <summary>
        /// List TrafficController resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceNetworking/trafficControllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficControllerInterface_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableServiceNetworkingSubscriptionResource.GetTrafficControllers(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="TrafficControllerResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TrafficControllerResource> GetTrafficControllers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableServiceNetworkingSubscriptionResource(subscriptionResource).GetTrafficControllers(cancellationToken);
        }
    }
}
