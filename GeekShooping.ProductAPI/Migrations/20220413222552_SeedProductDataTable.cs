using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShooping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Camiseta No Internet", 69.9m },
                    { 3L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 79.9m },
                    { 4L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 89.9m },
                    { 5L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 99.9m },
                    { 6L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 109.9m },
                    { 7L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 110.9m },
                    { 8L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 129.9m },
                    { 9L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 139.9m },
                    { 10L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 149.9m },
                    { 11L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 159.9m },
                    { 12L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 169.9m },
                    { 13L, "T-shirt", "Com tecnologia Insider, a Tech T-shirt é nossa releitura tech da camiseta básica masculina. Feita com fibras macias que se adaptam ao corpo, acompanha seus movimentos e não esquenta. Essa t-shirt não precisa ser passada e não desbota com o tempo, é um item tecnologicamente essencial para uma rotina confortável.Composição: 92 % modal e 8 % elastano. Altura do modelo: 1,83m, tamanho: M |40", "H:\\PROJETOS\\NET.CORE\\GeekShooping\\ShoppingImages\\2_no_internet.jpg", "Name", 179.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);
        }
    }
}
