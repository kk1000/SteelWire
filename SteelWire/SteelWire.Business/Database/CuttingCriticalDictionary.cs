//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SteelWire.Business.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuttingCriticalDictionary
    {
        public CuttingCriticalDictionary()
        {
            this.CuttingCriticalConfig = new HashSet<CuttingCriticalConfig>();
            this.WireropeCutRole = new HashSet<WireropeCutRole>();
            this.WireropeEfficiency = new HashSet<WireropeEfficiency>();
            this.WireropeWorkload = new HashSet<WireropeWorkload>();
        }
    
        public int ID { get; set; }
        public int ConfigUserID { get; set; }
        public System.DateTime ConfigTime { get; set; }
    
        public virtual ICollection<CuttingCriticalConfig> CuttingCriticalConfig { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        public virtual ICollection<WireropeCutRole> WireropeCutRole { get; set; }
        public virtual ICollection<WireropeEfficiency> WireropeEfficiency { get; set; }
        public virtual ICollection<WireropeWorkload> WireropeWorkload { get; set; }
    }
}
