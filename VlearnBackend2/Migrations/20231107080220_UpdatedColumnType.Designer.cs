﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VlearnBackend2.Contexts;

#nullable disable

namespace VlearnBackend2.Migrations
{
    [DbContext(typeof(PlataformaContext))]
    [Migration("20231107080220_UpdatedColumnType")]
    partial class UpdatedColumnType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VlearnBackend2.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Telefoneid")
                        .HasColumnType("int");

                    b.Property<string>("TipoPcd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.HasIndex("Telefoneid");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("preco")
                        .HasColumnType("float");

                    b.Property<int?>("professorid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("professorid");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("experiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idiomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("loginId")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("telefoneid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("loginId");

                    b.HasIndex("telefoneid");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Telefone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ddd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ddi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nr_telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Aluno", b =>
                {
                    b.HasOne("VlearnBackend2.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId");

                    b.HasOne("VlearnBackend2.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("Telefoneid");

                    b.Navigation("Login");

                    b.Navigation("Telefone");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Curso", b =>
                {
                    b.HasOne("VlearnBackend2.Models.Professor", "professor")
                        .WithMany()
                        .HasForeignKey("professorid");

                    b.Navigation("professor");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Professor", b =>
                {
                    b.HasOne("VlearnBackend2.Models.Login", "login")
                        .WithMany()
                        .HasForeignKey("loginId");

                    b.HasOne("VlearnBackend2.Models.Telefone", "telefone")
                        .WithMany()
                        .HasForeignKey("telefoneid");

                    b.Navigation("login");

                    b.Navigation("telefone");
                });
#pragma warning restore 612, 618
        }
    }
}
