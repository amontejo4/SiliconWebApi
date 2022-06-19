﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiliconApi.Data;

namespace SiliconApi.Data.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20220619182241_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiliconApi.Data.Entities.Actividad_Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Actividad_Categorias");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Actividad_Puntuacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Puntuacion")
                        .HasColumnType("real");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("UserId");

                    b.ToTable("Actividad_Puntuaciones");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Disponibilidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.ToTable("Disponibilidades");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Imagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Recurso")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Imagen");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Localizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo_postal")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Localizacions");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastLoggedIn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("AccessTokenExpiresDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RefreshTokenExpiresDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Actividad_Categoria", b =>
                {
                    b.HasOne("SiliconApi.Data.Entities.Imagen", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SiliconApi.Data.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Actividad_Puntuacion", b =>
                {
                    b.HasOne("SiliconApi.Data.Entities.Imagen", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SiliconApi.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Actividad");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Disponibilidad", b =>
                {
                    b.HasOne("SiliconApi.Data.Entities.Imagen", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.Reserva", b =>
                {
                    b.HasOne("SiliconApi.Data.Entities.Imagen", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SiliconApi.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.UserToken", b =>
                {
                    b.HasOne("SiliconApi.Data.Entities.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SiliconApi.Data.Entities.User", b =>
                {
                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
