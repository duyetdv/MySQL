using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpdateTSCD.Controllers
{
    public class DanhSachTSCD
    {
        public int Id { get; set; }

        [Display(Name = "Loại tài sản")]
        [Required(ErrorMessage = "Bạn cần nhập Loại tài sản")]
        public string LoaiTS { get; set; }

        [Display(Name = "Thông số kỹ thuật")]
        public string ThongSo { get; set; }

        [Display(Name = "Hình ảnh tài sản")]
        public string Photo { get; set; }

        [Display(Name = "Người sử dụng")]
        [Required(ErrorMessage = "Bạn cần nhập Mã NV sử dụng")]
        public string NguoiSD { get; set; }
        [Display(Name = "Tình trạng")]
        public string TinhTrang { get; set; }
        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

        [Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayTao { get; set; }

       

    }
}