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
    
    public partial class tblUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsers()
        {
            this.tblProcess = new HashSet<tblProcess>();
            this.tblProjects = new HashSet<tblProjects>();
            this.tblProjects1 = new HashSet<tblProjects>();
            this.tblUserLogs = new HashSet<tblUserLogs>();
            this.tblUserProcess = new HashSet<tblUserProcess>();
            this.tblUserRoles = new HashSet<tblUserRoles>();
            this.tblWorkFollow = new HashSet<tblWorkFollow>();
        }
    
        public int UsersID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserNickname { get; set; }
        public string UserPassword { get; set; }
        public Nullable<System.DateTime> UserCreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcess> tblProcess { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProjects> tblProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProjects> tblProjects1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserLogs> tblUserLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserProcess> tblUserProcess { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserRoles> tblUserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWorkFollow> tblWorkFollow { get; set; }
    }
}
