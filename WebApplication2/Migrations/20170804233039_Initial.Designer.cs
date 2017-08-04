using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummyBear.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(GummyBearDbContext))]
    [Migration("20170804233039_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummyBear.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cost");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<int?>("ProductId1");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("GummyBear.Models.Product", b =>
                {
                    b.HasOne("GummyBear.Models.Product")
                        .WithMany("Produccts")
                        .HasForeignKey("ProductId1");
                });
        }
    }
}
