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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Backup policy recurring schedule.
    /// </summary>
    public partial class ScheduleRecurrence
    {
        private RecurrenceType _recurrenceType;
        
        /// <summary>
        /// Required. The type of the recurrence.
        /// </summary>
        public RecurrenceType RecurrenceType
        {
            get { return this._recurrenceType; }
            set { this._recurrenceType = value; }
        }
        
        private int _recurrenceValue;
        
        /// <summary>
        /// Required. The recurrence value.
        /// </summary>
        public int RecurrenceValue
        {
            get { return this._recurrenceValue; }
            set { this._recurrenceValue = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleRecurrence class.
        /// </summary>
        public ScheduleRecurrence()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ScheduleRecurrence class with
        /// required arguments.
        /// </summary>
        public ScheduleRecurrence(RecurrenceType recurrenceType, int recurrenceValue)
            : this()
        {
            this.RecurrenceType = recurrenceType;
            this.RecurrenceValue = recurrenceValue;
        }
    }
}
