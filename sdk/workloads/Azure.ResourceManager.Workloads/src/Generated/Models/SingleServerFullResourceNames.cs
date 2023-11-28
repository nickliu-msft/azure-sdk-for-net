// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The resource name object where the specified values will be full resource names of the corresponding resources in a single server SAP system. </summary>
    public partial class SingleServerFullResourceNames : SingleServerCustomResourceNames
    {
        /// <summary> Initializes a new instance of <see cref="SingleServerFullResourceNames"/>. </summary>
        public SingleServerFullResourceNames()
        {
            NamingPatternType = SapNamingPatternType.FullResourceName;
        }

        /// <summary> Initializes a new instance of <see cref="SingleServerFullResourceNames"/>. </summary>
        /// <param name="namingPatternType"> The pattern type to be used for resource naming. </param>
        /// <param name="virtualMachine"> The resource names object for virtual machine and related resources. </param>
        internal SingleServerFullResourceNames(SapNamingPatternType namingPatternType, VirtualMachineResourceNames virtualMachine) : base(namingPatternType)
        {
            VirtualMachine = virtualMachine;
            NamingPatternType = namingPatternType;
        }

        /// <summary> The resource names object for virtual machine and related resources. </summary>
        public VirtualMachineResourceNames VirtualMachine { get; set; }
    }
}
