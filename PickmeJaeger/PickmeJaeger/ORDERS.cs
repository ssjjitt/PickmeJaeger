//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PickmeJaeger
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDERS
    {
        public int OrderID { get; set; }
        public Nullable<int> UserOID { get; set; }
        public Nullable<System.DateTime> BookingDatetime { get; set; }
        public Nullable<int> TableOID { get; set; }
        public string UserEmail { get; set; }
        public string Wishes { get; set; }
        public Nullable<int> OrderStatus { get; set; }
    
        public virtual RESTABLES RESTABLES { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
