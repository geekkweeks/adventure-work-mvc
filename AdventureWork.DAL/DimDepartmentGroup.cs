//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWork.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimDepartmentGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimDepartmentGroup()
        {
            this.DimDepartmentGroup1 = new HashSet<DimDepartmentGroup>();
            this.FactFinances = new HashSet<FactFinance>();
        }
    
        public int DepartmentGroupKey { get; set; }
        public Nullable<int> ParentDepartmentGroupKey { get; set; }
        public string DepartmentGroupName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimDepartmentGroup> DimDepartmentGroup1 { get; set; }
        public virtual DimDepartmentGroup DimDepartmentGroup2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactFinance> FactFinances { get; set; }
    }
}
