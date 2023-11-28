// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Network Rule Set Properties of this IoT Central application. </summary>
    public partial class IotCentralNetworkRuleSets
    {
        /// <summary> Initializes a new instance of <see cref="IotCentralNetworkRuleSets"/>. </summary>
        public IotCentralNetworkRuleSets()
        {
            IPRules = new ChangeTrackingList<IotCentralNetworkRuleSetIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralNetworkRuleSets"/>. </summary>
        /// <param name="applyToDevices"> Whether these rules apply for device connectivity to IoT Hub and Device Provisioning service associated with this application. </param>
        /// <param name="applyToIotCentral"> Whether these rules apply for connectivity via IoT Central web portal and APIs. </param>
        /// <param name="defaultAction"> The default network action to apply. </param>
        /// <param name="ipRules"> List of IP rules. </param>
        internal IotCentralNetworkRuleSets(bool? applyToDevices, bool? applyToIotCentral, IotCentralNetworkAction? defaultAction, IList<IotCentralNetworkRuleSetIPRule> ipRules)
        {
            ApplyToDevices = applyToDevices;
            ApplyToIotCentral = applyToIotCentral;
            DefaultAction = defaultAction;
            IPRules = ipRules;
        }

        /// <summary> Whether these rules apply for device connectivity to IoT Hub and Device Provisioning service associated with this application. </summary>
        public bool? ApplyToDevices { get; set; }
        /// <summary> Whether these rules apply for connectivity via IoT Central web portal and APIs. </summary>
        public bool? ApplyToIotCentral { get; set; }
        /// <summary> The default network action to apply. </summary>
        public IotCentralNetworkAction? DefaultAction { get; set; }
        /// <summary> List of IP rules. </summary>
        public IList<IotCentralNetworkRuleSetIPRule> IPRules { get; }
    }
}
