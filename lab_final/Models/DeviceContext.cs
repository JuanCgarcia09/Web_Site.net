﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_final.Models
{
    public class DeviceContext: DbContext
    {
        public DbSet<Dispositivo> dispositivos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dispositivo>(entity =>
            {


                entity.Property(e => e.dispositivoid).HasColumnName("Dispositivoid");

                entity.Property(e => e.nombre).HasColumnName("Nombre");

                entity.Property(e => e.limite_maximo).HasColumnName("Limite_Maximo");

                entity.Property(e => e.limite_minimo).HasColumnName("Limite_Minimo");

                entity.Property(e => e.medida_actual).HasColumnName("Medida_Actual");
            });

           
        }

    }
}
