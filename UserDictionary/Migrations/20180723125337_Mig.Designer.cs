﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserDictionary;

namespace UserDictionary.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180723125337_Mig")]
    partial class Mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("UserDictionary.Dictionary", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TotalWordsNumber");

                    b.Property<string>("WordId");

                    b.HasKey("Id");

                    b.HasIndex("WordId");

                    b.ToTable("Dictionaries");
                });

            modelBuilder.Entity("UserDictionary.DictionaryWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DictionaryId");

                    b.Property<string>("WordId");

                    b.HasKey("Id");

                    b.HasIndex("DictionaryId");

                    b.HasIndex("WordId");

                    b.ToTable("DictionaryWords");
                });

            modelBuilder.Entity("UserDictionary.Passage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract");

                    b.Property<string>("LastReadPlace");

                    b.Property<DateTime>("LastReadTime");

                    b.Property<string>("Name");

                    b.Property<int>("Page");

                    b.Property<string>("RemainWords");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Passages");
                });

            modelBuilder.Entity("UserDictionary.Word", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Phonetic");

                    b.Property<string>("Tag");

                    b.Property<string>("Translation");

                    b.Property<int>("YesorNo");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("UserDictionary.Dictionary", b =>
                {
                    b.HasOne("UserDictionary.Word")
                        .WithMany("Dictionaries")
                        .HasForeignKey("WordId");
                });

            modelBuilder.Entity("UserDictionary.DictionaryWord", b =>
                {
                    b.HasOne("UserDictionary.Dictionary", "Dictionary")
                        .WithMany("DictionaryWords")
                        .HasForeignKey("DictionaryId");

                    b.HasOne("UserDictionary.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId");
                });
#pragma warning restore 612, 618
        }
    }
}
