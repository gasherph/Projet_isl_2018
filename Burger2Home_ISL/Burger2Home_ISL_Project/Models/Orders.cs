//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Burger2Home_ISL_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int order_id { get; set; }
        public Nullable<System.DateTime> orderDate { get; set; }
        public Nullable<decimal> orderAmount { get; set; }
        public Nullable<int> burger_id { get; set; }
        public Nullable<int> customer_id { get; set; }
    
        public virtual Burger Burger { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
