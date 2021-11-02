using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class QLSVcontext :  DbContext
    {
        public QLSVcontext() : base("name=DBQUANLYSINHVIEN") 
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // nếu chưa có cái database(nới chứa thông tin duex liệu )
            // Quản Lý sinh Viên thì nó tạo mới còn có rồi thì nó tạo nữa
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LopHoc>().Property(k => k.MALOPHOC).IsUnicode(false);
        }
        public virtual DbSet<Student> Students { set; get; }


    }
}