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
    
    public partial class BAppAm
    {
        public int Id { get; set; }
        public Nullable<int> AppId { get; set; }
        public Nullable<int> AccountManagerId { get; set; }
        public Nullable<int> ReviewerID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> BorrowerId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Remarks { get; set; }
    }
}