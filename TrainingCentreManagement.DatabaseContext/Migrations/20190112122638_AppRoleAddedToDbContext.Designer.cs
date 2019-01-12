﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingCentreManagement.DatabaseContext.DatabaseContext;

namespace TrainingCentreManagement.DatabaseContext.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190112122638_AppRoleAddedToDbContext")]
    partial class AppRoleAddedToDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Batches.Batch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BatchScheduleId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("EntityDescription");

                    b.Property<decimal>("Fee");

                    b.Property<bool>("IsFree");

                    b.Property<bool>("IsNameDisplayed");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("RegistrationEnd");

                    b.Property<DateTime?>("RegistrationStart");

                    b.Property<int>("TotalCapacity");

                    b.Property<long>("TrainingId");

                    b.Property<DateTime>("TrainingStart");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("BatchScheduleId")
                        .IsUnique()
                        .HasFilter("[BatchScheduleId] IS NOT NULL");

                    b.HasIndex("TrainingId");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Batches.BatchTrainer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BatchId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Name");

                    b.Property<long>("TrainerAllocationTypeId");

                    b.Property<long>("TrainerId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("TrainerAllocationTypeId");

                    b.HasIndex("TrainerId");

                    b.ToTable("BatchTrainer");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Categories.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.Property<long?>("ParentId1");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ParentId1");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Categories.TrainingCategory", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId1");

                    b.Property<long>("TrainingId");

                    b.Property<long>("TrainingId1");

                    b.HasKey("CategoryId");

                    b.HasAlternateKey("TrainingId");

                    b.HasIndex("CategoryId1");

                    b.HasIndex("TrainingId1");

                    b.ToTable("TrainingCategory");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Institues.Institute", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Logo");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Institutes");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Master.ScedhuleType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ScedhuleType");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Master.TrainingType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TrainingType");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Scheduls.Schedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Name");

                    b.Property<long?>("ScedhuleTypeId");

                    b.Property<long>("ScheduleTypeId");

                    b.Property<double>("TotalHours");

                    b.Property<int>("TotalSessions");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ScedhuleTypeId");

                    b.ToTable("Schedule");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Schedule");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Scheduls.ScheduleDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("Date");

                    b.Property<int?>("Day");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Name");

                    b.Property<long>("ScheduleId");

                    b.Property<DateTime>("StartTime");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("ScheduleDetail");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Tags.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Tags.TrainingTag", b =>
                {
                    b.Property<long>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("TagId1");

                    b.Property<long>("TrainingId");

                    b.Property<long>("TrainingId1");

                    b.HasKey("TagId");

                    b.HasAlternateKey("TrainingId");

                    b.HasIndex("TagId1");

                    b.HasIndex("TrainingId1");

                    b.ToTable("TrainingTag");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainees.Trainee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EntityDescription");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainers.Trainer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EntityDescription");

                    b.Property<string>("LinkedinProfile")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainers.TrainerAllocationType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TrainerAllocationType");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainings.Training", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("EntityDescription");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Outline")
                        .IsRequired();

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<long>("TrainingTypeId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("TrainingTypeId");

                    b.ToTable("Training");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Training");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Batches.BatchSchedule", b =>
                {
                    b.HasBaseType("TrainingCentreManagement.Models.EntityModels.Scheduls.Schedule");

                    b.HasDiscriminator().HasValue("BatchSchedule");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainings.Course", b =>
                {
                    b.HasBaseType("TrainingCentreManagement.Models.EntityModels.Trainings.Training");

                    b.HasDiscriminator().HasValue("Course");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainings.Workshop", b =>
                {
                    b.HasBaseType("TrainingCentreManagement.Models.EntityModels.Trainings.Training");

                    b.HasDiscriminator().HasValue("Workshop");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.IdentityEntities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Batches.Batch", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Batches.BatchSchedule", "BatchSchedule")
                        .WithOne("Batch")
                        .HasForeignKey("TrainingCentreManagement.Models.EntityModels.Batches.Batch", "BatchScheduleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Trainings.Training", "Training")
                        .WithMany("Batches")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Batches.BatchTrainer", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Batches.Batch", "Batch")
                        .WithMany("BatchTrainers")
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Trainers.TrainerAllocationType", "AllocationType")
                        .WithMany()
                        .HasForeignKey("TrainerAllocationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Trainers.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Categories.Category", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Categories.Category", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId1");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Categories.TrainingCategory", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Categories.Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Trainings.Training", "Training")
                        .WithMany("Categories")
                        .HasForeignKey("TrainingId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Scheduls.Schedule", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Master.ScedhuleType", "ScedhuleType")
                        .WithMany()
                        .HasForeignKey("ScedhuleTypeId");
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Scheduls.ScheduleDetail", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Scheduls.Schedule", "TrainingSchedule")
                        .WithMany("ScheduleDetails")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Tags.TrainingTag", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Tags.Tag", "Tag")
                        .WithMany("Trainings")
                        .HasForeignKey("TagId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Trainings.Training", "Training")
                        .WithMany("Tags")
                        .HasForeignKey("TrainingId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainingCentreManagement.Models.EntityModels.Trainings.Training", b =>
                {
                    b.HasOne("TrainingCentreManagement.Models.EntityModels.Master.TrainingType", "TrainingType")
                        .WithMany()
                        .HasForeignKey("TrainingTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
