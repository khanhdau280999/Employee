namespace Employee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Required]
        public long id { get; set; }
        [Display(Name ="Họ và tên")]
        [StringLength(200)]
        public string HoVaTen { get; set; }
        [Display(Name = "Giới tính")]
        public bool GioiTinh { get; set; }
        [Display(Name = "Email")]
        [StringLength(200)]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [StringLength(200)]
        public string SoDienThoai { get; set; }
        [Display(Name = "Tên đăng nhập")]
        [StringLength(200)]
        public string TenDangNhap { get; set; }
        [Display(Name = "Mật khẩu")]
        [StringLength(200)]
        public string MatKhau { get; set; }
        [Display(Name = "Số Chức vụ")]
        public long? IdChucVu { get; set; }
        [Display(Name = "Quản trị")]
        public bool LaQuanTri { get; set; }
        [Display(Name = "Chuyên viên")]
        public bool LaChuyenVien { get; set; }
        [Display(Name = "Nhân viên")]
        public bool LaNhanVien { get; set; }
        [Display(Name = "Chức vụ")]
        public virtual ChucVu ChucVu { get; set; }
    }
}
