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
    
    public partial class CriticalConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CriticalConfig()
        {
            this.CriticalRecord = new HashSet<CriticalRecord>();
            this.CumulationRecord = new HashSet<CumulationRecord>();
        }
    
        public long ID { get; set; }
        public long DictionaryID { get; set; }
        public long ConfigUserID { get; set; }
        public decimal DerrickHeight { get; set; }
        public decimal WirelineMaxPower { get; set; }
        public decimal RotaryHookWorkload { get; set; }
        public decimal RollerDiameter { get; set; }
        public long RopeCount { get; set; }
        public System.DateTime ConfigTime { get; set; }
        public long ConfigTimeStamp { get; set; }
    
        public virtual CriticalDictionary CriticalDictionary { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriticalRecord> CriticalRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumulationRecord> CumulationRecord { get; set; }
    }
}
