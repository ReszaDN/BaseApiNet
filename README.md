# BaseApiNet


/NamaProyekApiAnda
|
|--- Controllers/
|    |--- ProductsController.cs
|    |--- CategoriesController.cs
|
|--- Data/
|    |--- AppDbContext.cs
|    |--- Migrations/
|    |    |--- (File migrasi akan otomatis dibuat di sini)
|    |
|    |--- Repositories/
|         |--- IProductRepository.cs  // Interface (kontrak)
|         |--- ProductRepository.cs   // Implementasi (logika query)
|
|--- DTOs/  (Data Transfer Objects)
|    |--- Product/
|         |--- ProductDto.cs          // Untuk data yang dikirim ke client
|         |--- ProductCreateDto.cs    // Untuk data yang diterima dari client
|
|--- Models/
|    |--- Product.cs
|    |--- Category.cs
|
|--- Services/
|    |--- IProductService.cs       // Interface (kontrak)
|    |--- ProductService.cs      // Implementasi (logika bisnis)
|
|--- Program.cs
|--- appsettings.json
|--- appsettings.Development.json
|--- NamaProyekApiAnda.csproj
