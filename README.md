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

## 📸 Ekran Görüntüleri

Cv Sayfası 1
<img width="1600" height="803" alt="anasayfa1" src="https://github.com/user-attachments/assets/9522405e-f654-4983-9257-82014e372ce0" />

Cv Sayfası 2
<img width="1600" height="805" alt="Anasayfa2" src="https://github.com/user-attachments/assets/d27759eb-300c-4a3c-b23f-645fe8fa67da" />

Cv Sayfası 3
<img width="1600" height="805" alt="Anasayfa3" src="https://github.com/user-attachments/assets/cf23db71-384f-4695-9efa-40ba52434132" />

Admin Sayfası 1
<img width="1600" height="800" alt="Admin1" src="https://github.com/user-attachments/assets/15434316-f1d9-4c7f-ad73-1b8afadddfb7" />

Admin Sayfası 2
<img width="1600" height="802" alt="Admin2" src="https://github.com/user-attachments/assets/515a6fd3-cb41-4020-8ad3-c8b4ff5cf2ea" />

Admin Sayfası 3
<img width="1600" height="804" alt="Admin3" src="https://github.com/user-attachments/assets/524c5f4e-7f33-4d4e-a0a5-c0dbdfb2bac9" />

Admin Sayfası 4
<img width="1600" height="805" alt="Admin4" src="https://github.com/user-attachments/assets/11550486-6e42-4320-bc50-c311fc006654" />
