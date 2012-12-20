//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Fund Service class
    /// </summary>
    public partial class FundService : Service<Fund>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundService"/> class
        /// </summary>
        public FundService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundService"/> class
        /// </summary>
        public FundService(IRepository<Fund> repository) : base(repository)
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
        public bool CanDelete( Fund item, out string errorMessage )
        {
            errorMessage = string.Empty;
 
            if ( new Service<Fund>().Queryable().Any( a => a.ParentFundId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Fund.FriendlyTypeName, Fund.FriendlyTypeName );
                return false;
            }  
 
            if ( new Service<Pledge>().Queryable().Any( a => a.FundId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", Fund.FriendlyTypeName, Pledge.FriendlyTypeName );
                return false;
            }  
            return true;
        }
    }
}
