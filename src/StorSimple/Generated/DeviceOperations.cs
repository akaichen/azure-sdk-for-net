// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// All Operations related to Devices  (see
    /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx for
    /// more information)
    /// </summary>
    internal partial class DeviceOperations : IServiceOperations<StorSimpleManagementClient>, Microsoft.WindowsAzure.Management.StorSimple.IDeviceOperations
    {
        /// <summary>
        /// Initializes a new instance of the DeviceOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal DeviceOperations(StorSimpleManagementClient client)
        {
            this._client = client;
        }
        
        private StorSimpleManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.StorSimpleManagementClient.
        /// </summary>
        public StorSimpleManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list of devices.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.StorSimple.Models.DeviceListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (customRequestHeaders == null)
            {
                throw new ArgumentNullException("customRequestHeaders");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/cloudservices/" + this.Client.CloudServiceName.Trim() + "/resources/" + this.Client.ResourceNamespace.Trim() + "/~/CiSVault/" + this.Client.ResourceName.Trim() + "/api/devices?";
            url = url + "api-version=2014-01-01.1.0";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/xml");
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Language);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2014-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    DeviceListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new DeviceListResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement arrayOfDeviceInfoSequenceElement = responseDoc.Element(XName.Get("ArrayOfDeviceInfo", "http://windowscloudbackup.com/CiS/V2013_03"));
                    if (arrayOfDeviceInfoSequenceElement != null)
                    {
                        foreach (XElement arrayOfDeviceInfoElement in arrayOfDeviceInfoSequenceElement.Elements(XName.Get("DeviceInfo", "http://windowscloudbackup.com/CiS/V2013_03")))
                        {
                            DeviceInfo deviceInfoInstance = new DeviceInfo();
                            result.Devices.Add(deviceInfoInstance);
                            
                            XElement friendlyNameElement = arrayOfDeviceInfoElement.Element(XName.Get("FriendlyName", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (friendlyNameElement != null)
                            {
                                string friendlyNameInstance = friendlyNameElement.Value;
                                deviceInfoInstance.FriendlyName = friendlyNameInstance;
                            }
                            
                            XElement statusElement = arrayOfDeviceInfoElement.Element(XName.Get("Status", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (statusElement != null)
                            {
                                DeviceStatus statusInstance = ((DeviceStatus)Enum.Parse(typeof(DeviceStatus), statusElement.Value, true));
                                deviceInfoInstance.Status = statusInstance;
                            }
                            
                            XElement deviceIdElement = arrayOfDeviceInfoElement.Element(XName.Get("DeviceId", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (deviceIdElement != null)
                            {
                                string deviceIdInstance = deviceIdElement.Value;
                                deviceInfoInstance.DeviceId = deviceIdInstance;
                            }
                            
                            XElement serialNumberElement = arrayOfDeviceInfoElement.Element(XName.Get("SerialNumber", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (serialNumberElement != null)
                            {
                                string serialNumberInstance = serialNumberElement.Value;
                                deviceInfoInstance.SerialNumber = serialNumberInstance;
                            }
                            
                            XElement cultureElement = arrayOfDeviceInfoElement.Element(XName.Get("Culture", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (cultureElement != null)
                            {
                                string cultureInstance = cultureElement.Value;
                                deviceInfoInstance.Culture = cultureInstance;
                            }
                            
                            XElement timeZoneElement = arrayOfDeviceInfoElement.Element(XName.Get("TimeZone", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (timeZoneElement != null)
                            {
                                string timeZoneInstance = timeZoneElement.Value;
                                deviceInfoInstance.TimeZone = timeZoneInstance;
                            }
                            
                            XElement descriptionElement = arrayOfDeviceInfoElement.Element(XName.Get("Description", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (descriptionElement != null)
                            {
                                string descriptionInstance = descriptionElement.Value;
                                deviceInfoInstance.Description = descriptionInstance;
                            }
                            
                            XElement modelDescriptionElement = arrayOfDeviceInfoElement.Element(XName.Get("ModelDescription", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (modelDescriptionElement != null)
                            {
                                string modelDescriptionInstance = modelDescriptionElement.Value;
                                deviceInfoInstance.ModelDescription = modelDescriptionInstance;
                            }
                            
                            XElement totalStorageInBytesElement = arrayOfDeviceInfoElement.Element(XName.Get("TotalStorageInBytes", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (totalStorageInBytesElement != null)
                            {
                                long totalStorageInBytesInstance = long.Parse(totalStorageInBytesElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.TotalStorageInBytes = totalStorageInBytesInstance;
                            }
                            
                            XElement availableStorageInBytesElement = arrayOfDeviceInfoElement.Element(XName.Get("AvailableStorageInBytes", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (availableStorageInBytesElement != null)
                            {
                                long availableStorageInBytesInstance = long.Parse(availableStorageInBytesElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.AvailableStorageInBytes = availableStorageInBytesInstance;
                            }
                            
                            XElement provisionedStorageInBytesElement = arrayOfDeviceInfoElement.Element(XName.Get("ProvisionedStorageInBytes", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (provisionedStorageInBytesElement != null)
                            {
                                long provisionedStorageInBytesInstance = long.Parse(provisionedStorageInBytesElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.ProvisionedStorageInBytes = provisionedStorageInBytesInstance;
                            }
                            
                            XElement usingStorageInBytesElement = arrayOfDeviceInfoElement.Element(XName.Get("UsingStorageInBytes", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (usingStorageInBytesElement != null)
                            {
                                long usingStorageInBytesInstance = long.Parse(usingStorageInBytesElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.UsingStorageInBytes = usingStorageInBytesInstance;
                            }
                            
                            XElement isConfigUpdatedElement = arrayOfDeviceInfoElement.Element(XName.Get("IsConfigUpdated", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (isConfigUpdatedElement != null)
                            {
                                bool isConfigUpdatedInstance = bool.Parse(isConfigUpdatedElement.Value);
                                deviceInfoInstance.IsConfigUpdated = isConfigUpdatedInstance;
                            }
                            
                            XElement nNicCardsElement = arrayOfDeviceInfoElement.Element(XName.Get("NNicCards", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (nNicCardsElement != null)
                            {
                                int nNicCardsInstance = int.Parse(nNicCardsElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.NNicCards = nNicCardsInstance;
                            }
                            
                            XElement dataContainerCountElement = arrayOfDeviceInfoElement.Element(XName.Get("DataContainerCount", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (dataContainerCountElement != null)
                            {
                                int dataContainerCountInstance = int.Parse(dataContainerCountElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.DataContainerCount = dataContainerCountInstance;
                            }
                            
                            XElement volumeCountElement = arrayOfDeviceInfoElement.Element(XName.Get("VolumeCount", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (volumeCountElement != null)
                            {
                                int volumeCountInstance = int.Parse(volumeCountElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.VolumeCount = volumeCountInstance;
                            }
                            
                            XElement aCRCountElement = arrayOfDeviceInfoElement.Element(XName.Get("ACRCount", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (aCRCountElement != null)
                            {
                                int aCRCountInstance = int.Parse(aCRCountElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.ACRCount = aCRCountInstance;
                            }
                            
                            XElement cloudCredCountElement = arrayOfDeviceInfoElement.Element(XName.Get("CloudCredCount", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (cloudCredCountElement != null)
                            {
                                int cloudCredCountInstance = int.Parse(cloudCredCountElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.CloudCredCount = cloudCredCountInstance;
                            }
                            
                            XElement targetIQNElement = arrayOfDeviceInfoElement.Element(XName.Get("TargetIQN", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (targetIQNElement != null)
                            {
                                string targetIQNInstance = targetIQNElement.Value;
                                deviceInfoInstance.TargetIQN = targetIQNInstance;
                            }
                            
                            XElement deviceSoftwareVersionElement = arrayOfDeviceInfoElement.Element(XName.Get("DeviceSoftwareVersion", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (deviceSoftwareVersionElement != null)
                            {
                                string deviceSoftwareVersionInstance = deviceSoftwareVersionElement.Value;
                                deviceInfoInstance.DeviceSoftwareVersion = deviceSoftwareVersionInstance;
                            }
                            
                            XElement activationTimeElement = arrayOfDeviceInfoElement.Element(XName.Get("ActivationTime", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (activationTimeElement != null)
                            {
                                DateTime activationTimeInstance = DateTime.Parse(activationTimeElement.Value, CultureInfo.InvariantCulture);
                                deviceInfoInstance.ActivationTime = activationTimeInstance;
                            }
                            
                            XElement typeElement = arrayOfDeviceInfoElement.Element(XName.Get("Type", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (typeElement != null)
                            {
                                DeviceType typeInstance = ((DeviceType)Enum.Parse(typeof(DeviceType), typeElement.Value, true));
                                deviceInfoInstance.Type = typeInstance;
                            }
                            
                            XElement currentControllerElement = arrayOfDeviceInfoElement.Element(XName.Get("CurrentController", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (currentControllerElement != null)
                            {
                                ControllerId currentControllerInstance = ((ControllerId)Enum.Parse(typeof(ControllerId), currentControllerElement.Value, true));
                                deviceInfoInstance.CurrentController = currentControllerInstance;
                            }
                            
                            XElement activeControllerElement = arrayOfDeviceInfoElement.Element(XName.Get("ActiveController", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (activeControllerElement != null)
                            {
                                ControllerId activeControllerInstance = ((ControllerId)Enum.Parse(typeof(ControllerId), activeControllerElement.Value, true));
                                deviceInfoInstance.ActiveController = activeControllerInstance;
                            }
                            
                            XElement isVirtualApplianceInterimEntryElement = arrayOfDeviceInfoElement.Element(XName.Get("IsVirtualApplianceInterimEntry", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (isVirtualApplianceInterimEntryElement != null)
                            {
                                bool isVirtualApplianceInterimEntryInstance = bool.Parse(isVirtualApplianceInterimEntryElement.Value);
                                deviceInfoInstance.IsVirtualApplianceInterimEntry = isVirtualApplianceInterimEntryInstance;
                            }
                            
                            XElement locationElement = arrayOfDeviceInfoElement.Element(XName.Get("Location", "http://windowscloudbackup.com/CiS/V2013_03"));
                            if (locationElement != null)
                            {
                                string locationInstance = locationElement.Value;
                                deviceInfoInstance.Location = locationInstance;
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
