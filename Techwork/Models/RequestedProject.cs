//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Techwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestedProject
    {
        public int RequestId { get; set; }
        public string Subject { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> ExpectedSubmissionDate { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> Requested_On { get; set; }
        public string RequestedBy { get; set; }
        public string postedby { get; set; }
    }
}