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
    
    public partial class InvestorDocument
    {
        public int InvestorDocumentID { get; set; }
        public byte[] UploadedDocument { get; set; }
        public string UploadDocumentPath { get; set; }
        public Nullable<int> InvestorApplicationID { get; set; }
    
        public virtual InvestorApplication InvestorApplication { get; set; }
    }
}
