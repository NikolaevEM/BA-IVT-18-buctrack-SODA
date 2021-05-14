namespace PE1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeDivisionLink : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employee", name: "Division_Id", newName: "DivisionId");
            RenameIndex(table: "dbo.Employee", name: "IX_Division_Id", newName: "IX_DivisionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employee", name: "IX_DivisionId", newName: "IX_Division_Id");
            RenameColumn(table: "dbo.Employee", name: "DivisionId", newName: "Division_Id");
        }
    }
}
