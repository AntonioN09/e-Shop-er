﻿using EShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //create database context
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Acquisition> Acquisitions { get; set; } 

        //add relations to database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //One user may have many notifications
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Notifications)
                .WithOne(n => n.User);

            //One user must have a history
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.History)
                .WithOne(h => h.User)
                .HasForeignKey<History>(h => h.UserId);

            //One user must have a cart
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId);

            //One user may have many acquisitions
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Acquisitions)
                .WithOne(a => a.User);

            //One cart may contain orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cart)
                .WithMany(c => c.Orders);

            //One product may have many orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders);

            //One category may have many products
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);
        }

    }
}