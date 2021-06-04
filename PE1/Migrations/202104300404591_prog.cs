namespace PE1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bugs",
                c => new
                    {
                        BugId = c.Int(nullable: false, identity: true),
                        BugTypeId = c.Int(nullable: false),
                        Description = c.String(),
                        LastFixedDate = c.DateTime(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        StatusBugId = c.Int(nullable: false),
                        DivisionId = c.Int(),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.BugId)
                .ForeignKey("dbo.BugTypes", t => t.BugTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.Divisions", t => t.DivisionId)
                .ForeignKey("dbo.StatusBugs", t => t.StatusBugId, cascadeDelete: true)
                .Index(t => t.BugTypeId)
                .Index(t => t.StatusBugId)
                .Index(t => t.DivisionId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.BugTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bugType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Annotations = c.String(),
                        EmployeeId = c.Int(),
                        BugId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bugs", t => t.BugId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId)
                .Index(t => t.BugId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Login = c.String(),
                        DivisionId = c.Int(),
                        PositionEmployeeId = c.Int(),
                        StatusEmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Divisions", t => t.DivisionId)
                .ForeignKey("dbo.PositionEmployees", t => t.PositionEmployeeId)
                .ForeignKey("dbo.StatusEmployees", t => t.StatusEmployeeId)
                .Index(t => t.DivisionId)
                .Index(t => t.PositionEmployeeId)
                .Index(t => t.StatusEmployeeId);
            
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fixes",
                c => new
                    {
                        FixId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Rank = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BugId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FixId)
                .ForeignKey("dbo.Bugs", t => t.BugId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.BugId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.PositionEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusBugs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bugs", "StatusBugId", "dbo.StatusBugs");
            DropForeignKey("dbo.Comments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "StatusEmployeeId", "dbo.StatusEmployees");
            DropForeignKey("dbo.Employees", "PositionEmployeeId", "dbo.PositionEmployees");
            DropForeignKey("dbo.Fixes", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Fixes", "BugId", "dbo.Bugs");
            DropForeignKey("dbo.Employees", "DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.Bugs", "DivisionId", "dbo.Divisions");
            DropForeignKey("dbo.Bugs", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Comments", "BugId", "dbo.Bugs");
            DropForeignKey("dbo.Bugs", "BugTypeId", "dbo.BugTypes");
            DropIndex("dbo.Fixes", new[] { "EmployeeId" });
            DropIndex("dbo.Fixes", new[] { "BugId" });
            DropIndex("dbo.Employees", new[] { "StatusEmployeeId" });
            DropIndex("dbo.Employees", new[] { "PositionEmployeeId" });
            DropIndex("dbo.Employees", new[] { "DivisionId" });
            DropIndex("dbo.Comments", new[] { "BugId" });
            DropIndex("dbo.Comments", new[] { "EmployeeId" });
            DropIndex("dbo.Bugs", new[] { "EmployeeId" });
            DropIndex("dbo.Bugs", new[] { "DivisionId" });
            DropIndex("dbo.Bugs", new[] { "StatusBugId" });
            DropIndex("dbo.Bugs", new[] { "BugTypeId" });
            DropTable("dbo.Procedures");
            DropTable("dbo.StatusBugs");
            DropTable("dbo.StatusEmployees");
            DropTable("dbo.PositionEmployees");
            DropTable("dbo.Fixes");
            DropTable("dbo.Divisions");
            DropTable("dbo.Employees");
            DropTable("dbo.Comments");
            DropTable("dbo.BugTypes");
            DropTable("dbo.Bugs");
        }
    }
}
