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
    
    public partial class FactProductInventory
    {
        public int ProductKey { get; set; }
        public int DateKey { get; set; }
        public System.DateTime MovementDate { get; set; }
        public decimal UnitCost { get; set; }
        public int UnitsIn { get; set; }
        public int UnitsOut { get; set; }
        public int UnitsBalance { get; set; }
    
        public virtual DimDate DimDate { get; set; }
        public virtual DimProduct DimProduct { get; set; }
    }
}
