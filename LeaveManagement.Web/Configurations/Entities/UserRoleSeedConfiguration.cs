using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",    //random
                    UserId = "7ac42476-a1c5-4bee-9f62-78476c2140cb"     //admin@localhost.com
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",    //random
                    UserId = "cf247ace-7823-4c14-bbd1-11df3484a2ff"     //admin@test.com
                }
            );
        }
    }
}