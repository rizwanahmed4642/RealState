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
    
    public partial class ProductDocument
    {
        public int ProductDocumentID { get; set; }
        public Nullable<int> ProductDocumentTypeID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string UploadedDocument { get; set; }
        public string UploadedDocumentPath { get; set; }
    
        public virtual ProductDocumentType ProductDocumentType { get; set; }
        public virtual Product Product { get; set; }
    }
}
