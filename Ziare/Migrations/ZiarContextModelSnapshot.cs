﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ziare.Data;

#nullable disable

namespace Ziare.Migrations
{
    [DbContext(typeof(ZiarContext))]
    partial class ZiarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ziare.Models.Articol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZiarId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZiarId");

                    b.ToTable("Articole");
                });

            modelBuilder.Entity("Ziare.Models.Biblioteca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Biblioteci");
                });

            modelBuilder.Entity("Ziare.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Bani")
                        .HasColumnType("int");

                    b.Property<Guid?>("BibliotecaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BibliotecaId")
                        .IsUnique()
                        .HasFilter("[BibliotecaId] IS NOT NULL");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Ziare.Models.Editor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Editura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Editori");
                });

            modelBuilder.Entity("Ziare.Models.Ziar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Domeniu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pret")
                        .HasColumnType("int");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ziare");
                });

            modelBuilder.Entity("Ziare.Models.ZiarBibliotecaRelation", b =>
                {
                    b.Property<Guid>("ZiarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BibliotecaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ZiarId", "BibliotecaId");

                    b.HasIndex("BibliotecaId");

                    b.ToTable("ZiarBibliotecaRelation");
                });

            modelBuilder.Entity("Ziare.Models.ZiarEditorRelation", b =>
                {
                    b.Property<Guid>("ZiarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EditorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ZiarId", "EditorId");

                    b.HasIndex("EditorId");

                    b.ToTable("ZiarEditorRelation");
                });

            modelBuilder.Entity("Ziare.Models.Articol", b =>
                {
                    b.HasOne("Ziare.Models.Ziar", "Ziar")
                        .WithMany("Articole")
                        .HasForeignKey("ZiarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ziar");
                });

            modelBuilder.Entity("Ziare.Models.Client", b =>
                {
                    b.HasOne("Ziare.Models.Biblioteca", "Biblioteca")
                        .WithOne("Client")
                        .HasForeignKey("Ziare.Models.Client", "BibliotecaId");

                    b.Navigation("Biblioteca");
                });

            modelBuilder.Entity("Ziare.Models.ZiarBibliotecaRelation", b =>
                {
                    b.HasOne("Ziare.Models.Biblioteca", "Biblioteca")
                        .WithMany("ZiarBibliotecaRelations")
                        .HasForeignKey("BibliotecaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ziare.Models.Ziar", "Ziar")
                        .WithMany("ZiarBibliotecaRelations")
                        .HasForeignKey("ZiarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Biblioteca");

                    b.Navigation("Ziar");
                });

            modelBuilder.Entity("Ziare.Models.ZiarEditorRelation", b =>
                {
                    b.HasOne("Ziare.Models.Editor", "Editor")
                        .WithMany("ZiarEditorRelations")
                        .HasForeignKey("EditorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ziare.Models.Ziar", "Ziar")
                        .WithMany("ZiarEditorRelations")
                        .HasForeignKey("ZiarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editor");

                    b.Navigation("Ziar");
                });

            modelBuilder.Entity("Ziare.Models.Biblioteca", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();

                    b.Navigation("ZiarBibliotecaRelations");
                });

            modelBuilder.Entity("Ziare.Models.Editor", b =>
                {
                    b.Navigation("ZiarEditorRelations");
                });

            modelBuilder.Entity("Ziare.Models.Ziar", b =>
                {
                    b.Navigation("Articole");

                    b.Navigation("ZiarBibliotecaRelations");

                    b.Navigation("ZiarEditorRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
