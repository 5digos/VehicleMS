using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransmissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "varchar(max)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchOffices",
                columns: table => new
                {
                    BranchOfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Hours = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    BranchOfficeZoneId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationReference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchOffices", x => x.BranchOfficeId);
                    table.ForeignKey(
                        name: "FK_BranchOffices_Zones_BranchOfficeZoneId",
                        column: x => x.BranchOfficeZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleStatusId = table.Column<int>(type: "int", nullable: false),
                    BranchOfficeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TransmissionTypeId = table.Column<int>(type: "int", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "BranchOfficeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_TransmissionTypes_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalTable: "TransmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalTable: "VehicleStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocuments",
                columns: table => new
                {
                    DocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocuments", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_VehicleDocuments_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleReviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleReviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_VehicleReviews_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TransmissionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manual" },
                    { 2, "Automático" }
                });

            migrationBuilder.InsertData(
                table: "VehicleCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Vehículo de tamaño mediano, ideal para uso familiar o personal, con un diseño cerrado y cómodo.", "Sedán" },
                    { 2, "Vehículo utilitario deportivo, con mayor espacio y capacidad para terrenos difíciles.", "SUV" },
                    { 3, "Vehículo compacto con una puerta trasera que da acceso al baúl, ideal para la ciudad.", "Hatchback" },
                    { 4, "Vehículo con una cabina y una zona de carga abierta, ideal para transporte de mercancías.", "Pickup" },
                    { 5, "Vehículo diseñado para altas prestaciones, con un diseño aerodinámico y potente.", "Deportivo" },
                    { 6, "Vehículo de dos puertas con un diseño elegante y deportivo, ideal para uso personal.", "Coupé" },
                    { 7, "Ideal para familias grandes o grupos.", "Minivan" }
                });

            migrationBuilder.InsertData(
                table: "VehicleStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Disponible" },
                    { 2, "Ocupado" },
                    { 3, "En Mantenimiento" }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Zona Norte" },
                    { 2, "Zona Sur" },
                    { 3, "Zona Oeste" },
                    { 4, "Capital Federal" },
                    { 5, "Interior del País" }
                });

            migrationBuilder.InsertData(
                table: "BranchOffices",
                columns: new[] { "BranchOfficeId", "Address", "BranchOfficeZoneId", "City", "Hours", "Latitude", "LocationReference", "Longitude", "Name", "Phone", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 1, "Av. Del Libertador 16500", 1, "San Isidro", "08:00-18:00", -34.4319m, "Frente al Hipódromo de San Isidro", -58.4986m, "Sucursal San Isidro", "011-4747-2442", "B1642", "Buenos Aires" },
                    { 2, "Av. Maipú 1234", 1, "Vicente López", "09:00-19:00", -34.5396m, "Cerca de la estación Vicente López", -58.4706m, "Sucursal Vicente López", "011-4791-1234", "B1602", "Buenos Aires" },
                    { 3, "Av. Maipú 1850", 1, "Olivos", "08:00-20:00", -34.5076m, "Junto a la Plaza Olivos", -58.4846m, "Sucursal Olivos", "011-4795-1850", "B1636", "Buenos Aires" },
                    { 4, "Av. Santa Fe 3600", 1, "Martínez", "08:00-19:00", -34.5078m, "Frente a la estación Martínez", -58.5203m, "Sucursal Martínez", "011-4734-3600", "B1640", "Buenos Aires" },
                    { 5, "Av. Rolón 4090", 1, "Boulogne", "09:00-18:00", -34.5133m, "Cerca de la Autopista Panamericana", -58.6000m, "Sucursal Boulogne", "011-4749-4090", "B1643", "Buenos Aires" },
                    { 6, "Calle del Arco 55", 1, "San Fernando", "08:00-17:00", -34.4473m, "Frente a la estación San Fernando", -58.5719m, "Sucursal San Fernando", "011-4743-0550", "B1646", "Buenos Aires" },
                    { 7, "Av. Italia 550", 1, "Tigre", "09:00-20:00", -34.4246m, "A metros del Puerto de Frutos", -58.5698m, "Sucursal Tigre", "011-4512-0550", "B1648", "Buenos Aires" },
                    { 8, "Av. Maipú 1075", 1, "Florida", "08:00-19:00", -34.5461m, "Cerca del Shopping Florida", -58.4736m, "Sucursal Florida", "011-4794-1075", "B1602", "Buenos Aires" },
                    { 9, "Av. del Libertador 14500", 1, "Acassuso", "09:00-19:00", -34.4717m, "Frente al Río de la Plata", -58.5060m, "Sucursal Acassuso", "011-4795-1450", "B1641", "Buenos Aires" },
                    { 10, "Av. del Libertador 14000", 1, "Beccar", "08:00-18:00", -34.4910m, "Junto al Paseo de la Costa", -58.5120m, "Sucursal Beccar", "011-4794-1400", "B1642", "Buenos Aires" },
                    { 11, "Av. Mitre 500", 2, "Quilmes", "08:00-20:00", -34.7206m, "Frente a la estación Quilmes", -58.2673m, "Sucursal Quilmes", "011-4257-0500", "B1878", "Buenos Aires" },
                    { 12, "Av. Yrigoyen 700", 2, "Lomas de Zamora", "09:00-19:00", -34.7620m, "Esquina con Camino Negro", -58.3950m, "Sucursal Lomas de Zamora", "011-4220-0700", "B1832", "Buenos Aires" },
                    { 13, "Av. Alsina 300", 2, "Banfield", "08:00-18:00", -34.7907m, "Frente a la estación Banfield", -58.3958m, "Sucursal Banfield", "011-4240-0300", "B1828", "Buenos Aires" },
                    { 14, "Av. Belgrano 100", 2, "Avellaneda", "09:00-20:00", -34.6559m, "Cerca del Puente Pueyrredón", -58.3645m, "Sucursal Avellaneda", "011-4227-0100", "B1870", "Buenos Aires" },
                    { 15, "Av. 9 de Julio 2500", 2, "Lanús", "08:00-19:00", -34.7025m, "A metros de la estación Lanús", -58.3794m, "Sucursal Lanús", "011-4243-2500", "B1824", "Buenos Aires" },
                    { 16, "Av. Mitre 2100", 2, "Berazategui", "09:00-18:00", -34.8282m, "Esquina con calle 14", -58.2165m, "Sucursal Berazategui", "011-4212-2100", "B1884", "Buenos Aires" },
                    { 17, "Av. Hudson 1900", 2, "Florencio Varela", "08:00-17:00", -34.8290m, "Frente al Shopping Varela", -58.2780m, "Sucursal Florencio Varela", "011-4211-1900", "B1888", "Buenos Aires" },
                    { 18, "Av. Espora 4200", 2, "Almirante Brown", "09:00-19:00", -34.7840m, "Junto a la Plaza Brown", -58.3895m, "Sucursal Almirante Brown", "011-4260-4200", "B1847", "Buenos Aires" },
                    { 19, "Av. Pedro Buratovich 150", 2, "San Vicente", "08:00-18:00", -34.8650m, "A metros del Hospital", -58.4052m, "Sucursal San Vicente", "011-4295-0150", "B1865", "Buenos Aires" },
                    { 20, "Av. Brown 1500", 2, "Esteban Echeverría", "09:00-20:00", -34.8080m, "Frente a la Municipalidad", -58.4590m, "Sucursal Esteban Echeverría", "011-4296-1500", "B1842", "Buenos Aires" },
                    { 21, "Av. Rivadavia 100", 3, "Morón", "08:00-20:00", -34.6500m, "Cerca de la estación Morón", -58.6200m, "Sucursal Morón", "011-4650-0100", "B1708", "Buenos Aires" },
                    { 22, "Av. Libertador 200", 3, "Merlo", "09:00-19:00", -34.6520m, "Frente al Municipio de Merlo", -58.7060m, "Sucursal Merlo", "011-4660-0200", "B1722", "Buenos Aires" },
                    { 23, "Av. Eva Perón 800", 3, "Moreno", "08:00-18:00", -34.6475m, "A metros de la plaza central", -58.6192m, "Sucursal Moreno", "011-4628-0800", "B1744", "Buenos Aires" },
                    { 24, "Av. Rivadavia 8500", 3, "Ituzaingó", "09:00-20:00", -34.6574m, "Frente al Puente 12", -58.7035m, "Sucursal Ituzaingó", "011-4620-8500", "B1714", "Buenos Aires" },
                    { 25, "Av. Vergara 500", 3, "Hurlingham", "08:00-19:00", -34.6083m, "Cerca del Club Hurlingham", -58.6150m, "Sucursal Hurlingham", "011-4617-0500", "B1686", "Buenos Aires" },
                    { 26, "Av. San Martín 2400", 3, "Tres de Febrero", "09:00-19:00", -34.6394m, "Frente al shopping Tres de Febrero", -58.6477m, "Sucursal Tres de Febrero", "011-4625-2400", "B1678", "Buenos Aires" },
                    { 27, "Av. Vte. López y Planes 600", 3, "San Justo", "08:00-18:00", -34.6946m, "Cerca del Hospital San Justo", -58.5449m, "Sucursal San Justo", "011-4254-0600", "B1754", "Buenos Aires" },
                    { 28, "Av. San Martín 2500", 3, "Caseros", "09:00-20:00", -34.6313m, "Frente a la estación Caseros", -58.5503m, "Sucursal Caseros", "011-4624-2500", "B1678", "Buenos Aires" },
                    { 29, "Av. Eva Perón 3450", 3, "Rafael Castillo", "08:00-19:00", -34.6983m, "A metros del Club Ferrocarril Oeste", -58.6180m, "Sucursal Rafael Castillo", "011-4256-3450", "B1758", "Buenos Aires" },
                    { 30, "Av. Presidente Perón 2000", 3, "Ciudad Evita", "09:00-18:00", -34.7000m, "Junto a la Plaza Evita", -58.5010m, "Sucursal Ciudad Evita", "011-4253-2000", "B1753", "Buenos Aires" },
                    { 31, "Rivadavia 100", 4, "Ciudad Autónoma de Buenos Aires", "09:00-17:00", -34.6082m, "Frente a Casa Rosada", -58.3738m, "Sucursal Plaza de Mayo", "011-4370-0100", "C1084", "CABA" },
                    { 32, "Av. Dr. J. M. Ramos Mejía 777", 4, "Ciudad Autónoma de Buenos Aires", "08:00-20:00", -34.5882m, "Frente a la estación Retiro", -58.3744m, "Sucursal Retiro", "011-4379-0777", "C1061", "CABA" },
                    { 33, "Av. Santa Fe 3200", 4, "Ciudad Autónoma de Buenos Aires", "09:00-21:00", -34.5891m, "Esquina con Bulnes", -58.4245m, "Sucursal Palermo", "011-4833-3200", "C1425", "CABA" },
                    { 34, "Junín 1800", 4, "Ciudad Autónoma de Buenos Aires", "08:00-20:00", -34.5884m, "Cerca del Cementerio", -58.3910m, "Sucursal Recoleta", "011-4808-1800", "C1113", "CABA" },
                    { 35, "Av. Cabildo 2200", 4, "Ciudad Autónoma de Buenos Aires", "09:00-19:00", -34.5570m, "Frente a la estación Belgrano R", -58.4478m, "Sucursal Belgrano", "011-4714-2200", "C1426", "CABA" },
                    { 36, "Defensa 700", 4, "Ciudad Autónoma de Buenos Aires", "09:00-18:00", -34.6195m, "A metros de Plaza Dorrego", -58.3733m, "Sucursal San Telmo", "011-4294-0700", "C1065", "CABA" },
                    { 37, "Caminito 415", 4, "Ciudad Autónoma de Buenos Aires", "10:00-18:00", -34.6347m, "Junto al Puente de la Mujer", -58.3633m, "Sucursal La Boca", "011-4302-0415", "C1164", "CABA" },
                    { 38, "Florida 300", 4, "Ciudad Autónoma de Buenos Aires", "08:00-22:00", -34.6083m, "A una cuadra de Av. Corrientes", -58.3707m, "Sucursal Microcentro", "011-4331-0300", "C1005", "CABA" },
                    { 39, "Av. Corrientes 3800", 4, "Ciudad Autónoma de Buenos Aires", "09:00-20:00", -34.6050m, "Frente al teatro", -58.4185m, "Sucursal Almagro", "011-4951-3800", "C1182", "CABA" },
                    { 40, "Av. Cabildo 4500", 4, "Ciudad Autónoma de Buenos Aires", "09:00-21:00", -34.5312m, "Cerca del Monumento", -58.4882m, "Sucursal Núñez", "011-4784-4500", "C1428", "CABA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffices_BranchOfficeZoneId",
                table: "BranchOffices",
                column: "BranchOfficeZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocuments_VehicleId",
                table: "VehicleDocuments",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleReviews_VehicleId",
                table: "VehicleReviews",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BranchOfficeId",
                table: "Vehicles",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CategoryId",
                table: "Vehicles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TransmissionTypeId",
                table: "Vehicles",
                column: "TransmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleStatusId",
                table: "Vehicles",
                column: "VehicleStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleDocuments");

            migrationBuilder.DropTable(
                name: "VehicleReviews");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "BranchOffices");

            migrationBuilder.DropTable(
                name: "TransmissionTypes");

            migrationBuilder.DropTable(
                name: "VehicleCategories");

            migrationBuilder.DropTable(
                name: "VehicleStatus");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
