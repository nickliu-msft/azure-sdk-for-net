// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudKubernetesClusterFeatureResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2024-07-01/examples/KubernetesClusterFeatures_Get.json
            // this example is just showing the usage of "KubernetesClusterFeatures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterFeatureResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterFeatureResource, please refer to the document of NetworkCloudKubernetesClusterFeatureResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            string featureName = "featureName";
            ResourceIdentifier networkCloudKubernetesClusterFeatureResourceId = NetworkCloudKubernetesClusterFeatureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName, featureName);
            NetworkCloudKubernetesClusterFeatureResource networkCloudKubernetesClusterFeature = client.GetNetworkCloudKubernetesClusterFeatureResource(networkCloudKubernetesClusterFeatureResourceId);

            // invoke the operation
            NetworkCloudKubernetesClusterFeatureResource result = await networkCloudKubernetesClusterFeature.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudKubernetesClusterFeatureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2024-07-01/examples/KubernetesClusterFeatures_Delete.json
            // this example is just showing the usage of "KubernetesClusterFeatures_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterFeatureResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterFeatureResource, please refer to the document of NetworkCloudKubernetesClusterFeatureResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            string featureName = "featureName";
            ResourceIdentifier networkCloudKubernetesClusterFeatureResourceId = NetworkCloudKubernetesClusterFeatureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName, featureName);
            NetworkCloudKubernetesClusterFeatureResource networkCloudKubernetesClusterFeature = client.GetNetworkCloudKubernetesClusterFeatureResource(networkCloudKubernetesClusterFeatureResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudKubernetesClusterFeature.DeleteAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2024-07-01/examples/KubernetesClusterFeatures_Patch.json
            // this example is just showing the usage of "KubernetesClusterFeatures_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterFeatureResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterFeatureResource, please refer to the document of NetworkCloudKubernetesClusterFeatureResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            string featureName = "featureName";
            ResourceIdentifier networkCloudKubernetesClusterFeatureResourceId = NetworkCloudKubernetesClusterFeatureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName, featureName);
            NetworkCloudKubernetesClusterFeatureResource networkCloudKubernetesClusterFeature = client.GetNetworkCloudKubernetesClusterFeatureResource(networkCloudKubernetesClusterFeatureResourceId);

            // invoke the operation
            NetworkCloudKubernetesClusterFeaturePatch patch = new NetworkCloudKubernetesClusterFeaturePatch
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2"
},
                Options = { new StringKeyValuePair("featureOptionName", "featureOptionValue") },
            };
            ArmOperation<NetworkCloudKubernetesClusterFeatureResource> lro = await networkCloudKubernetesClusterFeature.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudKubernetesClusterFeatureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudKubernetesClusterFeatureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
