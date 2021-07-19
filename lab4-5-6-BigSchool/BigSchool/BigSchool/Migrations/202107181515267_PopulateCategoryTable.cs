namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories (Id, Name) Values (1,'Devenlopment')");
            Sql("Insert into Categories (Id, Name) Values (2,'Business')");
            Sql("Insert into Categories (Id, Name) Values (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
