//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChecadorHonorarios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class view_user
    {
        public short userID { get; set; }
        public short scheduleID { get; set; }
        public short fingerprintID { get; set; }
        public System.DateTime birthday { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string lastname2 { get; set; }
        public string jobPosition { get; set; }
        public string email { get; set; }
        public Nullable<bool> deleted { get; set; }
        public bool status { get; set; }
        public string ACTIVO { get; set; }
    }
}
