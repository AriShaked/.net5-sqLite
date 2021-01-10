﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_rpg.Data;

namespace dotnet_rpg.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210110211355_FinalSeeding")]
    partial class FinalSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("dotnet_rpg.models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 1,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 2,
                            Defeats = 0,
                            Defense = 8,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Raistlin",
                            Strength = 10,
                            UserId = 2,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("dotnet_rpg.models.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("dotnet_rpg.models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 10,
                            Name = "FireBall"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 10,
                            Name = "IceBall"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 15,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 190, 145, 119, 44, 74, 70, 114, 169, 203, 18, 38, 230, 108, 143, 178, 131, 5, 124, 130, 23, 53, 71, 54, 160, 145, 7, 136, 153, 143, 232, 176, 75, 40, 40, 101, 247, 16, 32, 159, 60, 134, 187, 223, 136, 29, 243, 70, 50, 91, 21, 244, 150, 240, 242, 178, 169, 156, 116, 105, 110, 126, 172, 33, 52 },
                            PasswordSalt = new byte[] { 221, 10, 27, 238, 160, 110, 169, 46, 76, 145, 151, 176, 102, 23, 6, 204, 163, 170, 21, 87, 211, 106, 174, 148, 183, 78, 92, 58, 55, 52, 140, 42, 251, 88, 80, 88, 254, 148, 134, 216, 55, 179, 213, 223, 203, 186, 75, 70, 216, 151, 210, 17, 35, 12, 141, 165, 191, 242, 83, 41, 56, 18, 191, 102, 90, 8, 86, 235, 109, 74, 86, 252, 32, 226, 21, 38, 199, 110, 86, 72, 196, 228, 219, 160, 239, 112, 249, 198, 208, 106, 195, 8, 192, 183, 97, 223, 44, 204, 62, 224, 192, 56, 5, 66, 100, 230, 96, 175, 16, 252, 18, 103, 211, 18, 195, 210, 234, 150, 170, 235, 98, 110, 72, 8, 247, 171, 195, 57 },
                            Username = "user1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 190, 145, 119, 44, 74, 70, 114, 169, 203, 18, 38, 230, 108, 143, 178, 131, 5, 124, 130, 23, 53, 71, 54, 160, 145, 7, 136, 153, 143, 232, 176, 75, 40, 40, 101, 247, 16, 32, 159, 60, 134, 187, 223, 136, 29, 243, 70, 50, 91, 21, 244, 150, 240, 242, 178, 169, 156, 116, 105, 110, 126, 172, 33, 52 },
                            PasswordSalt = new byte[] { 221, 10, 27, 238, 160, 110, 169, 46, 76, 145, 151, 176, 102, 23, 6, 204, 163, 170, 21, 87, 211, 106, 174, 148, 183, 78, 92, 58, 55, 52, 140, 42, 251, 88, 80, 88, 254, 148, 134, 216, 55, 179, 213, 223, 203, 186, 75, 70, 216, 151, 210, 17, 35, 12, 141, 165, 191, 242, 83, 41, 56, 18, 191, 102, 90, 8, 86, 235, 109, 74, 86, 252, 32, 226, 21, 38, 199, 110, 86, 72, 196, 228, 219, 160, 239, 112, 249, 198, 208, 106, 195, 8, 192, 183, 97, 223, 44, 204, 62, 224, 192, 56, 5, 66, 100, 230, 96, 175, 16, 252, 18, 103, 211, 18, 195, 210, 234, 150, 170, 235, 98, 110, 72, 8, 247, 171, 195, 57 },
                            Username = "user2"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 12,
                            Name = "Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 9,
                            Name = "Knife"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.models.Character", b =>
                {
                    b.HasOne("dotnet_rpg.models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet_rpg.models.CharacterSkill", b =>
                {
                    b.HasOne("dotnet_rpg.models.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_rpg.models.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("dotnet_rpg.models.Weapon", b =>
                {
                    b.HasOne("dotnet_rpg.models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("dotnet_rpg.models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("dotnet_rpg.models.Character", b =>
                {
                    b.Navigation("CharacterSkills");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("dotnet_rpg.models.Skill", b =>
                {
                    b.Navigation("CharacterSkills");
                });

            modelBuilder.Entity("dotnet_rpg.models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
