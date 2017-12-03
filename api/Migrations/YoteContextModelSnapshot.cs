﻿// <auto-generated />
using api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace api.Migrations
{
    [DbContext(typeof(YoteContext))]
    partial class YoteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("api.Yote", b =>
                {
                    b.Property<int>("YoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data");

                    b.Property<float>("X");

                    b.Property<float>("Y");

                    b.Property<float>("Z");

                    b.HasKey("YoteId");

                    b.ToTable("Yotes");
                });
#pragma warning restore 612, 618
        }
    }
}
