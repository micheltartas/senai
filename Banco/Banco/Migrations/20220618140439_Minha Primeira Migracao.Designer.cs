﻿// <auto-generated />
using System;
using Banco.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Banco.Migrations
{
    [DbContext(typeof(SenaiContext))]
    [Migration("20220618140439_Minha Primeira Migracao")]
    partial class MinhaPrimeiraMigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Banco.Entidades.Aluno", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ClasseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Banco.Entidades.Classe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProfessorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Serie")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.HasIndex("ProfessorId")
                        .IsUnique();

                    b.ToTable("Classe");
                });

            modelBuilder.Entity("Banco.Entidades.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Cidade")
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Rua")
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Banco.Entidades.Escola", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("Banco.Entidades.Professor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("Banco.Entidades.Aluno", b =>
                {
                    b.HasOne("Banco.Entidades.Classe", "Classe")
                        .WithMany("Alunos")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("Banco.Entidades.Classe", b =>
                {
                    b.HasOne("Banco.Entidades.Escola", "Escola")
                        .WithMany("Classes")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Banco.Entidades.Professor", "Professor")
                        .WithOne("Classe")
                        .HasForeignKey("Banco.Entidades.Classe", "ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Banco.Entidades.Endereco", b =>
                {
                    b.HasOne("Banco.Entidades.Escola", "Escola")
                        .WithOne("Endereco")
                        .HasForeignKey("Banco.Entidades.Endereco", "EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");
                });

            modelBuilder.Entity("Banco.Entidades.Professor", b =>
                {
                    b.HasOne("Banco.Entidades.Escola", "Escola")
                        .WithMany("Professores")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");
                });

            modelBuilder.Entity("Banco.Entidades.Classe", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("Banco.Entidades.Escola", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Endereco");

                    b.Navigation("Professores");
                });

            modelBuilder.Entity("Banco.Entidades.Professor", b =>
                {
                    b.Navigation("Classe");
                });
#pragma warning restore 612, 618
        }
    }
}
