🚀 Yeni Projemi Tamamladım: IdentityMail — Modern Mesajlaşma Sistemi

M&Y Yazılım Eğitim Akademi Danışmanlık çatısı altında geliştirdiğim mesajlaşma sistemi projemi tamamladım! 🎉

📩 IdentityMail, kayıtlı kullanıcıların birbirine mesaj gönderdiği bir web uygulamasıdır. Dışarıya SMTP ile mail atmaz; alıcı sistemde yoksa mesaj gitmez. Mesajlar klasörlere ve kullanıcının kendi kategorilerine ayrılır, filtrelenir, yönetilir.

🔧 Kullandığım Teknolojiler
Backend: C# • ASP.NET Core 8 MVC
Veritabanı: MS SQL Server • Entity Framework Core • LINQ
Kimlik & Güvenlik: ASP.NET Core Identity (AppUser / AppRole) • Cookie Authentication (IdentityMailCookie) • Role-Based Authorization (Admin / User)
Frontend: Razor Views • HTML • CSS • Bootstrap • JavaScript • jQuery
Yapı: DTO • ViewModel • Service • ViewComponent

✨ Öne Çıkan Teknik Özellikler
📬 Gelen kutusu, gönderilenler, taslaklar, önemli mesajlar ve çöp kutusu — ortak liste ekranı, klasöre göre farklı sorgu
💬 Yanıtlama: ParentMessageId ile self-referencing mesaj ilişkisi (Re: konusu + orijinal metin)
🔎 MessageQueryService içinde LINQ ile dinamik arama, okundu/yıldız/tarih/kategori filtresi, sıralama ve sayfalama
🔗 EF Core’da Sender–Receiver (Restrict silme), kategori (SetNull) ve Include ile ilişkili veri çekme
📊 Admin dashboard: Count, GroupBy, Select, OrderBy ile kullanıcı / mesaj / kategori istatistikleri ve en aktif gönderenler
🗂️ Kullanıcıya özel kategoriler — kayıtta CategorySeedHelper ile İş / Kişisel / Önemli; profilde yeni kategori
👤 DTO (SendMailDto, LoginDto…) ve ViewModel (MessageListViewModel, AdminDashboardViewModel) ile entity’nin UI’dan ayrılması
🔐 Identity: kayıt, giriş, çıkış, şifre sıfırlama token’ı, e-posta doğrulama (demo), CustomErrorDescriber ile Türkçe hata
👮 Admin paneli: kullanıcı aktif/pasif (IsActive), tek rol atama, şikayet edilen mesajlar (IsReported)
⭐ Soft-delete: alıcı IsDeleted, gönderen IsDeletedBySender — bir taraf silince diğeri durur
👁️ Mesaj açılınca IsRead + ReadAt; sidebar’da _LayoutSidebar ViewComponent ile okunmamış / taslak rozeti
🖼️ Profil fotoğrafı wwwroot/uploads/profiles altına yüklenir
 <img width="945" height="373" alt="image" src="https://github.com/user-attachments/assets/1871ef9e-9472-44d4-80d9-3f59aa06824f" />

 
 <img width="945" height="373" alt="image" src="https://github.com/user-attachments/assets/46f1c49f-269c-4c4c-ba10-e02ec368cc1b" />

 <img width="945" height="373" alt="image" src="https://github.com/user-attachments/assets/c93fb1bb-8bba-4ca8-b0c6-ec2c9fdf6891" />

<img width="945" height="373" alt="image" src="https://github.com/user-attachments/assets/13a506a3-a94f-418b-b82d-fb481ac2c52b" />

<img width="945" height="373" alt="image" src="https://github.com/user-attachments/assets/8f587aaf-1f4b-41af-a5ac-49950ca6a91b" />

<img width="945" height="373" alt="image" src="https://github.com/user-attachments/assets/2cbfffd3-f715-476d-ba93-6479777f4f65" />


 
 

#ASPNetCore #CSharp #EntityFramework #Identity #MVC #SQLServer #YazılımGeliştirme
