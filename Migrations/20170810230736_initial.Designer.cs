using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummiBearKing.Models;

namespace GummiBearKing.Migrations
{
    [DbContext(typeof(GummiDbContext))]
    [Migration("20170810230736_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummiBearKing.Models.Gummi", b =>
                {
                    b.Property<int>("GummiId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Name");

                    b.Property<string>("Origin");

                    b.HasKey("GummiId");

                    b.ToTable("Gummis");
                });
        }
    }
}
