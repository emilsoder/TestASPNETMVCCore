using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test3.Models;

namespace Test3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<string>, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ShoppingCarts> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartDetails> ShoppingCartDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(e => e.ToTable("Users").HasKey(x => x.Id));
            builder.Entity<IdentityRole<string>>(e => e.ToTable("Roles").HasKey(x => x.Id));
            builder.Entity<IdentityUserRole<string>>(e => e.ToTable("UserRoles").HasKey(x => x.RoleId));

            builder.Entity<IdentityRoleClaim<string>>(e => e.ToTable("RoleClaim").HasKey(x => x.Id));
            builder.Entity<IdentityUserLogin<string>>(e => e.ToTable("UserLogin").HasKey(x => x.UserId));
            builder.Entity<IdentityUserClaim<string>>(e => e.ToTable("UserClaims").HasKey(x => x.Id));
            builder.Entity<IdentityUserToken<string>>(e => e.ToTable("UserTokens").HasKey(x => x.UserId));

            builder.Entity<Products>(e => e.ToTable("Products").HasKey(x => x.ProductID));
            builder.Entity<Categories>(e => e.ToTable("Categories").HasKey(x => x.CategoryID));
            builder.Entity<Customers>(e => e.ToTable("Customers").HasKey(x => x.CustomerID));
            builder.Entity<ShoppingCarts>(e => e.ToTable("ShoppingCarts").HasKey(x => x.ShoppingCartID));
            
        }
    }
}
