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
    
    public partial class WireropeEfficiency
    {
        public long ID { get; set; }
        public long DictionaryID { get; set; }
        public long RopeCount { get; set; }
        public decimal SlidingValue { get; set; }
        public decimal RollingValue { get; set; }
    
        public virtual CriticalDictionary CriticalDictionary { get; set; }
    }
}
