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
    
    public partial class KhoaHoc_GiangVien
    {
        public long MaGiangVien { get; set; }
        public long MaKhoaHoc { get; set; }
        public string MoTa { get; set; }
    
        public virtual GiangVien GiangVien { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
    }
}
