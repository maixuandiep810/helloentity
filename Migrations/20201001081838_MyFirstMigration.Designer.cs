﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using helloentity;

namespace helloentity.Migrations
{
    [DbContext(typeof(HelloentityContext))]
    [Migration("20201001081838_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("helloentity.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnName("Action")
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ObjectName")
                        .HasColumnName("ObjectName")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasComment("This is the Permission Table");
                });

            modelBuilder.Entity("helloentity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DisplayName")
                        .HasColumnName("DisplayName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("guest");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasComment("This is the Role Table");
                });

            modelBuilder.Entity("helloentity.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("PermissionId")
                        .HasColumnName("PermissionId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnName("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");

                    b.HasComment("This is the RolePermissions Table");
                });

            modelBuilder.Entity("helloentity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AvatarUrl")
                        .HasColumnName("AvatarUrl")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasColumnName("Password")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Username")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Username")
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("account");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasComment("This is the User Table");
                });

            modelBuilder.Entity("helloentity.UserPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("PermissionId")
                        .HasColumnName("PermissionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions");

                    b.HasComment("This is the UserPermissions Table");
                });

            modelBuilder.Entity("helloentity.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("RoleId")
                        .HasColumnName("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasComment("This is the UserRoles Table");
                });

            modelBuilder.Entity("helloentity.RolePermission", b =>
                {
                    b.HasOne("helloentity.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("FK_RolePermissions_Permissions")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("helloentity.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_RolePermissions_Roles")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("helloentity.UserPermission", b =>
                {
                    b.HasOne("helloentity.Permission", "Permission")
                        .WithMany("UserPermissions")
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("FK_UserPermissions_Permissions")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("helloentity.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserPermissions_Users")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("helloentity.UserRole", b =>
                {
                    b.HasOne("helloentity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_UserRoles_Roles")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("helloentity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserRoles_Users")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
