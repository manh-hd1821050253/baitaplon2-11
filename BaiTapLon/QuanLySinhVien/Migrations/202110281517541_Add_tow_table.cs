namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_tow_table : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Student", newName: "Students");
            DropPrimaryKey("dbo.Students");
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        MALOPHOC = c.String(nullable: false, maxLength: 128, unicode: false),
                        TENLOPHOC = c.String(),
                    })
                .PrimaryKey(t => t.MALOPHOC);
            
            AddColumn("dbo.Students", "IDstudent", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Students", "NameStudent", c => c.String(nullable: false, maxLength: 30));
            AddPrimaryKey("dbo.Students", "IDstudent");
            DropColumn("dbo.Students", "MSV");
            DropColumn("dbo.Students", "TenSV");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "TenSV", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Students", "MSV", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Students");
            DropColumn("dbo.Students", "NameStudent");
            DropColumn("dbo.Students", "IDstudent");
            DropTable("dbo.LopHoc");
            AddPrimaryKey("dbo.Students", "MSV");
            RenameTable(name: "dbo.Students", newName: "Student");
        }
    }
}
