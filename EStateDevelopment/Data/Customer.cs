//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EStateDevelopment.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.BorrowerAssets = new HashSet<BorrowerAsset>();
        }
    
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string GuardianName { get; set; }
        public string MartialStatus { get; set; }
        public string SpouseName { get; set; }
        public string KidsCount { get; set; }
        public string HomeAddress { get; set; }
        public string TempareryAddress { get; set; }
        public string NationalID { get; set; }
        public string NTN { get; set; }
        public string Process { get; set; }
        public string CustomerNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BorrowerAsset> BorrowerAssets { get; set; }
    }
}
