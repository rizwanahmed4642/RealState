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
    
    public partial class BorrowerAsset
    {
        public int BorrowerAssetID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> BorrowerApplicationID { get; set; }
        public string AssetsType { get; set; }
        public string AssetsValue { get; set; }
        public string OwnerShipPercentage { get; set; }
        public string Assets { get; set; }
        public byte[] AssetFile { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
