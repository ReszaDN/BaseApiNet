# BaseApiNet


* `NamaProyekApiAnda/`
    * `Controllers/` - Menerima request HTTP dan mengembalikan response.
        * `ProductsController.cs`
        * `CategoriesController.cs`
    * `Data/` - Berisi semua yang terkait dengan akses data.
        * `AppDbContext.cs` - Konteks database Entity Framework.
        * `Migrations/` - File migrasi yang dibuat otomatis oleh EF Core.
        * `Repositories/` - Pola desain untuk memisahkan logika akses data.
            * `IProductRepository.cs` *(Interface/kontrak)*
            * `ProductRepository.cs` *(Implementasi logika query)*
    * `DTOs/` *(Data Transfer Objects)* - Objek untuk transfer data antara client dan server.
        * `Product/`
            * `ProductDto.cs` *(Data yang dikirim ke client)*
            * `ProductCreateDto.cs` *(Data yang diterima dari client)*
    * `Models/` - Representasi entitas atau tabel dalam database.
        * `Product.cs`
        * `Category.cs`
    * `Services/` - Berisi logika bisnis aplikasi.
        * `IProductService.cs` *(Interface/kontrak)*
        * `ProductService.cs` *(Implementasi logika bisnis)*
    * `Program.cs` - Titik masuk aplikasi, tempat konfigurasi servis dan middleware.
    * `appsettings.json` - File konfigurasi utama.
    * `appsettings.Development.json` - File konfigurasi khusus untuk environment development.
    * `NamaProyekApiAnda.csproj` - File proyek .NET.
