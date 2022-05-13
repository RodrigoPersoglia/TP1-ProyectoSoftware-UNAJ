﻿// <auto-generated />
using System;
using ConnectionDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConnectionDataBase.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    partial class BibliotecaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Alquileres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cliente_idx")
                        .HasColumnType("int")
                        .HasColumnName("Cliente");

                    b.Property<int>("Estado_idx")
                        .HasColumnType("int")
                        .HasColumnName("Estado");

                    b.Property<DateTime?>("FechaAlquiler")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaAlquiler");

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaDevolucion");

                    b.Property<DateTime?>("FechaReserva")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaReserva");

                    b.Property<string>("Libros_idx")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ISBN");

                    b.HasKey("Id");

                    b.HasIndex("Cliente_idx");

                    b.HasIndex("Estado_idx");

                    b.HasIndex("Libros_idx");

                    b.ToTable("Alquileres", (string)null);
                });

            modelBuilder.Entity("Data.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Apellido");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("DNI");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Nombre");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Data.EstadoDeAlquileres", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Descripcion");

                    b.HasKey("EstadoId");

                    b.ToTable("EstadoDeAlquileres");

                    b.HasData(
                        new
                        {
                            EstadoId = 1,
                            Descripcion = "Reservado"
                        },
                        new
                        {
                            EstadoId = 2,
                            Descripcion = "Alquilado"
                        },
                        new
                        {
                            EstadoId = 3,
                            Descripcion = "Cancelado"
                        });
                });

            modelBuilder.Entity("Data.Libros", b =>
                {
                    b.Property<string>("ISBN")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ISBN");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Autor");

                    b.Property<string>("Edicion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Edicion");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Editorial");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Imagen");

                    b.Property<int?>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("Stock");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Titulo");

                    b.HasKey("ISBN");

                    b.ToTable("Libros", (string)null);

                    b.HasData(
                        new
                        {
                            ISBN = "8445071866",
                            Autor = "Cortazar",
                            Edicion = "1995",
                            Editorial = "Ediciones Minotauro",
                            Imagen = "https://picture/sdfdf.jpg",
                            Stock = 10,
                            Titulo = "Casa Tomada"
                        },
                        new
                        {
                            ISBN = "9789877252538",
                            Autor = "Cortazar",
                            Edicion = "2019",
                            Editorial = "DEBOLSILLO",
                            Imagen = "https://ed77b8615c4e99183f6da2.jpg",
                            Stock = 10,
                            Titulo = "Rayuela"
                        },
                        new
                        {
                            ISBN = "9789875666474",
                            Autor = "Borges",
                            Edicion = "2011",
                            Editorial = "DEBOLSILLO",
                            Imagen = "https://contentv2/974_1.jpg?id_com=1113",
                            Stock = 10,
                            Titulo = "Ficciones"
                        },
                        new
                        {
                            ISBN = "9783150197882",
                            Autor = "Borges",
                            Edicion = "2000",
                            Editorial = "Emece",
                            Imagen = "https://isbn/9789500421300-es-300.jpg",
                            Stock = 10,
                            Titulo = "La biblioteca de Babel"
                        },
                        new
                        {
                            ISBN = "9786124507724",
                            Autor = "Sabato",
                            Edicion = "1",
                            Editorial = "Booket",
                            Imagen = "https://images/b564d07e519e687f9d51e4.jpg",
                            Stock = 10,
                            Titulo = "El túnel"
                        },
                        new
                        {
                            ISBN = "9789878317748",
                            Autor = "Sabato",
                            Edicion = "2021",
                            Editorial = "Booket",
                            Imagen = "https://contentv2/917748_1.jpg?id_com=1113",
                            Stock = 10,
                            Titulo = "La resistencia"
                        },
                        new
                        {
                            ISBN = "978-84-206-7273-1",
                            Autor = "Bioy Casares",
                            Edicion = "2022",
                            Editorial = "Alianza Editorial",
                            Imagen = "https://static.cegal/9788420/9067273.gif",
                            Stock = 10,
                            Titulo = "La invención de Morel"
                        },
                        new
                        {
                            ISBN = "9788420673615",
                            Autor = "Bioy Casares",
                            Edicion = "2012",
                            Editorial = "Alianza Editorial",
                            Imagen = "https://imagessl5/9788420673615.jpg",
                            Stock = 10,
                            Titulo = "El sueño de los héroes"
                        },
                        new
                        {
                            ISBN = "9789875802957",
                            Autor = "Neruda",
                            Edicion = "2008",
                            Editorial = "Cuspide",
                            Imagen = "https://9789875802957_1.jpg?id_com=1113",
                            Stock = 10,
                            Titulo = "20 Poemas De Amor Y Una Cancion Des"
                        },
                        new
                        {
                            ISBN = "9788432248450",
                            Autor = "Neruda",
                            Edicion = "2012",
                            Editorial = "Austral",
                            Imagen = "https://images.bba75516df65156022bb.jpg",
                            Stock = 10,
                            Titulo = "Cien Sonetos de Amor"
                        });
                });

            modelBuilder.Entity("Data.Alquileres", b =>
                {
                    b.HasOne("Data.Cliente", "Cliente")
                        .WithMany("Alquileres")
                        .HasForeignKey("Cliente_idx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EstadoDeAlquileres", "Estado")
                        .WithMany("Alquileres")
                        .HasForeignKey("Estado_idx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Libros", "Libros")
                        .WithMany("Alquileres")
                        .HasForeignKey("Libros_idx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Estado");

                    b.Navigation("Libros");
                });

            modelBuilder.Entity("Data.Cliente", b =>
                {
                    b.Navigation("Alquileres");
                });

            modelBuilder.Entity("Data.EstadoDeAlquileres", b =>
                {
                    b.Navigation("Alquileres");
                });

            modelBuilder.Entity("Data.Libros", b =>
                {
                    b.Navigation("Alquileres");
                });
#pragma warning restore 612, 618
        }
    }
}
