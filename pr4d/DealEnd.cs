//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr4d
{
    using System;
    using System.Collections.Generic;
    
    public partial class DealEnd
    {
        public int dealEnd_id { get; set; }
        public Nullable<int> deal { get; set; }
        public Nullable<int> realtor { get; set; }
        public Nullable<System.DateTime> dealEnd_date { get; set; }
    
        public virtual Deal Deal1 { get; set; }
        public virtual Realtor Realtor1 { get; set; }
    }
}
