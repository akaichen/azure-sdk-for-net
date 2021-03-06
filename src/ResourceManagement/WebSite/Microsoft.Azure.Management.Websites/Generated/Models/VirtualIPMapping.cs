// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class that represents a VIP mapping
    /// </summary>
    public partial class VirtualIPMapping
    {
        /// <summary>
        /// Initializes a new instance of the VirtualIPMapping class.
        /// </summary>
        public VirtualIPMapping() { }

        /// <summary>
        /// Initializes a new instance of the VirtualIPMapping class.
        /// </summary>
        public VirtualIPMapping(string virtualIP = default(string), int? internalHttpPort = default(int?), int? internalHttpsPort = default(int?), bool? inUse = default(bool?))
        {
            VirtualIP = virtualIP;
            InternalHttpPort = internalHttpPort;
            InternalHttpsPort = internalHttpsPort;
            InUse = inUse;
        }

        /// <summary>
        /// Virtual IP address
        /// </summary>
        [JsonProperty(PropertyName = "virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// Internal HTTP port
        /// </summary>
        [JsonProperty(PropertyName = "internalHttpPort")]
        public int? InternalHttpPort { get; set; }

        /// <summary>
        /// Internal HTTPS port
        /// </summary>
        [JsonProperty(PropertyName = "internalHttpsPort")]
        public int? InternalHttpsPort { get; set; }

        /// <summary>
        /// Is VIP mapping in use
        /// </summary>
        [JsonProperty(PropertyName = "inUse")]
        public bool? InUse { get; set; }

    }
}
