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
    
    public partial class WorkDictionary
    {
        public WorkDictionary()
        {
            this.DrillingDifficulty = new HashSet<DrillingDifficulty>();
            this.DrillingType = new HashSet<DrillingType>();
            this.WorkConfig = new HashSet<WorkConfig>();
        }
    
        public int ID { get; set; }
        public int ConfigUserID { get; set; }
        public System.DateTime ConfigTime { get; set; }
    
        public virtual ICollection<DrillingDifficulty> DrillingDifficulty { get; set; }
        public virtual ICollection<DrillingType> DrillingType { get; set; }
        public virtual SecurityUser SecurityUser { get; set; }
        public virtual ICollection<WorkConfig> WorkConfig { get; set; }
    }
}
