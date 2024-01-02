﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoutubeBlog.Data.Context;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231228140814_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("354043d3-5934-4136-b117-99f57b40f0f7"),
                            ConcurrencyStamp = "b0c11039-81b1-4912-a89e-e97650cb2246",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("9e62cbd1-68e7-4a37-bdb6-844c6c8090e3"),
                            ConcurrencyStamp = "238ea788-ceca-44fb-b05b-1fd03c7a161e",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("5b680afb-97fa-4adb-a1c2-7fbd84616302"),
                            ConcurrencyStamp = "f8ede542-5acf-44bf-83dd-52b20f699a7a",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e5102e42-2326-40d7-ae9d-f6593ce92a48"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c35abdc-a8eb-4e72-83b6-064d54978696",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kerem",
                            ImageId = new Guid("aed4065c-ffab-4b86-8837-3858281a850f"),
                            LastName = "Aluç",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAWE6npnzaaA5Kc9SOExp9uio/B96z+ymefiwyZP8HYl/aNJLsx2d5rZSYGuJ9P07A==",
                            PhoneNumber = "9",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "6056c95d-985e-42e0-8d14-47b1895da38c",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("45d910af-e957-4880-88a7-49b1fced6d24"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "291d40e0-36ef-42a8-8940-974fa798141a",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEii9akVG6Ct3e0XFzE31EkPJ3vtdjgFYYoKDkxUUoxCc2mHRcrVCg1tsq9OkGar5A==",
                            PhoneNumber = "905553455855",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3bd79277-1681-47ac-9b27-76981ce82cbf",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("e5102e42-2326-40d7-ae9d-f6593ce92a48"),
                            RoleId = new Guid("354043d3-5934-4136-b117-99f57b40f0f7")
                        },
                        new
                        {
                            UserId = new Guid("45d910af-e957-4880-88a7-49b1fced6d24"),
                            RoleId = new Guid("9e62cbd1-68e7-4a37-bdb6-844c6c8090e3")
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("456373fc-2bb5-485f-b7a3-4a4c47f1b243"),
                            CategoryId = new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"),
                            Content = "Asp.Net Core Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 12, 28, 17, 8, 13, 922, DateTimeKind.Local).AddTicks(9984),
                            ImageId = new Guid("aed4065c-ffab-4b86-8837-3858281a850f"),
                            IsDeleted = false,
                            Title = "Asp.Net Core Deneme Makalesi 1",
                            UserId = new Guid("e5102e42-2326-40d7-ae9d-f6593ce92a48"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("1b20250e-949e-4835-bb6e-280b277468f3"),
                            CategoryId = new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"),
                            Content = "Visual Studio Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 12, 28, 17, 8, 13, 922, DateTimeKind.Local).AddTicks(9993),
                            ImageId = new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"),
                            IsDeleted = false,
                            Title = "Visual Studio Core Deneme Makalesi 1",
                            UserId = new Guid("45d910af-e957-4880-88a7-49b1fced6d24"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2235fb5-9aa0-4103-bb4b-5bc2bb74457f"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 12, 28, 17, 8, 13, 923, DateTimeKind.Local).AddTicks(169),
                            IsDeleted = false,
                            Name = "ASP.NET CORE"
                        },
                        new
                        {
                            Id = new Guid("6b32f844-74a3-424b-9431-ecf65bee09e4"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 12, 28, 17, 8, 13, 923, DateTimeKind.Local).AddTicks(192),
                            IsDeleted = false,
                            Name = "Visual Studio 2022"
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aed4065c-ffab-4b86-8837-3858281a850f"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 12, 28, 17, 8, 13, 923, DateTimeKind.Local).AddTicks(291),
                            FileName = "images/testimage",
                            FileType = ".jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("60da40e5-6af5-4b7a-9435-a8e4f66bbe31"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 12, 28, 17, 8, 13, 923, DateTimeKind.Local).AddTicks(294),
                            FileName = "images/vstest",
                            FileType = ".png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("YoutubeBlog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeBlog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("YoutubeBlog.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("YoutubeBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}