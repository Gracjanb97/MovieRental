﻿// <auto-generated />
namespace DatabaseAccess.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.0")]
    public sealed partial class AddedRelationshipBetweenVideoAndVideoRental : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddedRelationshipBetweenVideoAndVideoRental));
        
        string IMigrationMetadata.Id
        {
            get { return "202005071303418_AddedRelationshipBetweenVideoAndVideoRental"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}