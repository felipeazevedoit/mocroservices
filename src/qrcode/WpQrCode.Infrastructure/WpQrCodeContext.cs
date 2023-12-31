﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpQrCode.Entities;

namespace WpQrCode.Infrastructure
{
    public class WpQrCodeContext : DbContext
    {
        public DbSet<Token> Tokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WebPixQrCodes;Trusted_Connection=True;Integrated Security=True;");
            //optionsBuilder.UseSqlServer(@"Data Source=179.188.38.126,9000;Initial Catalog=WebPixQrCodes;Persist Security Info=True;User ID=sa;Password=WebPix@2020;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Token>(tk => 
            {
                tk.Property(t => t.Descricao).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Token>().Property(typeof(string), "_salt").IsRequired();
            //modelBuilder.Entity<Token>().Property(typeof(TimeSpan), "ExpirationTime").IsRequired(false);
        }
    }
}
