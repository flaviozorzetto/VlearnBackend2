﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VlearnBackend2.Contexts;

#nullable disable

namespace VlearnBackend2.Migrations
{
    [DbContext(typeof(PlataformaContext))]
    partial class PlataformaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("TelefoneId")
                        .HasColumnType("int");

                    b.Property<string>("TipoPcd")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tipo_pcd");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("TABLE_VLEARN_ALUNO");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("TABLE_VLEARN_CURSO");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TABLE_VLEARN_LOGIN");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Experiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Formacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idiomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TelefoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("TABLE_VLEARN_PROFESSOR");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ddd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ddi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nr_telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TABLE_VLEARN_TELEFONE");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Aluno", b =>
                {
                    b.HasOne("VlearnBackend2.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId");

                    b.HasOne("VlearnBackend2.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");

                    b.Navigation("Login");

                    b.Navigation("Telefone");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Curso", b =>
                {
                    b.HasOne("VlearnBackend2.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("VlearnBackend2.Models.Professor", b =>
                {
                    b.HasOne("VlearnBackend2.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId");

                    b.HasOne("VlearnBackend2.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");

                    b.Navigation("Login");

                    b.Navigation("Telefone");
                });
#pragma warning restore 612, 618
        }
    }
}
