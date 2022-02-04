namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'02e2b385-7f52-47bc-9cea-96e8dee78e2c', N'admin@gmail.com', 0, N'AKqx03IIiCXkzTgrFw6imuL1pDMh6kVWA1Ie5NId79eaX8lPLnZdtV2K6Ff1l/zUtg==', N'7a4a182a-5bf6-42d3-9204-4e4b0871f9c1', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'952eeccd-dcb9-4d6a-a627-bbf6f87fa1f3', N'guest@gmail.com', 0, N'AO4trHoLM2bIr91ki0m5nvspr8eN81wgZwzweNngegPtZ7YvE/xe6zGjQ2LuUPQc9w==', N'72bcb9e6-63d1-430c-beef-aa0c8faedec6', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'baea7299-cdd1-4bb1-9043-78a25a76a01d', N'sashotatarski@gmail.com', 0, N'AHxlHiqkG/rJg3+L0uDSfrPQThofxCGT4X1vOxAW6YRTXQHbbFw+TaiyxyraQdPbsg==', N'9ef60a7c-6ee5-4179-9153-2c30649cd9f0', NULL, 0, 0, NULL, 1, 0, N'sashotatarski@gmail.com')
  
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3a95df17-c434-438d-b3ec-4a18583cbc25', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'02e2b385-7f52-47bc-9cea-96e8dee78e2c', N'3a95df17-c434-438d-b3ec-4a18583cbc25')

            ");
        }

        public override void Down()
        {
        }
    }
}
