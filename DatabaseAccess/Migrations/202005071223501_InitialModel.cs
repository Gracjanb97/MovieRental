namespace DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        FirstName = c.String(nullable: false, maxLength: 64, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 64, unicode: false),
                        Balance = c.Decimal(storeType: "smallmoney"),
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 32),
                        Email = c.String(nullable: false, maxLength: 64),
                        Password = c.String(nullable: false, maxLength: 512),
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideoRentals",
                c => new
                    {
                        DateCreated = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        DateStart = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        DateEnd = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Price = c.Decimal(nullable: false, storeType: "smallmoney"),
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        Category = c.String(maxLength: 64),
                        ProductionYear = c.Int(),
                        Description = c.String(storeType: "ntext"),
                        Id = c.Int(nullable: false, identity: true),
                        PricePerDay = c.Decimal(nullable: false, storeType: "smallmoney"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
        }
    }
}
