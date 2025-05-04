using Domain.Entities;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Seeds
{
    public static class VehicleSeeder
    { 
        public static async Task SeedAsync(AppDbContext context, PatenteGenerator gen)
        {
            // 2.1. Aplico migraciones pendientes
            await context.Database.MigrateAsync();            

            // 2.3. Seed de vehículos (si no existen)
            if (!context.Vehicles.Any())
            {
                var cars1 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000, 
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 5,
                        TransmissionTypeId = 1, 
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000, 
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 4,
                        TransmissionTypeId = 2, 
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000, 
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 7,
                        TransmissionTypeId = 1, 
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 1,
                        TransmissionTypeId = 2, 
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000, 
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 6,
                        TransmissionTypeId = 1, 
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000, 
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 2,
                        TransmissionTypeId = 1, 
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 1, 
                        CategoryId = 3,
                        TransmissionTypeId = 2, 
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000, 
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 5,
                        TransmissionTypeId = 1, 
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000, 
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 4,
                        TransmissionTypeId = 2, 
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000, 
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 7,
                        TransmissionTypeId = 1, 
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000, 
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 1,
                        TransmissionTypeId = 2, 
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000, 
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 6,
                        TransmissionTypeId = 1, 
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000, 
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 2,
                        TransmissionTypeId = 1, 
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000, 
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 1, 
                        CategoryId = 3,
                        TransmissionTypeId = 2, 
                        Color = "Azul"
                    },
                    
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 5,
                        TransmissionTypeId = 1, 
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 4,
                        TransmissionTypeId = 2, 
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 7,
                        TransmissionTypeId = 1, 
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 1,
                        TransmissionTypeId = 2, 
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 6,
                        TransmissionTypeId = 1, 
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1,
                        CategoryId = 2,
                        TransmissionTypeId = 1, 
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 3,
                        TransmissionTypeId = 2, 
                        Color = "Blanco"
                    },
                    
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 5,
                        TransmissionTypeId = 1, 
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 4,
                        TransmissionTypeId = 2, 
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 7,
                        TransmissionTypeId = 1, 
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 1,
                        TransmissionTypeId = 2, 
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 6,
                        TransmissionTypeId = 1, 
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 2,
                        TransmissionTypeId = 1, 
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 1, 
                        CategoryId = 3,
                        TransmissionTypeId = 2, 
                        Color = "Negro"
                    },
                    
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 5,
                        TransmissionTypeId = 1, 
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 4,
                        TransmissionTypeId = 2, 
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 7,
                        TransmissionTypeId = 1, 
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 1,
                        TransmissionTypeId = 2, 
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 6,
                        TransmissionTypeId = 1, 
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 2,
                        TransmissionTypeId = 1, 
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1, 
                        BranchOfficeId = 1, 
                        CategoryId = 3,
                        TransmissionTypeId = 2, 
                        Color = "Verde"
                    }
                };



                var cars2 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 2,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars3 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 3,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars4 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 4,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars5 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 5,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars6 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 6,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };


                var cars7 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 7,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars8 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 8,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars9 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 9,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                var cars10 = new List<Vehicle>
                {
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://wallpaperaccess.com/full/149037.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://s1.cdn.autoevolution.com/images/news/gallery/2021-chevrolet-s10-pickup-truck-revealed-its-the-colorados-brazilian-brother_3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://avtoline.si/wp-content/uploads/2018/08/spacetourer-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Perla"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://mundodoautomovelparapcd.com.br/wp-content/uploads/2023/02/honda-city-2023-07-1024x576.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEijU21M9Ys0rsGcT8Ub9_usaR-qGb_4hn1jjM_18Go0w27PHc2ora6mA3cPof9YNUVWvgf_u6cp8Fm5i49P2Y64632e3MsFaXt2tN4CI3MO9RIFMtgFq_sFpcRULOSByPJ1_80Awer2CNx5keeah8iLFxMFCrehsvFdw_vdRr_18mJHQIpXP-XRQeEZJlk/s2406/Mercedes-Benz-CLE%20(2).jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://images.prismic.io/carwow/793f5e85-dee4-4791-8b18-a365819c4100_54.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Naranja"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autonxt.net/wp-content/uploads/2020/07/2020_Toyota_Corolla_Hatchback_XSE_13-1024x614.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.11dc1a000bc3d490fb63f13dd558d2aa?rik=%2bno2eeWvhG8zRQ&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Amarillo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistafullpower.com.br/wp-content/uploads/2020/12/s10.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://media.drivingelectric.com/image/private/s---IUwWFBK--/v1597800989/drivingelectric/2020-06/cl_20.023.014.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Marron"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.arabahabercisi.com/wp-content/uploads/2021/10/2021-Honda-City-testi-4.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.emanualonline.com/blog/wp-content/uploads/2021/04/2022-Mercedes-Benz_CLS-1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.planetcarsz.com/assets/uploads/2019/12/RENAULT%20CAPTUR%202020%20024.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.ed.edmunds-media.com/toyota/corolla-hatchback/2023/oem/2023_toyota_corolla-hatchback_4dr-hatchback_se_fq_oem_2_815.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://s.car.info/image_files/1920/0-825250.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-Rj96wZoSzXg/YIg3j5f7XqI/AAAAAAADHtw/c91McqOGfIQ3F2lpMbcDZqYxpRZKd_MQQCLcBGAsYHQ/w640-h406/Chevrolet%2BS10%2BHigh%2BCountry%2B2022%2B%25286%2529.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://img.europapress.es/fotoweb/fotonoticia_20170508184810_1200.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Negro"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://motoreseacao.com/wp-content/uploads/2022/03/City-hatchback-1140x721-1-1024x648.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://www.slashgear.com/img/gallery/2024-mercedes-benz-cle-class-first-drive-when-one-coupe-is-better-than-two/intro-1694186938.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://autoagora.com.br/wp-content/uploads/dsc09308-2048x1536.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.zOBmuLoQnPV7_v7hwAWrWQHaFW?w=1280&h=925&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://1.bp.blogspot.com/-1VZcPoETnrs/WVx9pV32k9I/AAAAAAAAC2w/NIwpNZSrKPw7SWOWNWWVTKWZDne0xGYjgCLcBGAs/s1600/Carshighlight.com%2B-%2B%2Bchevrolet%2Bcamaro%2Bzl1%2B1le%2B2018%2Bred%2Bwallpaper.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.megautos.com/wp-content/uploads/2020/11/Chevrolet-S10-LTZ-2021-dinamica-1-768x502.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.a9b79ee8e4b11e3df2b189b44e64e4d5?rik=VVI29zS%2f3xTnKA&riu=http%3a%2f%2ftopcarspecs.com%2fmanufacturers%2fcitroen%2fcitroen-minibus%2fcitroen-minibus-5.jpg&ehk=%2fDVdBp2ZCZV9jpP927rZAIRDaFmEHXiZvzWzJqd4m8k%3d&risl=&pid=ImgRaw&r=0",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://runstop.co.th/wp-content/uploads/2023/11/PIC-RETOUCH-HONDA-CITY-2021-x-RS1-R2-1-scaled.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://vehicle-images.dealerinspire.com/c955-11000845/thumbnails/large/W1KMJ4HB5RF024578/f633fc5c3fba179703bbf2296ebf079e.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Blanco"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://cdn.motor1.com/images/mgl/9ogj1/s3/renault-elektro-neuheiten-2021.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://www.pedal.ir/wp-content/uploads/2024/07/2024-toyota-corolla-hybrid-review-7-1536x864.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Negro"
                    },

                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "Camaro",
                        LicensePlate = gen.Next(),
                        Year = 2018,
                        Price = 15000,
                        SeatingCapacity = 2,
                        ImageUrl = "https://i.pinimg.com/originals/d7/4e/f9/d74ef9c4dbccc5b05a1541c5f0a0ed6a.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 5,
                        TransmissionTypeId = 1,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Chevrolet",
                        Model = "S10",
                        LicensePlate = gen.Next(),
                        Year = 2021,
                        Price = 14000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://garagem360.com.br/wp-content/uploads/2016/10/cats3.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 4,
                        TransmissionTypeId = 2,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Citroen",
                        Model = "Spacetourer",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 16000,
                        SeatingCapacity = 7,
                        ImageUrl = "https://buscouncoche.es/wp-content/uploads/2019/04/citroen-jumpy-delantera.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 7,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Honda",
                        Model = "City",
                        LicensePlate = gen.Next(),
                        Year = 2022,
                        Price = 15000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://revistacarro.com.br/wp-content/uploads/2021/12/Novo-Honda-City-Touring-2022_1.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 1,
                        TransmissionTypeId = 2,
                        Color = "Azul"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Mercedes Benz",
                        Model = "Cle",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 22000,
                        SeatingCapacity = 4,
                        ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.xyILGudAc51mjhXgyMbZSwHaE6?w=1280&h=850&rs=1&pid=ImgDetMain",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 6,
                        TransmissionTypeId = 1,
                        Color = "Gris"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Renault",
                        Model = "Captur",
                        LicensePlate = gen.Next(),
                        Year = 2020,
                        Price = 13000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://media.fastestlaps.com/renault-captur-tce-160.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 2,
                        TransmissionTypeId = 1,
                        Color = "Rojo"
                    },
                    new Vehicle
                    {
                        VehicleId = Guid.NewGuid(),
                        Brand = "Toyota",
                        Model = "Corolla",
                        LicensePlate = gen.Next(),
                        Year = 2024,
                        Price = 17000,
                        SeatingCapacity = 5,
                        ImageUrl = "https://1.bp.blogspot.com/-KdhjQxEpOTI/W3a2QkHQTTI/AAAAAAAAJlY/g1sOzipfAh4Vd1BKEFSSfl6KZCI-g4A7QCLcBGAs/s1600/2019-toyota-corolla-hatchback-review-30.jpg",
                        VehicleStatusId = 1,
                        BranchOfficeId = 10,
                        CategoryId = 3,
                        TransmissionTypeId = 2,
                        Color = "Verde"
                    }
                };



                context.Vehicles.AddRange(cars1);
                context.Vehicles.AddRange(cars2);
                context.Vehicles.AddRange(cars3);
                context.Vehicles.AddRange(cars4);
                context.Vehicles.AddRange(cars5);
                context.Vehicles.AddRange(cars6);
                context.Vehicles.AddRange(cars7);
                context.Vehicles.AddRange(cars8);
                context.Vehicles.AddRange(cars9);
                context.Vehicles.AddRange(cars10);
            }

            // 2.4. Guardo todos los cambios
            await context.SaveChangesAsync();
        }
    }
}
