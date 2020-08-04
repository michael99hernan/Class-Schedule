﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchedulePicker.Data;

namespace SchedulePicker.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Schedule.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseType")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "This course presents an integrated approach to writing, reading, and critical thinking by developing the grammatical, logical, and rhetorical skills necessary for university writing.",
                            Name = "Rhetoric",
                            Number = 1302,
                            Prefix = "RHET"
                        },
                        new
                        {
                            CourseId = 2,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "Expands students' professional and team communication skills and strategies in technical contexts. Integrates writing, speaking and group communication by developing and presenting technical information to different audiences. Written assignments focus on creating professional technical documents, such as proposals, memos, abstracts, reports and letters. Presentation assignments emphasize planning, preparing and delivering dynamic, informative and persuasive presentations. Attendance at first class mandatory.",
                            Name = "Professional and Technical Communication",
                            Number = 3390,
                            Prefix = "ECS"
                        },
                        new
                        {
                            CourseId = 3,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 4,
                            Description = "Functions, limits, continuity, differentiation; integration of function of one variable; logarithmic, exponential, and inverse trigonometric functions; techniques of integration, and applications. Three lecture hours and two discussion hours a week; problem section required with MATH 2417, and will also be registered for exam section. Not all MATH/STAT courses may be counted toward various degree plans. Please consult your degree plan to determine the appropriate MATH/STAT course requirements. ",
                            Name = "Calculus I",
                            Number = 3417,
                            Prefix = "MATH"
                        },
                        new
                        {
                            CourseId = 4,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "Calculus based. Basic physics including a study of space and time, kinematics, forces, energy and momentum, conservation laws, rotational motion, torques, and harmonic oscillation. Two lectures per week. Students will also be registered for an exam section.",
                            Name = "Mechanics",
                            Number = 2325,
                            Prefix = "PHYS"
                        },
                        new
                        {
                            CourseId = 5,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "Topics include electrostatics and electromagnetics, electric field and potential, electric currents, magnetic fields, laws of Coulomb, Ampere, and Faraday, Maxwell's theory of wave propagation. Two lectures per week. Students will also be registered for an exam section.",
                            Name = "Electromagnetism and Waves",
                            Number = 2326,
                            Prefix = "PHYS"
                        },
                        new
                        {
                            CourseId = 6,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "",
                            Name = "Language, Philosphy and Culture",
                            Number = 0,
                            Prefix = ""
                        },
                        new
                        {
                            CourseId = 7,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "",
                            Name = "Creative Arts I",
                            Number = 0,
                            Prefix = ""
                        },
                        new
                        {
                            CourseId = 8,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "",
                            Name = "Creative Arts II",
                            Number = 0,
                            Prefix = ""
                        },
                        new
                        {
                            CourseId = 9,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "",
                            Name = "American History I",
                            Number = 0,
                            Prefix = ""
                        },
                        new
                        {
                            CourseId = 10,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "",
                            Name = "American History II",
                            Number = 0,
                            Prefix = ""
                        },
                        new
                        {
                            CourseId = 11,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "Survey of American national government, politics, and constitutional development. ",
                            Name = "American National Government",
                            Number = 2305,
                            Prefix = "GOVT"
                        },
                        new
                        {
                            CourseId = 12,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "Survey of state and local government and politics with special reference to the constitution and politics of Texas.",
                            Name = "State and Local Government",
                            Number = 2306,
                            Prefix = "GOVT"
                        },
                        new
                        {
                            CourseId = 13,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 3,
                            Description = "This course exposes students to major theoretical approaches and professional codes of ethics and how they may be applied to explore a range of important social issues in the information age. Issues of professional ethics, computer crime and privacy, intellectual property, the balance between the acceptability of risk and constraints such as cost, scheduling, safety and quality, the role of globalization and various important constitutional issues are explored by drawing upon case studies. Prerequisite: Completion of an 030 core course.",
                            Name = "Social Issues and Ethics in Science and Technology",
                            Number = 2361,
                            Prefix = "ECS"
                        },
                        new
                        {
                            CourseId = 14,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 4,
                            Description = "Improper integrals, sequences, infinite series, power series, parametric equations and polar coordinates, vectors, vector valued functions, functions of several variables, partial derivatives and applications, and multiple integration. Three lecture hours and two discussion hours a week; problem section required with MATH 2419, and will also be registered for exam section. ",
                            Name = "Calculus II",
                            Number = 2419,
                            Prefix = "MATH"
                        },
                        new
                        {
                            CourseId = 15,
                            ClassLevel = "UnderGraduate",
                            CourseType = 0,
                            Credits = 1,
                            Description = "Laboratory course to accompany any Physics I or Mechanics course. Experiments investigate basic measurements and statistics including error, mean, standard deviation and error propagation; one dimensional and two dimensional motion; Newton's laws; conservation laws of energy and momentum; rotational motion; and oscillations.",
                            Name = "Physics Lab",
                            Number = 2125,
                            Prefix = "PHYS"
                        });
                });

            modelBuilder.Entity("SchedulePicker.Models.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Majors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer Science",
                            School = "Erik School of Engineering"
                        });
                });

            modelBuilder.Entity("SchedulePicker.Models.MajorCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("MajorId");

                    b.ToTable("MajorCourses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 5,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 6,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 7,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 9,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 10,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 11,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 12,
                            CourseId = 12,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 13,
                            CourseId = 13,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 14,
                            CourseId = 14,
                            MajorId = 1
                        },
                        new
                        {
                            Id = 15,
                            CourseId = 15,
                            MajorId = 1
                        });
                });

            modelBuilder.Entity("SchedulePicker.Models.PreReq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("PrerequisiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("PrerequisiteId");

                    b.ToTable("PreReqs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 2,
                            PrerequisiteId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 14,
                            PrerequisiteId = 3
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 5,
                            PrerequisiteId = 4
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 12,
                            PrerequisiteId = 11
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 10,
                            PrerequisiteId = 9
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 4,
                            PrerequisiteId = 3
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 5,
                            PrerequisiteId = 14
                        });
                });

            modelBuilder.Entity("SchedulePicker.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("Schedule.Models.Student", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.ToTable("Students");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchedulePicker.Models.MajorCourse", b =>
                {
                    b.HasOne("Schedule.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchedulePicker.Models.Major", "Major")
                        .WithMany()
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchedulePicker.Models.PreReq", b =>
                {
                    b.HasOne("Schedule.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("Schedule.Models.Course", "Prerequisite")
                        .WithMany()
                        .HasForeignKey("PrerequisiteId");
                });

            modelBuilder.Entity("SchedulePicker.Models.StudentCourse", b =>
                {
                    b.HasOne("Schedule.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("Schedule.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
