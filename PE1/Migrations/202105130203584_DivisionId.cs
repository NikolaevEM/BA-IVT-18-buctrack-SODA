namespace PE1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DivisionId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "Name", "dbo.Division");
            DropForeignKey("dbo.Bug", "Division_Name", "dbo.Division");
            DropIndex("dbo.Bug", new[] { "Division_Name" });
            DropIndex("dbo.Employee", new[] { "Name" });
            RenameColumn(table: "dbo.Bug", name: "Division_Name", newName: "Division_Id");
            DropPrimaryKey("dbo.Division");
            AddColumn("dbo.Employee", "Division_Id", c => c.Int());
            AddColumn("dbo.Division", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Bug", "Division_Id", c => c.Int());
            AlterColumn("dbo.Employee", "Name", c => c.String());
            AlterColumn("dbo.Division", "Name", c => c.String());
            AddPrimaryKey("dbo.Division", "Id");
            CreateIndex("dbo.Bug", "Division_Id");
            CreateIndex("dbo.Employee", "Division_Id");
            AddForeignKey("dbo.Employee", "Division_Id", "dbo.Division", "Id");
            AddForeignKey("dbo.Bug", "Division_Id", "dbo.Division", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bug", "Division_Id", "dbo.Division");
            DropForeignKey("dbo.Employee", "Division_Id", "dbo.Division");
            DropIndex("dbo.Employee", new[] { "Division_Id" });
            DropIndex("dbo.Bug", new[] { "Division_Id" });
            DropPrimaryKey("dbo.Division");
            AlterColumn("dbo.Division", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Employee", "Name", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bug", "Division_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Division", "Id");
            DropColumn("dbo.Employee", "Division_Id");
            AddPrimaryKey("dbo.Division", "Name");
            RenameColumn(table: "dbo.Bug", name: "Division_Id", newName: "Division_Name");
            CreateIndex("dbo.Employee", "Name");
            CreateIndex("dbo.Bug", "Division_Name");
            AddForeignKey("dbo.Bug", "Division_Name", "dbo.Division", "Name");
            AddForeignKey("dbo.Employee", "Name", "dbo.Division", "Name");
        }
    }
}
