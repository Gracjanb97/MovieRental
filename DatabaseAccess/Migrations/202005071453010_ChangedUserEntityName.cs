namespace DatabaseAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedUserEntityName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "UserProfiles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserProfiles", newName: "Users");
        }
    }
}
