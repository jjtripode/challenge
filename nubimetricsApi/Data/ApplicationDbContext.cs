using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using nubimetricsApi.Models;

namespace nubimetricsApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>()
            .HasData( new Usuario {
                 Nombre  ="Nombre   1"                   
                ,Apellido="Apellido 1"
                ,Email   ="Email    1"
                ,Password="Password 1"
                                    });

            builder.Entity<Usuario>()
            .HasData( new Usuario {
                 Nombre  ="Nombre  2"                   
                ,Apellido="Apellido2"
                ,Email   ="Email   2"
                ,Password="Password2"
                                    }); 

             builder.Entity<Usuario>()
            .HasData( new Usuario {
                 Nombre  ="Nombre  3"                   
                ,Apellido="Apellido3"
                ,Email   ="Email   3"
                ,Password="Password3"
                                    });  

            builder.Entity<Usuario>()
            .HasData( new Usuario {
                 Nombre  ="Nombre  4"                   
                ,Apellido="Apellido4"
                ,Email   ="Email   4"
                ,Password="Password4"
                                    });                                                                                 

        }
    }
}
