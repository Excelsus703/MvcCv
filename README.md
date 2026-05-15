# MvcCv — Dinamik CV Web Uygulaması

ASP.NET MVC 5 ile geliştirilmiş, yönetilebilir ve dinamik bir CV web uygulamasıdır. Tüm CV içerikleri veritabanından çekilmekte olup admin paneli aracılığıyla kolayca güncellenebilmektedir.

---

## 🚀 Özellikler

- Dinamik CV sayfası — tüm veriler veritabanından gelir
- Admin paneli üzerinden CRUD işlemleri
- Pop-up (modal) ile hızlı veri ekleme
- Form validasyon kontrolleri
- Admin girişi ve yetkilendirme (Authorize)
- Partial View kullanımı ile modüler yapı
- Repository Design Pattern ile katmanlı mimari

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|---|---|
| ASP.NET MVC 5 | Web uygulama mimarisi |
| Entity Framework (Db First) | ORM ve veritabanı yönetimi |
| MSSQL | Veritabanı |
| Repository Design Pattern | Veri erişim katmanı |
| Partial View | Modüler sayfa yapısı |
| HTML / CSS / Bootstrap | Arayüz ve hazır tema |

---

---

## ⚙️ Kurulum

1. Repoyu klonlayın:
   ```bash
   git clone https://github.com/Excelsus703/MvcCv.git
   ```

2. MSSQL üzerinde veritabanını oluşturun ve `Web.config` dosyasındaki bağlantı dizesini güncelleyin:
   ```xml
   <connectionStrings>
     <add name="MvcCvContext"
          connectionString="Server=.;Database=MvcCvDb;Trusted_Connection=True;"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

3. Projeyi Visual Studio'da açın ve çalıştırın.

---

## 🔐 Admin Paneli

Admin paneline `/Admin/Login` adresinden giriş yapabilirsiniz. Giriş sonrasında CV içeriklerini (eğitim, deneyim, beceriler vb.) ekleyebilir, düzenleyebilir ve silebilirsiniz.

---

## 📌 Notlar

- Bu proje bir eğitim serisi kapsamında geliştirilmiştir.
- Amaç; ASP.NET MVC 5, Entity Framework ve Repository Pattern konularını pekiştirmektir.
