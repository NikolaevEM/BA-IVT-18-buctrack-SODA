namespace PE1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BugType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusBug",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bug", "BugType_Id", c => c.Int());
            AddColumn("dbo.Bug", "Status_Id", c => c.Int());
            CreateIndex("dbo.Bug", "BugType_Id");
            CreateIndex("dbo.Bug", "Status_Id");
            AddForeignKey("dbo.Bug", "BugType_Id", "dbo.BugType", "Id");
            AddForeignKey("dbo.Bug", "Status_Id", "dbo.StatusBug", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bug", "Status_Id", "dbo.StatusBug");
            DropForeignKey("dbo.Bug", "BugType_Id", "dbo.BugType");
            DropIndex("dbo.Bug", new[] { "Status_Id" });
            DropIndex("dbo.Bug", new[] { "BugType_Id" });
            DropColumn("dbo.Bug", "Status_Id");
            DropColumn("dbo.Bug", "BugType_Id");
            DropTable("dbo.StatusBug");
            DropTable("dbo.BugType");
        }
    }
}
