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
    
    public partial class tblProjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProjects()
        {
            this.tblProcess = new HashSet<tblProcess>();
        }
    
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<decimal> Budget { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<int> ProjectUserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Description { get; set; }
        public string CreateUserName { get; set; }
        public string ProjectUserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcess> tblProcess { get; set; }
        public virtual tblUsers tblUsers { get; set; }
        public virtual tblUsers tblUsers1 { get; set; }
    }
}