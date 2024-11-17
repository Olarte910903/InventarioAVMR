﻿// <auto-generated />
using System;
using InventarioAVMR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventarioAVMR.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("InventarioAVMR.Models.Bordado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdColores")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Bordados");
                });

            modelBuilder.Entity("InventarioAVMR.Models.BordadoHilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BordadoId")
                        .HasColumnType("int");

                    b.Property<int>("ColorHiloId")
                        .HasColumnType("int");

                    b.Property<int>("IdBordado")
                        .HasColumnType("int");

                    b.Property<int>("IdHilo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BordadoId");

                    b.HasIndex("ColorHiloId");

                    b.ToTable("BordadoHilos");
                });

            modelBuilder.Entity("InventarioAVMR.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("InventarioAVMR.Models.ColorHilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ColorHiloId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ColorHiloId");

                    b.ToTable("ColorHilos");
                });

            modelBuilder.Entity("InventarioAVMR.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("InventarioAVMR.Models.TrabajoRealizado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("TrabajosRealizados");
                });

            modelBuilder.Entity("ItemTrabajoRealizado", b =>
                {
                    b.Property<int>("ItemsUtilizadosId")
                        .HasColumnType("int");

                    b.Property<int>("TrabajosRealizadosId")
                        .HasColumnType("int");

                    b.HasKey("ItemsUtilizadosId", "TrabajosRealizadosId");

                    b.HasIndex("TrabajosRealizadosId");

                    b.ToTable("ItemTrabajoRealizado");
                });

            modelBuilder.Entity("InventarioAVMR.Models.BordadoHilo", b =>
                {
                    b.HasOne("InventarioAVMR.Models.Bordado", "Bordado")
                        .WithMany("BordadoHilo")
                        .HasForeignKey("BordadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventarioAVMR.Models.ColorHilo", "ColorHilo")
                        .WithMany()
                        .HasForeignKey("ColorHiloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bordado");

                    b.Navigation("ColorHilo");
                });

            modelBuilder.Entity("InventarioAVMR.Models.ColorHilo", b =>
                {
                    b.HasOne("InventarioAVMR.Models.ColorHilo", null)
                        .WithMany("ColorHilos")
                        .HasForeignKey("ColorHiloId");
                });

            modelBuilder.Entity("InventarioAVMR.Models.TrabajoRealizado", b =>
                {
                    b.HasOne("InventarioAVMR.Models.Cliente", "Cliente")
                        .WithMany("TrabajosRealizados")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ItemTrabajoRealizado", b =>
                {
                    b.HasOne("InventarioAVMR.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsUtilizadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventarioAVMR.Models.TrabajoRealizado", null)
                        .WithMany()
                        .HasForeignKey("TrabajosRealizadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InventarioAVMR.Models.Bordado", b =>
                {
                    b.Navigation("BordadoHilo");
                });

            modelBuilder.Entity("InventarioAVMR.Models.Cliente", b =>
                {
                    b.Navigation("TrabajosRealizados");
                });

            modelBuilder.Entity("InventarioAVMR.Models.ColorHilo", b =>
                {
                    b.Navigation("ColorHilos");
                });
#pragma warning restore 612, 618
        }
    }
}
