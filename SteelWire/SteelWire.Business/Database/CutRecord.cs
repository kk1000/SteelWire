//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SteelWire.Business.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class CutRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CutRecord()
        {
            this.CumulationRecord = new HashSet<CumulationRecord>();
        }
    
        public long ID { get; set; }
        public long WirelineID { get; set; }
        public long UpdateUserID { get; set; }
        public decimal CumulationValue { get; set; }
        public decimal CutValue { get; set; }
        public decimal RemainValue { get; set; }
        public decimal CutLength { get; set; }
        public System.DateTime UpdateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumulationRecord> CumulationRecord { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        public virtual WirelineInfo WirelineInfo { get; set; }
    }
}