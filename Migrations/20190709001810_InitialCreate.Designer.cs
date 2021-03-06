// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelevantPizza.Data;

namespace RelevantPizza.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20190709001810_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RelevantPizza.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<int>("Zip");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RelevantPizza.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Role");

                    b.Property<decimal>("Salary");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("RelevantPizza.Models.InventoryItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("PricePerUnit");

                    b.Property<int>("QuantityRemaining");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("RelevantPizza.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<int?>("DriverID");

                    b.Property<DateTime?>("DriverIn");

                    b.Property<DateTime?>("DriverOut");

                    b.Property<int>("OrderType");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("DriverID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RelevantPizza.Models.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("RelevantPizza.Models.Order", b =>
                {
                    b.HasOne("RelevantPizza.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RelevantPizza.Models.Employee", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverID");
                });
#pragma warning restore 612, 618
        }
    }
}
