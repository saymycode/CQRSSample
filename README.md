# CQRS Sample Project / CQRS Örnek Projesi

This project demonstrates a simple implementation of the Command Query Responsibility Segregation (CQRS) design pattern in the .NET platform.

Bu proje, Command Query Responsibility Segregation (CQRS) tasarım deseninin .NET platformunda basit bir uygulamasını göstermektedir.

## Project Structure / Proje Yapısı

The project consists of four main layers following Clean Architecture principles:

Proje, Clean Architecture prensiplerine uygun olarak dört ana katmandan oluşmaktadır:

- **CQRSSample.Domain:** Contains core entities and domain logic.
- **CQRSSample.Application:** Contains business rules, interfaces, and CQRS commands/queries.
- **CQRSSample.Infrastructure:** Handles database operations and external service implementations.
- **CQRSSample.API:** The HTTP API layer.

- **CQRSSample.Domain:** Temel varlıkları ve domain mantığını içerir.
- **CQRSSample.Application:** İş kurallarını, arayüzleri ve CQRS komutlarını/sorgularını içerir.
- **CQRSSample.Infrastructure:** Veritabanı işlemlerini ve dış servis implementasyonlarını içerir.
- **CQRSSample.API:** HTTP API katmanı.

## Technologies / Teknolojiler

- .NET 9.0
- Entity Framework Core
- MediatR (for CQRS implementation)
- FluentValidation
- SQL Server

- .NET 9.0
- Entity Framework Core
- MediatR (CQRS implementasyonu için)
- FluentValidation
- SQL Server

## What is CQRS? / CQRS Nedir?

CQRS (Command Query Responsibility Segregation) is a design pattern that separates read (Query) and write (Command) operations in a system.

CQRS (Command Query Responsibility Segregation), bir sistemdeki okuma (Query) ve yazma (Command) işlemlerinin ayrılması prensibidir.

In this project:

Bu projede:

- **Command:** Operations that modify data (Create, Update, Delete)
- **Query:** Operations that read data (Get, List)

- **Command:** Veri değiştiren operasyonlar (Create, Update, Delete)
- **Query:** Veri okuyan operasyonlar (Get, List)

## Installation / Kurulum

### 1. Clone the project / Projeyi klonlayın
```
git clone https://github.com/username/CQRSSample.git
cd CQRSSample
```

### 2. Create the database / Veritabanını oluşturun
You can manually create the database in SQL Server or use the following command:

Veritabanını SQL Server'da manuel olarak oluşturabilir veya aşağıdaki komutu kullanabilirsiniz:
```
dotnet ef database update
```

### 3. Run the project / Projeyi çalıştırın
```
dotnet run --project CQRSSample.API
```
The API will be available at **http://localhost:5000**.

API **http://localhost:5000** adresinde çalışacaktır.

## Repository Pattern

In this project, the **ProductRepository** is used for basic CRUD operations:

Bu projede, temel CRUD işlemleri için **ProductRepository** kullanılmaktadır:

- `GetByIdAsync(int id)`: Retrieves a product by ID.
- `GetAllAsync()`: Retrieves a list of all products.
- `AddAsync(Product product)`: Adds a new product.
- `UpdateAsync(Product product)`: Updates an existing product.
- `DeleteAsync(int id)`: Deletes a product by ID.

- `GetByIdAsync(int id)`: Belirtilen ID'ye sahip ürünü getirir.
- `GetAllAsync()`: Tüm ürünleri listeler.
- `AddAsync(Product product)`: Yeni bir ürün ekler.
- `UpdateAsync(Product product)`: Mevcut bir ürünü günceller.
- `DeleteAsync(int id)`: Belirtilen ID'ye sahip ürünü siler.

## Contributing / Katkıda Bulunma

To contribute to the project:

Projeye katkıda bulunmak için:

1. Fork the repository / Repository'yi fork edin.
2. Create a new feature branch / Yeni bir feature branch oluşturun:
   ```
   git checkout -b feature/newFeature
   ```
   ```
   git checkout -b feature/yeniOzellik
   ```
3. Commit your changes / Değişikliklerinizi commit edin:
   ```
   git commit -am "Added new feature"
   ```
   ```
   git commit -am "Yeni özellik eklendi"
   ```
4. Push your branch / Branch'inizi push edin:
   ```
   git push origin feature/newFeature
   ```
   ```
   git push origin feature/yeniOzellik
   ```
5. Create a Pull Request / Bir Pull Request oluşturun.

## License / Lisans

This project is licensed under the MIT License. For more information, see the LICENSE file.

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakabilirsiniz.

## Features / Özellikler

- Clean Architecture principles / Clean Architecture prensiplerine uygun yapı
- CQRS pattern implementation / CQRS pattern implementasyonu
- Asynchronous operations / Asenkron işlemler
- Entity Framework Core for database operations / Entity Framework Core ile veritabanı işlemleri
- Repository pattern usage / Repository pattern kullanımı
- Dependency Injection / Dependency Injection
- RESTful API endpoints / RESTful API endpointleri

