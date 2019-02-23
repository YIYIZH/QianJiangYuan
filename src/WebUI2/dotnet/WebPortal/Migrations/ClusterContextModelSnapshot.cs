﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WindowsAuth.models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ClusterContext))]
    partial class ClusterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WindowsAuth.models.TemplateEntry", b =>
                {
                    b.Property<string>("Template");
                        //.ValueGeneratedOnAdd();

                    b.Property<string>("Json");

                    b.Property<string>("Type");

                    b.Property<string>("Username");

                    b.HasKey("Template");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("WindowsAuth.models.UserEntry", b =>
                {
                    b.Property<string>("Email");
                        //.ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<string>("Config");

                    b.Property<string>("ConfigSecret");

                    b.Property<string>("Other");

                    b.Property<string>("Password");

                    b.Property<string>("gid");

                    b.Property<string>("isAdmin");

                    b.Property<string>("isAuthorized");

                    b.Property<string>("uid");

                    b.HasKey("Email");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
