﻿// <auto-generated />
using System;
using Facturacion.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Facturacion.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Facturacion.Web.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("CompanyId");

                    b.HasKey("BrandId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Facturacion.Web.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("StateId");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Clasification", b =>
                {
                    b.Property<int>("ClasificationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ClasificationId");

                    b.ToTable("Clasifications");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("LocationId");

                    b.Property<int>("Phone");

                    b.Property<int>("SellerId");

                    b.HasKey("CompanyId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SellerId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("ExchangeId");

                    b.HasKey("CurrencyId");

                    b.HasIndex("ExchangeId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CTypeId");

                    b.Property<int>("CountryId");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("DocumentTypeId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Number");

                    b.HasKey("CustomerId");

                    b.HasIndex("CTypeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Facturacion.Web.Models.CustomerType", b =>
                {
                    b.Property<int>("CTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeCustomer")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("CTypeId");

                    b.ToTable("CustomerTypes");
                });

            modelBuilder.Entity("Facturacion.Web.Models.DocumentType", b =>
                {
                    b.Property<int>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeDocument")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("DocumentTypeId");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("Number");

                    b.Property<int>("PositionId");

                    b.Property<int>("StatusId");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PositionId");

                    b.HasIndex("StatusId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Exchange", b =>
                {
                    b.Property<int>("ExchangeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ExchangeName");

                    b.HasKey("ExchangeId");

                    b.ToTable("Exchanges");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<int>("ClasificationId");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("CurrencyId");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("StatusId");

                    b.Property<int>("SupplierId");

                    b.Property<int>("UnitId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitsInStock");

                    b.HasKey("ItemId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ClasificationId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("StatusId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UnitId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("CountryId");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Reference")
                        .HasMaxLength(80);

                    b.HasKey("LocationId");

                    b.HasIndex("CountryId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Neighborhood", b =>
                {
                    b.Property<int>("NeighborhoodId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("NeighborhoodName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("NeighborhoodId");

                    b.HasIndex("CityId");

                    b.ToTable("Neighborhoods");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderTime");

                    b.Property<int>("PaymentId");

                    b.Property<int>("ShippingId");

                    b.Property<decimal>("SubTotal");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("TotalValue");

                    b.Property<decimal>("Valueimp")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("comentario");

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ShippingId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Facturacion.Web.Models.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId");

                    b.Property<int>("OrderId");

                    b.Property<float>("Quantity");

                    b.Property<decimal>("TotalValue");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("DetailId");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pway")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("PositionId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Facturacion.Web.Models.PurchaseDetail", b =>
                {
                    b.Property<int>("PurchaseDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId");

                    b.Property<int>("PurchaseId");

                    b.Property<float>("Quantity");

                    b.Property<decimal>("TotalValue");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("PurchaseDetailId");

                    b.HasIndex("ItemId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchaseDetail");
                });

            modelBuilder.Entity("Facturacion.Web.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("OrderTime");

                    b.Property<int>("PaymentId");

                    b.Property<int>("ShippingId");

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal>("TotalValue");

                    b.Property<decimal>("Valueimp")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("comentario");

                    b.HasKey("PurchaseId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ShippingId");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Number");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Shipping", b =>
                {
                    b.Property<int>("ShippingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShippWay")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ShippingId");

                    b.ToTable("Shippings");
                });

            modelBuilder.Entity("Facturacion.Web.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusOf")
                        .IsRequired();

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId");

                    b.Property<string>("Mail")
                        .IsRequired();

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("SupplierTypeId");

                    b.Property<int>("Telephone");

                    b.HasKey("SupplierId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SupplierTypeId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Facturacion.Web.Models.SupplierType", b =>
                {
                    b.Property<int>("SupplierTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("SupplierTypeId");

                    b.ToTable("SupplierTypes");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("UnitId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Facturacion.Web.Models.Brand", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Company", "Company")
                        .WithMany("Brands")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.City", b =>
                {
                    b.HasOne("Facturacion.Web.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Company", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Location", "Location")
                        .WithMany("Companies")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Seller", "Seller")
                        .WithMany("Companies")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Currency", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Exchange", "Exchange")
                        .WithMany("Currencies")
                        .HasForeignKey("ExchangeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Customer", b =>
                {
                    b.HasOne("Facturacion.Web.Models.CustomerType", "CustomerType")
                        .WithMany("Customers")
                        .HasForeignKey("CTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.DocumentType", "DocumentType")
                        .WithMany("Customers")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Employee", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Status", "Status")
                        .WithMany("Employees")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Item", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Brand", "Brand")
                        .WithMany("Items")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Clasification", "Clasification")
                        .WithMany("Items")
                        .HasForeignKey("ClasificationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Currency", "Currency")
                        .WithMany("Items")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Status", "Status")
                        .WithMany("Items")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Supplier", "Supplier")
                        .WithMany("Items")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Unit", "Unit")
                        .WithMany("Items")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Location", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Country", "Country")
                        .WithMany("Locations")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Neighborhood", b =>
                {
                    b.HasOne("Facturacion.Web.Models.City", "City")
                        .WithMany("Neighborhoods")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Order", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Shipping", "Shipping")
                        .WithMany("Orders")
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Supplier", "Supplier")
                        .WithMany("Orders")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.OrderDetail", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Item", "Item")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.PurchaseDetail", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.PurchaseOrder", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.Shipping", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.State", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Facturacion.Web.Models.Supplier", b =>
                {
                    b.HasOne("Facturacion.Web.Models.Location", "Location")
                        .WithMany("Suppliers")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Facturacion.Web.Models.SupplierType", "SupplierType")
                        .WithMany("Suppliers")
                        .HasForeignKey("SupplierTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
