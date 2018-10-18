namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'072f3cd3-ddd5-4caf-ac81-f4e7b03d7086', N'guest@vidly.com', 0, N'AK+aQSg++0iUe10MzdZeanDJ4sclAcRflTh8w8SfZxdyGwF1KoGDRtOmG7gR50qWPw==', N'c5c03705-5246-4212-b542-31875a03819a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b2bc5e68-ec7b-4cc9-a326-3710858f31b9', N'admin@vidly.com', 0, N'AG2jEINZnLyrNLKfi2j9KpdyCugBEBEngGtVTSIIZ8jL0cd/WMdO7BVjNAQlXRjsZQ==', N'b7040633-db02-4267-b576-54bc496b4667', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'716ecab6-9e89-4278-b6dc-ea8fdf7f3aa6', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b2bc5e68-ec7b-4cc9-a326-3710858f31b9', N'716ecab6-9e89-4278-b6dc-ea8fdf7f3aa6')
");
        }
        
        public override void Down()
        {
        }
    }
}
