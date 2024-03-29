﻿// <auto-generated />
using Items.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Items.Migrations
{
    [DbContext(typeof(ItemsContext))]
    partial class ItemsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Items.Models.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorName");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Items.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArabicName");

                    b.Property<string>("Code");

                    b.Property<string>("EnglishName");

                    b.HasKey("ID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Items.Models.ItemColor", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<int>("ColorId");

                    b.HasKey("ItemId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ItemColors");
                });

            modelBuilder.Entity("Items.Models.ItemColor", b =>
                {
                    b.HasOne("Items.Models.Color", "Color")
                        .WithMany("ColorItems")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Items.Models.Item", "Item")
                        .WithMany("ItemColors")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
