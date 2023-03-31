namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'072dcb02-48e3-449f-b2de-e2279512d558', N'admin@vidly.com', 0, N'AFvB2DMoePeeFPBFNf/vvinw3Sj6Byq51IkQMdMtJTuQxDElQ5+V9j36qcV4fS4ezQ==', N'afa0e396-423e-45e3-b43e-f0d554345851', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9cd953ca-bfcf-4234-8c98-4a179d4bb7ba', N'zaaza1233@gmail.com', 0, N'APPe+w6d/OyCJ2cHqExsSulIdow5iTnvSRn4fa7jBwj+NkZay2Eg5CKG60RDDKxqXw==', N'309e79a2-9bae-40ff-99df-7165a5a0b77c', NULL, 0, 0, NULL, 1, 0, N'zaaza1233@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc4ce644-9af5-4b27-bdef-c830ad3d3c5a', N'guest@vidly.com', 0, N'AISa0Ksdrtzrdt1LVBhV1p488EU8bJUFVcEBpFLDHS28fM+/q3FC3TjNfimzsszENg==', N'86b5c920-6fdd-4f1f-9621-d50eff224043', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd933ad7a-7a98-4a40-806e-cc254579ddb0', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'072dcb02-48e3-449f-b2de-e2279512d558', N'd933ad7a-7a98-4a40-806e-cc254579ddb0')
");
        }

        public override void Down()
        {
        }
    }
}
