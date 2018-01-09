namespace Registrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayAtDaddyWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNumber = c.String(),
                        IDNumber = c.String(),
                        ChildName = c.String(),
                        ChildAge = c.Int(nullable: false),
                        ChildGender = c.Int(nullable: false),
                        ChildSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DayAtDaddyWorks");
        }
    }
}
