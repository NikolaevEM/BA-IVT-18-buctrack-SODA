namespace PE1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Division",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Bug",
                c => new
                    {
                        BugId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        LastFixedDate = c.DateTime(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Division_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BugId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Division", t => t.Division_Name)
                .Index(t => t.EmployeeId)
                .Index(t => t.Division_Name);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentsId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Annotations = c.String(),
                        User = c.String(),
                        BugId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentsId)
                .ForeignKey("dbo.Bug", t => t.BugId, cascadeDelete: true)
                .Index(t => t.BugId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 128),
                        Login = c.String(),
                        PositionEmployeeId = c.Int(nullable: false),
                        StatusEmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.PositionEmployee", t => t.PositionEmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.StatusEmployee", t => t.StatusEmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Division", t => t.Name)
                .Index(t => t.Name)
                .Index(t => t.PositionEmployeeId)
                .Index(t => t.StatusEmployeeId);
            
            CreateTable(
                "dbo.Fix",
                c => new
                    {
                        FixId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Rank = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BugId = c.Int(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FixId)
                .ForeignKey("dbo.Bug", t => t.BugId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.BugId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        ProcedureId = c.Int(nullable: false),
                        EmployeeId = c.Int(),
                        FixId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .ForeignKey("dbo.Fix", t => t.FixId, cascadeDelete: true)
                .ForeignKey("dbo.Procedure", t => t.ProcedureId, cascadeDelete: true)
                .Index(t => t.ProcedureId)
                .Index(t => t.EmployeeId)
                .Index(t => t.FixId);
            
            CreateTable(
                "dbo.Procedure",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusEmployee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "Name", "dbo.Division");
            DropForeignKey("dbo.Bug", "Division_Name", "dbo.Division");
            DropForeignKey("dbo.Employee", "StatusEmployeeId", "dbo.StatusEmployee");
            DropForeignKey("dbo.Employee", "PositionEmployeeId", "dbo.PositionEmployee");
            DropForeignKey("dbo.Log", "ProcedureId", "dbo.Procedure");
            DropForeignKey("dbo.Log", "FixId", "dbo.Fix");
            DropForeignKey("dbo.Log", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Fix", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Fix", "BugId", "dbo.Bug");
            DropForeignKey("dbo.Bug", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Comment", "BugId", "dbo.Bug");
            DropIndex("dbo.Log", new[] { "FixId" });
            DropIndex("dbo.Log", new[] { "EmployeeId" });
            DropIndex("dbo.Log", new[] { "ProcedureId" });
            DropIndex("dbo.Fix", new[] { "EmployeeId" });
            DropIndex("dbo.Fix", new[] { "BugId" });
            DropIndex("dbo.Employee", new[] { "StatusEmployeeId" });
            DropIndex("dbo.Employee", new[] { "PositionEmployeeId" });
            DropIndex("dbo.Employee", new[] { "Name" });
            DropIndex("dbo.Comment", new[] { "BugId" });
            DropIndex("dbo.Bug", new[] { "Division_Name" });
            DropIndex("dbo.Bug", new[] { "EmployeeId" });
            DropTable("dbo.StatusEmployee");
            DropTable("dbo.Procedure");
            DropTable("dbo.Log");
            DropTable("dbo.Fix");
            DropTable("dbo.Employee");
            DropTable("dbo.Comment");
            DropTable("dbo.Bug");
            DropTable("dbo.Division");
        }
    }
}
