// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Quota.Samples
{
    public partial class Sample_CurrentUsagesBaseCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotasUsagesRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation
            string resourceName = "standardNDSFamily";
            CurrentUsagesBaseResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CurrentUsagesBaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuotasUsagesRequestForNetwork()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getNetworkOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation
            string resourceName = "MinPublicIpInterNetworkPrefixLength";
            CurrentUsagesBaseResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CurrentUsagesBaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QuotasListUsagesForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getComputeUsages.json
            // this example is just showing the usage of "Usages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (CurrentUsagesBaseResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CurrentUsagesBaseData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QuotasListUsagesForNetwork()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getNetworkUsages.json
            // this example is just showing the usage of "Usages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (CurrentUsagesBaseResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CurrentUsagesBaseData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QuotasListUsagesMachineLearningServices()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getMachineLearningServicesUsages.json
            // this example is just showing the usage of "Usages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.MachineLearningServices/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (CurrentUsagesBaseResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CurrentUsagesBaseData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QuotasUsagesRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation
            string resourceName = "standardNDSFamily";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QuotasUsagesRequestForNetwork()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getNetworkOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation
            string resourceName = "MinPublicIpInterNetworkPrefixLength";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QuotasUsagesRequestForCompute()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getComputeOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Compute/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation
            string resourceName = "standardNDSFamily";
            NullableResponse<CurrentUsagesBaseResource> response = await collection.GetIfExistsAsync(resourceName);
            CurrentUsagesBaseResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CurrentUsagesBaseData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QuotasUsagesRequestForNetwork()
        {
            // Generated from example definition: specification/quota/resource-manager/Microsoft.Quota/preview/2024-12-18-preview/examples/getNetworkOneSkuUsages.json
            // this example is just showing the usage of "Usages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this CurrentUsagesBaseResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.Network/locations/eastus";
            CurrentUsagesBaseCollection collection = client.GetCurrentUsagesBases(new ResourceIdentifier(scope));

            // invoke the operation
            string resourceName = "MinPublicIpInterNetworkPrefixLength";
            NullableResponse<CurrentUsagesBaseResource> response = await collection.GetIfExistsAsync(resourceName);
            CurrentUsagesBaseResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CurrentUsagesBaseData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
