﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotTastyCupcake.NanoSurvey.DataAccess;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NotTastyCupcake.NanoSurvey.DataAccess.Migrations
{
    [DbContext(typeof(SurveyContext))]
    partial class SurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Interview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<int?>("ServayId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ServayId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("SurveyId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnswerId")
                        .HasColumnType("integer");

                    b.Property<int?>("InterviewId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("InterviewId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discription")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Answer", b =>
                {
                    b.HasOne("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Interview", b =>
                {
                    b.HasOne("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("ServayId");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Question", b =>
                {
                    b.HasOne("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Result", b =>
                {
                    b.HasOne("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId");

                    b.HasOne("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Interview", "Interview")
                        .WithMany("Results")
                        .HasForeignKey("InterviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");

                    b.Navigation("Answer");

                    b.Navigation("Interview");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Interview", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys.Survey", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
