//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DMChuDe
    {
        public DMChuDe()
        {
            this.KhoaHocs = new HashSet<KhoaHoc>();
        }
    
        public int MaChuDe { get; set; }
        public string TenChuDe { get; set; }
        public Nullable<int> CapChuDe { get; set; }
        public Nullable<int> ChuDeCha { get; set; }
        public Nullable<int> MoTa { get; set; }
    
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
