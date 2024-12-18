﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using vT.eCoffeeShop.Infrastructure.Contexts.AdminContexts;

#nullable disable

namespace vT.eCoffeeShop.Infrastructure.Migrations
{
    [DbContext(typeof(PostgreSqlDbContextAdmin))]
    [Migration("20241103105449_AddedPostgreSqlAdminTables")]
    partial class AddedPostgreSqlAdminTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("vT.eCoffeeShop.Infrastructure.Models.OrderItemDto", b =>
                {
                    b.Property<Guid>("OrderItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CoffeeItemId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("OrdersDtoOrdersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrdersId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("OrderItemsId");

                    b.HasIndex("OrdersDtoOrdersId");

                    b.ToTable("OrderItems", "adm");
                });

            modelBuilder.Entity("vT.eCoffeeShop.Infrastructure.Models.OrdersDto", b =>
                {
                    b.Property<Guid>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQty")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("OrdersId");

                    b.ToTable("Orders", "adm");
                });

            modelBuilder.Entity("vT.eCoffeeShop.Infrastructure.Models.OrderItemDto", b =>
                {
                    b.HasOne("vT.eCoffeeShop.Infrastructure.Models.OrdersDto", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrdersDtoOrdersId");
                });

            modelBuilder.Entity("vT.eCoffeeShop.Infrastructure.Models.OrdersDto", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
