//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// WorkflowType Service class
    /// </summary>
    public partial class WorkflowTypeService : Service<WorkflowType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTypeService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public WorkflowTypeService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( WorkflowType item, out string errorMessage )
        {
            errorMessage = string.Empty;
 
            if ( new Service<RegistrationInstance>( Context ).Queryable().Any( a => a.RegistrationWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, RegistrationInstance.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<RegistrationTemplate>( Context ).Queryable().Any( a => a.RegistrationWorkflowTypeId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowType.FriendlyTypeName, RegistrationTemplate.FriendlyTypeName );
                return false;
            }  
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class WorkflowTypeExtensionMethods
    {
        /// <summary>
        /// Clones this WorkflowType object to a new WorkflowType object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static WorkflowType Clone( this WorkflowType source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as WorkflowType;
            }
            else
            {
                var target = new WorkflowType();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another WorkflowType object to this WorkflowType object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this WorkflowType target, WorkflowType source )
        {
            target.Id = source.Id;
            target.CategoryId = source.CategoryId;
            target.Description = source.Description;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IconCssClass = source.IconCssClass;
            target.IsActive = source.IsActive;
            target.IsPersisted = source.IsPersisted;
            target.IsSystem = source.IsSystem;
            target.LoggingLevel = source.LoggingLevel;
            target.Name = source.Name;
            target.Order = source.Order;
            target.ProcessingIntervalSeconds = source.ProcessingIntervalSeconds;
            target.WorkflowIdPrefix = source.WorkflowIdPrefix;
            target.WorkTerm = source.WorkTerm;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
