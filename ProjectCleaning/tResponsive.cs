//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCleaning
{
    using System;
    using System.Collections.Generic;
    
    public partial class tResponsive
    {
        public long IdResponsive { get; set; }
        public long IdOrder { get; set; }
        public string Responsive { get; set; }
    
        public virtual tOrder tOrder { get; set; }
    }
}