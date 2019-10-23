namespace BAGA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ActivityId);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Identifier = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CostUSD = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Identifier);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Description = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Lodgings",
                c => new
                    {
                        LodgingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Owner = c.String(),
                        IsResort = c.Boolean(nullable: false),
                        Destination_DestinationId = c.Int(),
                    })
                .PrimaryKey(t => t.LodgingId)
                .ForeignKey("dbo.Destinations", t => t.Destination_DestinationId)
                .Index(t => t.Destination_DestinationId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        SocialSecurityNumber = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.PersonPhotoes",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        Photo = c.Binary(),
                        Caption = c.String(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.TripActivities",
                c => new
                    {
                        Trip_Identifier = c.Guid(nullable: false),
                        Activity_ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trip_Identifier, t.Activity_ActivityId })
                .ForeignKey("dbo.Trips", t => t.Trip_Identifier, cascadeDelete: true)
                .ForeignKey("dbo.Activities", t => t.Activity_ActivityId, cascadeDelete: true)
                .Index(t => t.Trip_Identifier)
                .Index(t => t.Activity_ActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonPhotoes", "PersonId", "dbo.People");
            DropForeignKey("dbo.Lodgings", "Destination_DestinationId", "dbo.Destinations");
            DropForeignKey("dbo.TripActivities", "Activity_ActivityId", "dbo.Activities");
            DropForeignKey("dbo.TripActivities", "Trip_Identifier", "dbo.Trips");
            DropIndex("dbo.TripActivities", new[] { "Activity_ActivityId" });
            DropIndex("dbo.TripActivities", new[] { "Trip_Identifier" });
            DropIndex("dbo.PersonPhotoes", new[] { "PersonId" });
            DropIndex("dbo.Lodgings", new[] { "Destination_DestinationId" });
            DropTable("dbo.TripActivities");
            DropTable("dbo.PersonPhotoes");
            DropTable("dbo.People");
            DropTable("dbo.Lodgings");
            DropTable("dbo.Destinations");
            DropTable("dbo.Trips");
            DropTable("dbo.Activities");
        }
    }
}
