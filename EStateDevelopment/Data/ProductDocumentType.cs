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
    
    public partial class ProductDocumentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductDocumentType()
        {
            this.ProductDocuments = new HashSet<ProductDocument>();
        }
    
        public int ProductDocumentTypeID { get; set; }
        public string DocumentType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDocument> ProductDocuments { get; set; }
    }
}
