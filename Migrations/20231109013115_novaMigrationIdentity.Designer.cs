﻿// <auto-generated />
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POSTO_ERP.Models;

#nullable disable

namespace POSTO_ERP.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231109013115_novaMigrationIdentity")]
    partial class novaMigrationIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 31);

            modelBuilder.Entity("POSTO_ERP.Models.CLIENTES", b =>
                {
                    b.Property<string>("CNPJ_CPF")
                        .HasColumnType("VARCHAR(256)")
                        .HasColumnName("CNPJ_CPF");

                    b.Property<int>("CODIGO")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CLIENTES");

                    b.HasKey("CNPJ_CPF");

                    b.ToTable("CLIENTES");
                });
#pragma warning restore 612, 618
        }
    }
}