namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertNameAtMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'annual' WHERE Id = 4");

        }

        public override void Down()
        {
        }
    }
}
