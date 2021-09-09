using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpeedTypingASP.Domain.Entities;

namespace SpeedTypingASP.Domain
{
    public class ApplicationDbContext: IdentityDbContext<UserInformation>
    {
        private static ApplicationDbContext _applicationDbContext;

        public static ApplicationDbContext GetDbContext()
        {
            if (_applicationDbContext == null)
                throw new Exception("Не определен контекст базы данных");
            return _applicationDbContext;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            _applicationDbContext = this;
        }

        public DbSet<Text> Texts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //admin role and user
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "dc086066-451d-4cb1-a1ad-933352eb82b4",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<UserInformation>().HasData(new UserInformation
            {
                Id = "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                UserName = "Matvey",
                NormalizedUserName = "MATVEY",
                Email = "zenoteper@icloud.com",
                NormalizedEmail = "ZENOTEPER@ICLOUD.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<UserInformation>().HashPassword(null, "psqwer"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "215eedc8-7e86-46f6-88dc-6b052c4ed7b0",
                RoleId = "dc086066-451d-4cb1-a1ad-933352eb82b4"
            });

            //just user
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "d4dad604-45e4-4ee7-b7b1-697bf7a623b2",
                Name = "user",
                NormalizedName = "USER"
            });
            builder.Entity<UserInformation>().HasData(new UserInformation
            {
                Id = "f294e833-15e9-4066-8b41-61847ff6f0f7",
                UserName = "someUser",
                NormalizedUserName = "SOMEUSER",
                Email = "someuser@email.com",
                NormalizedEmail = "SOMEUSER@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<UserInformation>().HashPassword(null, "somepsqwer"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "f294e833-15e9-4066-8b41-61847ff6f0f7",
                RoleId = "d4dad604-45e4-4ee7-b7b1-697bf7a623b2"
            });

            //other
            builder.Entity<Text>().HasData(new Text
            {
                Id = "85e25f52-3cff-4722-9904-82f47ae98462",
                Title = "Lorem Ipsum",
                TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam felis quam, ornare efficitur dictum sit amet, rutrum sed nisl. Vestibulum dolor augue, hendrerit sed dolor posuere, egestas porta metus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam tortor risus, cursus id laoreet non, cursus in."
            });
        }
    }
}
