﻿// <auto-generated />
using System;
using Day28_EFCore_CodeFirst_Solo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Day28_EFCore_CodeFirst_Solo.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    partial class CompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Day28_EFCore_CodeFirst_Solo.Context.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 32000.0,
                            Location = "Newark, NJ",
                            Name = "Accounting",
                            Type = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            Budget = 1.0,
                            Location = "Hell, MI",
                            Name = "Marketing",
                            Type = "Advertising"
                        },
                        new
                        {
                            Id = 3,
                            Budget = 32000.0,
                            Location = "Daytona, FL",
                            Name = "Sales",
                            Type = "Sales"
                        });
                });

            modelBuilder.Entity("Day28_EFCore_CodeFirst_Solo.Context.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Email = "zeroC00l@hackerman.com",
                            FirstName = "Dade",
                            LastName = "Wilson"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            Email = "cerealKllr@aol.com",
                            FirstName = "Mathew",
                            LastName = "Lillard"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Email = "CrashOVERRIDE@hackerman.com",
                            FirstName = "Kate",
                            LastName = "Libby"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 2,
                            Email = "IAmJerrySmith@hotmail.com",
                            FirstName = "Jerry",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("Day28_EFCore_CodeFirst_Solo.Context.Employee", b =>
                {
                    b.HasOne("Day28_EFCore_CodeFirst_Solo.Context.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
