//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazilimSinamaveTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUserLogDetails
    {
        public int UserLogDetailsID { get; set; }
        public Nullable<int> UserLogsID { get; set; }
        public string UserLogDescription { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string Username { get; set; }
    
        public virtual tblUserLogs tblUserLogs { get; set; }
    }
}
