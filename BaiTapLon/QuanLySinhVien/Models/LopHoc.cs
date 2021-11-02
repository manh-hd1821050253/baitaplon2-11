using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public string MALOPHOC { get; set; }
        public string TENLOPHOC { get; set; }
    }
}