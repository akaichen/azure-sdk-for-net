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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.Azure
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects  (see
    /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx for
    /// more information)
    /// </summary>
    public static partial class BackupPolicyOperationsExtensions
    {
        /// <summary>
        /// The BeginCreatingBackupPolicy operation creates a new backup policy
        /// for this given volume with the given schedules.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupPolicy'>
        /// Required. Parameters supplied to the Create Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginCreatingBackupPolicy(this IBackupPolicyOperations operations, string deviceId, NewBackupPolicyConfig backupPolicy, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).BeginCreatingBackupPolicyAsync(deviceId, backupPolicy, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The BeginCreatingBackupPolicy operation creates a new backup policy
        /// for this given volume with the given schedules.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupPolicy'>
        /// Required. Parameters supplied to the Create Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginCreatingBackupPolicyAsync(this IBackupPolicyOperations operations, string deviceId, NewBackupPolicyConfig backupPolicy, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginCreatingBackupPolicyAsync(deviceId, backupPolicy, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Begin deleting a backup policy represented by the policyId
        /// provided.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginDeleting(this IBackupPolicyOperations operations, string deviceId, string policyId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).BeginDeletingAsync(deviceId, policyId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin deleting a backup policy represented by the policyId
        /// provided.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginDeletingAsync(this IBackupPolicyOperations operations, string deviceId, string policyId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginDeletingAsync(deviceId, policyId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// The BeginUpdatingBackupPolicy operation updates a backup policy
        /// represented by policyId for this given volume with the given
        /// schedules.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to update.
        /// </param>
        /// <param name='policyInfo'>
        /// Required. Parameters supplied to the Update Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static TaskResponse BeginUpdatingBackupPolicy(this IBackupPolicyOperations operations, string deviceId, string policyId, UpdateBackupPolicyConfig policyInfo, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).BeginUpdatingBackupPolicyAsync(deviceId, policyId, policyInfo, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The BeginUpdatingBackupPolicy operation updates a backup policy
        /// represented by policyId for this given volume with the given
        /// schedules.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/FILLTHISPART.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to update.
        /// </param>
        /// <param name='policyInfo'>
        /// Required. Parameters supplied to the Update Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// This is the Task Response for all Async Calls
        /// </returns>
        public static Task<TaskResponse> BeginUpdatingBackupPolicyAsync(this IBackupPolicyOperations operations, string deviceId, string policyId, UpdateBackupPolicyConfig policyInfo, CustomRequestHeaders customRequestHeaders)
        {
            return operations.BeginUpdatingBackupPolicyAsync(deviceId, policyId, policyInfo, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupPolicy'>
        /// Required. Parameters supplied to the Create Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Create(this IBackupPolicyOperations operations, string deviceId, NewBackupPolicyConfig backupPolicy, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).CreateAsync(deviceId, backupPolicy, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='backupPolicy'>
        /// Required. Parameters supplied to the Create Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> CreateAsync(this IBackupPolicyOperations operations, string deviceId, NewBackupPolicyConfig backupPolicy, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CreateAsync(deviceId, backupPolicy, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Delete(this IBackupPolicyOperations operations, string deviceId, string policyId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).DeleteAsync(deviceId, policyId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to delete.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> DeleteAsync(this IBackupPolicyOperations operations, string deviceId, string policyId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.DeleteAsync(deviceId, policyId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyName'>
        /// Required. The name of the policy to fetch backup policy details by.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// The response model for the list of backup policies.
        /// </returns>
        public static GetBackupPolicyDetailsResponse GetBackupPolicyDetailsByName(this IBackupPolicyOperations operations, string deviceId, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).GetBackupPolicyDetailsByNameAsync(deviceId, policyName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyName'>
        /// Required. The name of the policy to fetch backup policy details by.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// The response model for the list of backup policies.
        /// </returns>
        public static Task<GetBackupPolicyDetailsResponse> GetBackupPolicyDetailsByNameAsync(this IBackupPolicyOperations operations, string deviceId, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetBackupPolicyDetailsByNameAsync(deviceId, policyName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// The response model for the list of backup policies.
        /// </returns>
        public static BackupPolicyListResponse List(this IBackupPolicyOperations operations, string deviceId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).ListAsync(deviceId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// The response model for the list of backup policies.
        /// </returns>
        public static Task<BackupPolicyListResponse> ListAsync(this IBackupPolicyOperations operations, string deviceId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(deviceId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to update.
        /// </param>
        /// <param name='policyInfo'>
        /// Required. Parameters supplied to the Create Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static TaskStatusInfo Update(this IBackupPolicyOperations operations, string deviceId, string policyId, UpdateBackupPolicyConfig policyInfo, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupPolicyOperations)s).UpdateAsync(deviceId, policyId, policyInfo, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.IBackupPolicyOperations.
        /// </param>
        /// <param name='deviceId'>
        /// Required. The device id for which the call will be made.
        /// </param>
        /// <param name='policyId'>
        /// Required. The backup policy ID to update.
        /// </param>
        /// <param name='policyInfo'>
        /// Required. Parameters supplied to the Create Backup Policy operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use.
        /// </param>
        /// <returns>
        /// Info about the async task
        /// </returns>
        public static Task<TaskStatusInfo> UpdateAsync(this IBackupPolicyOperations operations, string deviceId, string policyId, UpdateBackupPolicyConfig policyInfo, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UpdateAsync(deviceId, policyId, policyInfo, customRequestHeaders, CancellationToken.None);
        }
    }
}
