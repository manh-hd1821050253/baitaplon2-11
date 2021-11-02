﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string IDstudent { get; set; }
        [Required]
        [StringLength(30)]
        public string NameStudent { get; set; }
    }
}