﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using PeliculasWebAPI;

#nullable disable

namespace PeliculasWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220511052420_GeneroIndice")]
    partial class GeneroIndice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosIdentificador")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosIdentificador", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");

                    b.HasData(
                        new
                        {
                            GenerosIdentificador = 1,
                            PeliculasId = 1
                        },
                        new
                        {
                            GenerosIdentificador = 4,
                            PeliculasId = 1
                        },
                        new
                        {
                            GenerosIdentificador = 2,
                            PeliculasId = 2
                        },
                        new
                        {
                            GenerosIdentificador = 4,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosIdentificador = 1,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosIdentificador = 3,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosIdentificador = 4,
                            PeliculasId = 4
                        },
                        new
                        {
                            GenerosIdentificador = 1,
                            PeliculasId = 4
                        },
                        new
                        {
                            GenerosIdentificador = 3,
                            PeliculasId = 4
                        },
                        new
                        {
                            GenerosIdentificador = 4,
                            PeliculasId = 5
                        },
                        new
                        {
                            GenerosIdentificador = 1,
                            PeliculasId = 5
                        },
                        new
                        {
                            GenerosIdentificador = 5,
                            PeliculasId = 5
                        });
                });

            modelBuilder.Entity("PeliculaSalaCine", b =>
                {
                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.Property<int>("SalasCinesId")
                        .HasColumnType("int");

                    b.HasKey("PeliculasId", "SalasCinesId");

                    b.HasIndex("SalasCinesId");

                    b.ToTable("PeliculaSalaCine");

                    b.HasData(
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 3
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 4
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 1
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 2
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 5
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 6
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalasCinesId = 7
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNac")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Actores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biografia = "Thomas Stanley Holland (Kingston upon Thames, Londres; 1 de junio de 1996), conocido simplemente como Tom Holland, es un actor, actor de voz y bailarín británico.",
                            FechaNac = new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Tom Holland"
                        },
                        new
                        {
                            Id = 2,
                            Biografia = "Samuel Leroy Jackson (Washington D. C., 21 de diciembre de 1948), conocido como Samuel L. Jackson, es un actor y productor de cine, televisión y teatro estadounidense. Ha sido candidato al premio Óscar, a los Globos de Oro y al Premio del Sindicato de Actores, así como ganador de un BAFTA al mejor actor de reparto.",
                            FechaNac = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            Biografia = "Robert John Downey Jr. (Nueva York, 4 de abril de 1965) es un actor, actor de voz, productor y cantante estadounidense. Inició su carrera como actor a temprana edad apareciendo en varios filmes dirigidos por su padre, Robert Downey Sr., y en su infancia estudió actuación en varias academias de Nueva York.",
                            FechaNac = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Robert Downey Jr."
                        },
                        new
                        {
                            Id = 4,
                            FechaNac = new DateTime(1981, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Chris Evans"
                        },
                        new
                        {
                            Id = 5,
                            FechaNac = new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Dwayne Johnson"
                        },
                        new
                        {
                            Id = 6,
                            FechaNac = new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Auli'i Cravalho"
                        },
                        new
                        {
                            Id = 7,
                            FechaNac = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Scarlett Johansson"
                        },
                        new
                        {
                            Id = 8,
                            FechaNac = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Keanu Reeves"
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Point>("Ubicacion")
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.ToTable("Cines");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Nombre = "Acropolis",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)")
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Sambil",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)")
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Megacentro",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)")
                        },
                        new
                        {
                            Id = 1,
                            Nombre = "Agora Mall",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)")
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.CineOferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<decimal>("DescuentoPorcentaje")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CineId")
                        .IsUnique();

                    b.ToTable("CinesOfertas");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CineId = 4,
                            DescuentoPorcentaje = 15m,
                            FechaFin = new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            FechaInicio = new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 1,
                            CineId = 1,
                            DescuentoPorcentaje = 10m,
                            FechaFin = new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            FechaInicio = new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Genero", b =>
                {
                    b.Property<int>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identificador"), 1L, 1);

                    b.Property<bool>("EstaBorrado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Identificador");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Identificador = 1,
                            EstaBorrado = false,
                            Nombre = "Acción"
                        },
                        new
                        {
                            Identificador = 2,
                            EstaBorrado = false,
                            Nombre = "Animación"
                        },
                        new
                        {
                            Identificador = 3,
                            EstaBorrado = false,
                            Nombre = "Comedia"
                        },
                        new
                        {
                            Identificador = 4,
                            EstaBorrado = false,
                            Nombre = "Ciencia ficción"
                        },
                        new
                        {
                            Identificador = 5,
                            EstaBorrado = false,
                            Nombre = "Drama"
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mensaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Cartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("PosterURL")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cartelera = false,
                            FechaEstreno = new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
                            Titulo = "Avengers"
                        },
                        new
                        {
                            Id = 2,
                            Cartelera = false,
                            FechaEstreno = new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg",
                            Titulo = "Coco"
                        },
                        new
                        {
                            Id = 3,
                            Cartelera = false,
                            FechaEstreno = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            Titulo = "Spider-Man: No way home"
                        },
                        new
                        {
                            Id = 4,
                            Cartelera = false,
                            FechaEstreno = new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            Titulo = "Spider-Man: Far From Home"
                        },
                        new
                        {
                            Id = 5,
                            Cartelera = true,
                            FechaEstreno = new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
                            Titulo = "The Matrix Resurrections"
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.PeliculaActor", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("PeliculaId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("PeliculasActores");

                    b.HasData(
                        new
                        {
                            PeliculaId = 4,
                            ActorId = 2,
                            Orden = 2,
                            Personaje = "Samuel L. Jackson"
                        },
                        new
                        {
                            PeliculaId = 4,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Peter Parker"
                        },
                        new
                        {
                            PeliculaId = 3,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Peter Parker"
                        },
                        new
                        {
                            PeliculaId = 1,
                            ActorId = 3,
                            Orden = 2,
                            Personaje = "Iron Man"
                        },
                        new
                        {
                            PeliculaId = 1,
                            ActorId = 7,
                            Orden = 3,
                            Personaje = "Black Widow"
                        },
                        new
                        {
                            PeliculaId = 1,
                            ActorId = 4,
                            Orden = 1,
                            Personaje = "Capitán América"
                        },
                        new
                        {
                            PeliculaId = 5,
                            ActorId = 8,
                            Orden = 1,
                            Personaje = "Neo"
                        });
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.SalaCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasPrecision(9, 3)
                        .HasColumnType("decimal(9,3)");

                    b.Property<int>("TipoSalaCine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("CineId");

                    b.ToTable("SalasCines");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CineId = 3,
                            Precio = 250m,
                            TipoSalaCine = 1
                        },
                        new
                        {
                            Id = 6,
                            CineId = 3,
                            Precio = 330m,
                            TipoSalaCine = 2
                        },
                        new
                        {
                            Id = 7,
                            CineId = 3,
                            Precio = 450m,
                            TipoSalaCine = 3
                        },
                        new
                        {
                            Id = 8,
                            CineId = 4,
                            Precio = 250m,
                            TipoSalaCine = 1
                        },
                        new
                        {
                            Id = 1,
                            CineId = 1,
                            Precio = 220m,
                            TipoSalaCine = 1
                        },
                        new
                        {
                            Id = 2,
                            CineId = 1,
                            Precio = 320m,
                            TipoSalaCine = 2
                        },
                        new
                        {
                            Id = 3,
                            CineId = 2,
                            Precio = 200m,
                            TipoSalaCine = 1
                        },
                        new
                        {
                            Id = 4,
                            CineId = 2,
                            Precio = 290m,
                            TipoSalaCine = 2
                        });
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("PeliculasWebAPI.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosIdentificador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeliculasWebAPI.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeliculaSalaCine", b =>
                {
                    b.HasOne("PeliculasWebAPI.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeliculasWebAPI.Entidades.SalaCine", null)
                        .WithMany()
                        .HasForeignKey("SalasCinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.CineOferta", b =>
                {
                    b.HasOne("PeliculasWebAPI.Entidades.Cine", null)
                        .WithOne("CineOferta")
                        .HasForeignKey("PeliculasWebAPI.Entidades.CineOferta", "CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.PeliculaActor", b =>
                {
                    b.HasOne("PeliculasWebAPI.Entidades.Actor", "Actor")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeliculasWebAPI.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.SalaCine", b =>
                {
                    b.HasOne("PeliculasWebAPI.Entidades.Cine", "Cine")
                        .WithMany("SalaCine")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Actor", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Cine", b =>
                {
                    b.Navigation("CineOferta");

                    b.Navigation("SalaCine");
                });

            modelBuilder.Entity("PeliculasWebAPI.Entidades.Pelicula", b =>
                {
                    b.Navigation("PeliculasActores");
                });
#pragma warning restore 612, 618
        }
    }
}
