//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int OrderItem_id { get; set; }
        public Nullable<int> Order_id { get; set; }
        public Nullable<int> Product_id { get; set; }
        public Nullable<int> Product_qty { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
