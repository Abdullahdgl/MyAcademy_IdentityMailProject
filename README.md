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

#ASPNetCore #CSharp #EntityFramework #Identity #MVC #SQLServer #YazılımGeliştirme
