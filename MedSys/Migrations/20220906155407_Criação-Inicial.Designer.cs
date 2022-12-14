// <auto-generated />
using MedSys.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedSys.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220906155407_Criação-Inicial")]
    partial class CriaçãoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MedSys.Models.Fabricantes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeFabricante");

                    b.Property<int>("Registro")
                        .HasColumnType("int")
                        .HasColumnName("NumeroRegistro");

                    b.Property<string>("Sede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Sede");

                    b.HasKey("Id");

                    b.ToTable("Fabricantes");
                });

            modelBuilder.Entity("MedSys.Models.Medicamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LoteMedicamento")
                        .HasColumnType("int")
                        .HasColumnName("LoteMedicamento");

                    b.Property<string>("NomeMedicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeMedicamento");

                    b.Property<string>("TipoMedicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoMedicamento");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("MedSys.Models.Reacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Reacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoReacao");

                    b.HasKey("Id");

                    b.ToTable("Reações");
                });
#pragma warning restore 612, 618
        }
    }
}
