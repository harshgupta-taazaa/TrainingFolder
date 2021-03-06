// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codefirst;

namespace codefirst.Migrations
{
    [DbContext(typeof(Foocontext))]
    [Migration("20210409220902_version3")]
    partial class version3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("codefirst.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("productid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("codefirst.Product", b =>
                {
                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("codefirst.Productdetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Productdetails");
                });

            modelBuilder.Entity("codefirst.Employee", b =>
                {
                    b.HasOne("codefirst.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("product");
                });

            modelBuilder.Entity("codefirst.Productdetails", b =>
                {
                    b.HasOne("codefirst.Product", "Product")
                        .WithOne("Productdetails")
                        .HasForeignKey("codefirst.Productdetails", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("codefirst.Product", b =>
                {
                    b.Navigation("Productdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
