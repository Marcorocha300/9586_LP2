//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAlojamentoLocal
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string userName { get; set; }
        public byte[] passWord { get; set; }
        public Nullable<int> idCustomer { get; set; }
        public Nullable<int> idStaff { get; set; }
        public int id { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
    }
}