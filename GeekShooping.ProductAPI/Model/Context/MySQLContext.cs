using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta No Internet",
                Price = new decimal(69.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            }) ;
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name",
                Price = new decimal(79.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name",
                Price = new decimal(89.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name",
                Price = new decimal(99.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name",
                Price = new decimal(109.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name",
                Price = new decimal(110.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Name",
                Price = new decimal(129.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Name",
                Price = new decimal(139.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Name",
                Price = new decimal(149.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Name",
                Price = new decimal(159.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Name",
                Price = new decimal(169.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Name",
                Price = new decimal(179.9),
                Description = "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40",
                ImageURL = "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg",
                CategoryName = "T-shirt"
            });

        }
    }
}
