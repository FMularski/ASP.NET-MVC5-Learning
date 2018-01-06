namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'07df451a-51e1-4c57-9d3f-87641abc221e', N'guest@vidly.com', 0, N'AEoiK1E2cRUvmY8XruXqIC9ra2c2xP7/1MYGK3hbOKRi+akV9eiRqKYbv5+wpz3Bhw==', N'c91fc5b3-e2c3-4247-8739-15e1fb359542', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8ac8f279-3dfb-4b0f-9a72-e973cf0907ef', N'admin@vidly.com', 0, N'AI5OCjKs2jJ0yUrJ/kYuQtC4gGwhVDeyiIPotLWVvrVgfSt8NFhgnfc0B5d14K7RWA==', N'3e3dfa77-9018-4df2-93f7-7ba26926c7b8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'50239725-bad5-490d-86ff-554c5e45f676', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8ac8f279-3dfb-4b0f-9a72-e973cf0907ef', N'50239725-bad5-490d-86ff-554c5e45f676')");
        }
        
        public override void Down()
        {
        }
    }
}
