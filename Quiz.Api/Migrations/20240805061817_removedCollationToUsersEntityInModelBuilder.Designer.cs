﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiz.Api.Data;

#nullable disable

namespace Quiz.Api.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20240805061817_removedCollationToUsersEntityInModelBuilder")]
    partial class removedCollationToUsersEntityInModelBuilder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Quiz.Api.Models.QuestionEntity", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            Answer = "metro manila",
                            Question = "What is the capital of Philippines",
                            QuizId = 1
                        },
                        new
                        {
                            QuestionId = 2,
                            Answer = "Russia",
                            Question = "Which country has the largest land area?",
                            QuizId = 2
                        },
                        new
                        {
                            QuestionId = 3,
                            Answer = "Nile",
                            Question = "What is the longest river in the world?",
                            QuizId = 1
                        },
                        new
                        {
                            QuestionId = 4,
                            Answer = "Africa",
                            Question = "Which continent is known as the 'Dark Continent'?",
                            QuizId = 1
                        });
                });

            modelBuilder.Entity("Quiz.Api.Models.QuizEntity", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuizId"));

                    b.Property<string>("QuizName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizId");

                    b.ToTable("Quiz");

                    b.HasData(
                        new
                        {
                            QuizId = 1,
                            QuizName = "Geography"
                        },
                        new
                        {
                            QuizId = 2,
                            QuizName = "GeographyV2"
                        });
                });

            modelBuilder.Entity("Quiz.Api.Models.UsersEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a54a5ef-b73d-4f07-a7e0-f3c808d52647"),
                            Password = "admin",
                            Role = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("1e4d9d82-f13d-486c-9de8-3c809c45cf24"),
                            Password = "user",
                            Role = "user",
                            Username = "user"
                        });
                });

            modelBuilder.Entity("Quiz.Api.Models.QuestionEntity", b =>
                {
                    b.HasOne("Quiz.Api.Models.QuizEntity", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Quiz.Api.Models.QuizEntity", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
