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
    
    public partial class CumulationDictionary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CumulationDictionary()
        {
            this.CumulationConfig = new HashSet<CumulationConfig>();
            this.DrillingType = new HashSet<DrillingType>();
        }
    
        public long ID { get; set; }
        public long ConfigUserID { get; set; }
        public System.DateTime ConfigTime { get; set; }
        public long ConfigTimeStamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CumulationConfig> CumulationConfig { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrillingType> DrillingType { get; set; }
    }
}
