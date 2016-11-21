namespace TaskManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignment",
                c => new
                    {
                        Assignment_Id = c.Int(nullable: false, identity: true),
                        Assignment_Name = c.String(),
                        Client = c.String(),
                        Percentage = c.String(),
                        Start_date = c.DateTime(nullable: false),
                        End_date = c.DateTime(nullable: false),
                        Comment = c.String(),
                        Consultant_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Assignment_Id)
                .ForeignKey("dbo.Consultant", t => t.Consultant_Id, cascadeDelete: true)
                .Index(t => t.Consultant_Id);
            
            CreateTable(
                "dbo.Consultant",
                c => new
                    {
                        Consultant_Id = c.Int(nullable: false, identity: true),
                        Consultant_Name = c.String(),
                    })
                .PrimaryKey(t => t.Consultant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignment", "Consultant_Id", "dbo.Consultant");
            DropIndex("dbo.Assignment", new[] { "Consultant_Id" });
            DropTable("dbo.Consultant");
            DropTable("dbo.Assignment");
        }
    }
}
