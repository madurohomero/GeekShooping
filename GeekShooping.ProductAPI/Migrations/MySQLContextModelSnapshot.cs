﻿// <auto-generated />
using GeekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShooping.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShooping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Camiseta No Internet",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 79.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 89.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 99.9m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 109.9m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 110.9m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 129.9m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 139.9m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 149.9m
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 159.9m
                        },
                        new
                        {
                            Id = 12L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 169.9m
                        },
                        new
                        {
                            Id = 13L,
                            CategoryName = "T-shirt",
                            Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                            ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                            Name = "Name",
                            Price = 179.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
