﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Models
{
    public partial class BDNOTAS2023okContext : DbContext
    {
        public BDNOTAS2023okContext()
        {
        }

        public BDNOTAS2023okContext(DbContextOptions<BDNOTAS2023okContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }


        public virtual DbSet<PA_PAGOS_ALUMNO> PA_PAGOS_ALUMNO { get; set; }
        

        public virtual DbSet<PA_UPDATE_CUOTA> PA_UPDATE_CUOTA { get; set; }

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-ANDRES\\SQLEXPRESS;Initial Catalog=BDNOTAS2023ok;User ID=sa;Password=62845;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.Codalumno)
                    .HasName("PK__ALUMNOS__0880F8B33DCEA622");

                entity.ToTable("ALUMNOS");

                entity.Property(e => e.Codalumno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codalumno")
                    .IsFixedLength(true);

                entity.Property(e => e.Apealumno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apealumno");

                entity.Property(e => e.Codesp)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("codesp")
                    .IsFixedLength(true);

                entity.Property(e => e.Colegio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("colegio")
                    .HasDefaultValueSql("('Sin Nombre')");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("eliminado")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Nomalumno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomalumno");

                entity.HasOne(d => d.CodespNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.Codesp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ALUMNOS__codesp__267ABA7A");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Codcurso)
                    .HasName("PK__CURSOS__A41031C2588B0CA2");

                entity.ToTable("CURSOS");

                entity.Property(e => e.Codcurso)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codcurso")
                    .IsFixedLength(true);

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("eliminado")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Nhoras).HasColumnName("nhoras");

                entity.Property(e => e.Nomcurso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomcurso");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tipo")
                    .HasDefaultValueSql("('P')");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.Codesp)
                    .HasName("PK__ESPECIAL__47FE74D3C0BFB75A");

                entity.ToTable("ESPECIALIDAD");

                entity.Property(e => e.Codesp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("codesp")
                    .IsFixedLength(true);

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("eliminado")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Nomesp)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomesp");
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.HasKey(e => e.Nroreg)
                    .HasName("PK__NOTAS__5DCAECD3FFB58D55");

                entity.ToTable("NOTAS");

                entity.HasIndex(e => new { e.Codalumno, e.Codcurso, e.Semestre }, "unique_Notas")
                    .IsUnique();

                entity.Property(e => e.Nroreg).HasColumnName("nroreg");

                entity.Property(e => e.Codalumno)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codalumno")
                    .IsFixedLength(true);

                entity.Property(e => e.Codcurso)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codcurso")
                    .IsFixedLength(true);

                entity.Property(e => e.Eliminado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("eliminado")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Fechareg)
                    .HasColumnType("datetime")
                    .HasColumnName("fechareg");

                entity.Property(e => e.Nfinal).HasColumnName("nfinal");

                entity.Property(e => e.Nparcial).HasColumnName("nparcial");

                entity.Property(e => e.Ntrabajo).HasColumnName("ntrabajo");

                entity.Property(e => e.Semestre)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("semestre")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodalumnoNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.Codalumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTAS__codalumno__34C8D9D1");

                entity.HasOne(d => d.CodcursoNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.Codcurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTAS__codcurso__35BCFE0A");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.Codpago)
                    .HasName("PK__PAGOS__9221D33B1F22A08E");

                entity.ToTable("PAGOS");

                entity.HasIndex(e => new { e.Codalumno, e.Semestre, e.Ncuota }, "unique_Pagos")
                    .IsUnique();

                entity.Property(e => e.Codpago).HasColumnName("codpago");

                entity.Property(e => e.Codalumno)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codalumno")
                    .IsFixedLength(true);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Ncuota).HasColumnName("ncuota");

                entity.Property(e => e.Pagado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("pagado")
                    .HasDefaultValueSql("('No')")
                    .IsFixedLength(true);

                entity.Property(e => e.Semestre)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("semestre")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodalumnoNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.Codalumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAGOS__codalumno__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

    
  
}
