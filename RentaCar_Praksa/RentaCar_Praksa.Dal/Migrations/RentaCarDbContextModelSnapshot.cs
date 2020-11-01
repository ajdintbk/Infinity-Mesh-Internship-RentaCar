﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentaCar_Praksa.Dal;

namespace RentaCar_Praksa.Dal.Migrations
{
    [DbContext(typeof(RentaCarDbContext))]
    partial class RentaCarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.BookedCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.HasIndex("UserID");

                    b.ToTable("BookedCars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarID = 1,
                            CommentCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8239),
                            CreatedBy = "Terzic",
                            From = new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(7102),
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 0,
                            To = new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 300m,
                            UserID = 2
                        },
                        new
                        {
                            Id = 2,
                            CarID = 3,
                            CommentCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8365),
                            CreatedBy = "Terzic",
                            From = new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8311),
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 0,
                            To = new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 360m,
                            UserID = 1
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfDoors")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("YearOFProduction")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorID");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarName = "Mercedes Benz E220",
                            ColorID = 1,
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6218),
                            CreatedBy = "Terzic",
                            HorsePower = 131,
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfDoors = 5,
                            Price = 150m,
                            YearOFProduction = 2012
                        },
                        new
                        {
                            Id = 2,
                            CarName = "Mercedes Benz C220",
                            ColorID = 2,
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6347),
                            CreatedBy = "Terzic",
                            HorsePower = 131,
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfDoors = 5,
                            Price = 110m,
                            YearOFProduction = 2012
                        },
                        new
                        {
                            Id = 3,
                            CarName = "Volkswagen Golf VII",
                            ColorID = 3,
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6351),
                            CreatedBy = "Terzic",
                            HorsePower = 111,
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NumberOfDoors = 5,
                            Price = 120m,
                            YearOFProduction = 2016
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Bugojno",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7201),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Sarajevo",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7572),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Mostar",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7587),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorName = "Metalik siva",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(307),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ColorName = "Metalik crna",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(372),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ColorName = "Metalik crvena",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(375),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ColorName = "Mat crna",
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(378),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 11, 1, 1, 10, 41, 657, DateTimeKind.Local).AddTicks(9274),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Question = "Koliko dugo mogu da rentam vozilo?",
                            UserID = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 11, 1, 1, 10, 41, 661, DateTimeKind.Local).AddTicks(5764),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Question = "Da li su vozila odrzavana redovno?",
                            UserID = 2
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 11, 1, 1, 10, 41, 663, DateTimeKind.Local).AddTicks(5973),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 11, 1, 1, 10, 41, 663, DateTimeKind.Local).AddTicks(6084),
                            CreatedBy = "Terzic",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "Client"
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifideAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Prusac bb 70223",
                            CityID = 1,
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 656, DateTimeKind.Utc).AddTicks(5746),
                            CreatedBy = "Terzic",
                            DateOfBirth = new DateTime(1999, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmedterzic@hotmail.com",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ahmed",
                            Password = "ahmed123",
                            Surname = "Terzic",
                            Username = "Terzic"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Logavina br. 21",
                            CityID = 2,
                            CreatedAt = new DateTime(2020, 11, 1, 0, 10, 41, 656, DateTimeKind.Utc).AddTicks(6064),
                            CreatedBy = "Terzic",
                            DateOfBirth = new DateTime(1998, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nijedoe@hotmail.com",
                            ModifideAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            Password = "jihn123",
                            Surname = "NijeDOE",
                            Username = "NijeDOE"
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.UserRole", b =>
                {
                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RoleID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            UserID = 1
                        },
                        new
                        {
                            RoleID = 2,
                            UserID = 2
                        });
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.BookedCar", b =>
                {
                    b.HasOne("RentaCar_Praksa.Dal.Domain.Car", "Car")
                        .WithMany("BookedCars")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentaCar_Praksa.Dal.Domain.User", "User")
                        .WithMany("BookedCars")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.Car", b =>
                {
                    b.HasOne("RentaCar_Praksa.Dal.Domain.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.Contact", b =>
                {
                    b.HasOne("RentaCar_Praksa.Dal.Domain.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.User", b =>
                {
                    b.HasOne("RentaCar_Praksa.Dal.Domain.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentaCar_Praksa.Dal.Domain.UserRole", b =>
                {
                    b.HasOne("RentaCar_Praksa.Dal.Domain.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentaCar_Praksa.Dal.Domain.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}