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
    
    public partial class inAndOutHistory
    {
        public short inAndOutHistoryID { get; set; }
        public short userID { get; set; }
        public short verifyCheckID { get; set; }
        public System.TimeSpan arrivingTime { get; set; }
        public System.TimeSpan leavingTime { get; set; }
        public System.DateTime workDate { get; set; }
    
        public virtual user user { get; set; }
        public virtual verifyCheck verifyCheck { get; set; }
    }
}