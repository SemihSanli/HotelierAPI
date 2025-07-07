# 🏨✨ Kurumsal Otel Rezervasyon RESTful API Projesi ✨🏨

---

## 🚀 Proje Hakkında

Bu proje, **REST prensiplerine uygun** olarak geliştirilmiş tam kapsamlı bir **RESTful API** uygulamasıdır. Backend işlemleri tamamen API üzerinden yönetilmekte olup, frontend ile backend arasındaki iletişim tamamen API çağrıları ile sağlanmaktadır.  
Projede **stateless (durumsuz) mimari** esas alınmış, yani sunucu her isteği bağımsız olarak işler, önceki isteklerle ilgili herhangi bir durumu sunucu tarafında tutmaz. 🔄

---

## 📋 Projenin Temel Özellikleri

### 1️⃣ REST Prensiplerine Uygunluk

- **HTTP Metodları (CRUD)** kullanılarak kaynaklar üzerinde işlemler yapılır:  
  - `GET` 🔍 → Veri okuma  
  - `POST` ➕ → Yeni veri oluşturma  
  - `PUT/PATCH` ✏️ → Veri güncelleme  
  - `DELETE` ❌ → Veri silme  

- **Stateless yapı:** Her istek sunucu için bağımsızdır, sunucu önceki isteklerden bilgi tutmaz. ⚙️

- **URL yapısı kaynak odaklıdır:**  
  Projedeki her entity bir "kaynak" olarak düşünülür. Örnek URL: /api/rooms/1234

  Burada "rooms" 🛏️ kaynağıdır, "1234" ise o kaynağın benzersiz kimliğidir.

---

### 2️⃣ Kurumsal Mimari - 6 Katmanlı Mimari Tasarım

Projede **kurumsal mimari** prensiplerine uygun olarak toplam 6 katman kullanılmıştır:

| Katman Adı         | Görevleri                                                                                  |
|--------------------|-------------------------------------------------------------------------------------------|
| **APILayer** 🛠️   | REST API endpoint’lerinin tanımlandığı katmandır. HTTP istekleri burada karşılanır.       |
| **BusinessLayer** ⚙️ | İş kuralları, mantık ve validasyonların yer aldığı katman.                                |
| **DataAccessLayer** 💾 | Veritabanı ile doğrudan iletişim kuran, CRUD operasyonlarını gerçekleştiren katman.       |
| **EntityLayer** 📦  | Projedeki tüm entity (varlık) modellerinin tanımlandığı katman.                          |
| **PresentationLayer** 🖥️ | Kullanıcı arayüzü ve frontend katmanıdır. Bu projede API ile entegre çalışır.            |

---

### 3️⃣ API Test ve Dokümantasyon

- API'nin tüm CRUD operasyonları için **Swagger** 🧾 kullanılarak otomatik ve etkileşimli dökümantasyon oluşturulmuştur.  
- Ayrıca API çağrılarının kontrolü ve testleri için **Postman** 📨 kullanılmıştır.

---

### 4️⃣ Kimlik Doğrulama ve Yetkilendirme

- Projede **ASP.NET Identity** 🔐 kütüphanesi ile kullanıcı kimlik bilgileri ve roller yönetilmiştir.  
- Kullanıcılar rollere atanarak farklı yetki seviyelerine sahip olurlar. 🎭

---

### 5️⃣ Projedeki Entityler

| Entity Adı        | Açıklama                                |
|-------------------|---------------------------------------|
| 📝 About             | Hakkımızda bilgileri                   |
| 🛡️ AppRole           | Roller                                 |
| 👤 AppUser           | Kullanıcı bilgileri                    |
| 📅 Booking           | Rezervasyon kayıtları                  |
| 📞 Contact           | İletişim bilgileri                     |
| 🧳 Guest             | Misafir bilgileri                      |
| 📂 MessageCategory   | Mesaj kategorileri                     |
| 🛏️ Room              | Otel odaları                          |
| 📩 SendMessage       | Gönderilen mesajlar                    |
| 🛎️ Service           | Otelin sunduğu hizmetler               |
| 👥 Staff             | Personel bilgileri                     |
| 📧 Subscribe         | Mail bülteni abonelikleri              |
| 💬 Testimonial       | Müşteri yorumları                      |
| 📍 Worklocation      | Otel lokasyonları                      |

---

### 6️⃣ Veri Dönüşümleri - AutoMapper

- Projede veri transferi ve dönüşümleri için **AutoMapper** 🔄 kütüphanesi kullanılmıştır.  
- Entity modelleri ile DTO (Data Transfer Object) arasında otomatik ve kolay dönüşüm sağlanır.

---

### 7️⃣ Kod Kalitesi - SOLID ve Clean Code

- Tüm kod yazımı sırasında **SOLID prensipleri** ⚖️ ve **Clean Code** kurallarına sıkı sıkıya uyulmuştur.  
- Böylece sürdürülebilir, okunabilir ve kolay bakım yapılabilir kod yapısı oluşturulmuştur.

---

### 8️⃣ Güvenlik - Yetkilendirme

- API endpointlerinde **[Authorize]** 🛡️ ve **[AllowAnonymous]** 🚪 attribute'ları ile erişim kontrolü yapılmıştır.  
- Bazı sayfalar sadece yetkili kullanıcılar için açılırken, bazıları anonim erişime açıktır.

---

### 9️⃣ Rapid API Entegrasyonu

- **Rapid API** ⚡ platformu üzerinden Instagram 📸, LinkedIn 💼 ve Twitter 🐦 gibi sosyal medya platformlarından takipçi sayıları dinamik olarak çekilmektedir.

---

### 🔟 Dosya İşlemleri

- API üzerinden **dosya yükleme ve indirme** işlemleri yapılabilir. 📁⬆️⬇️

---

### 1️⃣1️⃣ AJAX Kullanımı

- Kullanıcı deneyimini artırmak için **AJAX** 🌀 ile sayfa yenilenmeden veri gönderme ve alma işlemleri yapılır.

---

### 1️⃣2️⃣ Veri Doğrulama - FluentValidation

- **FluentValidation** ✔️ kütüphanesi kullanılarak gelen verilerin doğruluğu ve tutarlılığı kontrol edilir.

---

### 1️⃣3️⃣ Mail Gönderimi - SMTP & MailKit

- **MailKit** 📧 paketi ile SMTP protokolü üzerinden canlı mail gönderimi sağlanır.  
- Örneğin, rezervasyon durumu değiştiğinde kullanıcılara bilgilendirme maili otomatik gönderilir. 📬

---

### 1️⃣4️⃣ Frontend Yapısı - Razor Pages & ViewComponent

- Projede **Razor Pages** 🖥️ ile sunum sayfaları hazırlanmış,  
- **ViewComponent** 🧩 kullanılarak tekrar kullanılabilir parçalara bölünmüş PartialView yapıları oluşturulmuştur.

---

### 1️⃣5️⃣ Repository Design Pattern

- Veritabanı işlemlerinde **Repository Design Pattern** 🗄️ kullanılarak katmanlar arasındaki bağımlılık minimize edilmiş,  
- Veri erişim soyutlanmıştır.

---

### 1️⃣6️⃣ Entity Özgü Metotlar

- İş katmanında özel metotlarla, örneğin:  
- Rezervasyon durum değişikliği kontrolleri 🔄  
- Dashboard’da son 4 personel ve rezervasyonun listelenmesi 📊  
- Personel sayısı, rezervasyon sayısı, toplam müşteri sayısı, toplam oda sayısı gibi istatistiklerin çekilmesi 📈  

gibi ihtiyaçlara özel çözümler geliştirilmiştir.

---

## 🛠️ Admin Paneli Özellikleri

- Personel, Referanslar, Hizmetler, Hakkımızda, Odalar, Misafirler, Kullanıcılar, Otel Lokasyonları, Roller ve Rol atama bölümlerinde **CRUD** işlemleri. 🔄  
- Rezervasyon yapıldığında, durum otomatik olarak "**Onay Bekliyor**" ⏳ olarak admin panelinde görünür.  
- Admin durumu güncellediğinde kullanıcıya **bilgilendirme maili gönderilir**. 📩  
- Mesajlar kısmından gelen mesajlar okunup yanıtlanabilir. 💬  
- Görsel veya PDF dosya yükleme ve yönetimi yapılabilir. 📷📄  
- Profil bilgileri güncellenebilir. 👤

---

## 👤 Kullanıcı Paneli Özellikleri

- Otel hakkında genel bilgiler, odalar, tanıtım videosu 🎥, sağlanan hizmetler, müşteri yorumları 🗣️, ekip bilgileri görüntülenir.  
- Mail bülteni aboneliği ile e-posta adresi sisteme kaydedilebilir. 📧

### 🛎️ Rezervasyon Sayfası

- Kullanıcı, ad-soyad, mail, giriş-çıkış tarihleri, yetişkin-çocuk sayısı, oda sayısı ve özel istekleri ile rezervasyon yapabilir.  
- Rezervasyon sonrası durum ile ilgili bilgilendirme maili kısa süre içinde kullanıcının mailine gider. 📬

### 📞 İletişim Sayfası

- Kullanıcı, ad-soyad, mail ve konu seçimi ile mesajını yöneticiye gönderebilir. 📨

### 📝 Kayıt Olma Sayfası

- Kullanıcı, Ad Soyad, Cinsiyet, Kullanıcı Adı, Mail ve şifre ile kayıt olur.  
- Kayıt sonrası giriş sayfasına yönlendirilir. 🔐

### 🔑 Giriş Sayfası

- Kullanıcı adı ve şifre ile giriş yapılır.  
- Oturum süresi yaklaşık **5-10 dakika** ile sınırlıdır. Süre dolduğunda cookie temizlenir, kullanıcı tekrar giriş yapmak zorundadır. ⏲️

---

## 🔐 Ekstra Güvenlik ve Teknolojiler

- **JSON Web Token (JWT)** 🔏 ile API güvenliği ve kimlik doğrulama.  
- **Rapid API** ile parametreli dinamik veri çekme. ⚡

---

# 🎉 Teşekkürler! 🎉

Proje, temiz, sürdürülebilir ve ölçeklenebilir mimarisi ile profesyonel seviyede geliştirilmeye çalışılmıştır.  



# 🖼️ Görseller

![1](https://github.com/user-attachments/assets/308246d8-7578-4da1-9019-f22d6d3bb836)
![2](https://github.com/user-attachments/assets/a96ecfc6-a3e0-4a9d-8a5e-3b4a7f4b7ee5)
![3](https://github.com/user-attachments/assets/3df9b4f9-052a-4c70-8efd-447502a84687)
![4](https://github.com/user-attachments/assets/474c07aa-7f26-4f0f-a785-8893323102ef)
![5](https://github.com/user-attachments/assets/1d2b7243-ce5c-4a9b-92e0-e6eca00db715)
![6](https://github.com/user-attachments/assets/09ea71c8-92ad-48b4-b3c2-aa951598b1c0)
![7](https://github.com/user-attachments/assets/ccad9bd5-dd22-4f89-8e8f-3df9043040fd)
![8](https://github.com/user-attachments/assets/148280d3-7dda-4518-8d18-9ea7fba655f3)
![9](https://github.com/user-attachments/assets/470058c2-2ed5-46dd-a5db-d11342d20869)
![10](https://github.com/user-attachments/assets/1b97df2f-2774-4e7e-89fa-83eb88049bc7)
![11](https://github.com/user-attachments/assets/b3e16302-70f2-4952-9a93-286e45f60a70)
![12](https://github.com/user-attachments/assets/b66e34f2-a52b-4105-864e-08933c290ef6)
![13](https://github.com/user-attachments/assets/b9f4372d-9180-4720-be67-8a250b7d9d72)
![29](https://github.com/user-attachments/assets/aa06819c-3b3d-4b33-8af8-87b964ffa985)
![14](https://github.com/user-attachments/assets/fc0602a6-63ca-41aa-aa2c-01bc989775d9)


![15](https://github.com/user-attachments/assets/de370169-f9bb-406f-a25c-6c6d8566ac6c)
![17](https://github.com/user-attachments/assets/b727d7bb-6bc4-4905-bd9d-0b175a184d3a)
![18](https://github.com/user-attachments/assets/f0e7307d-bfbe-48f5-a58b-605e34ac09b3)
![19](https://github.com/user-attachments/assets/52726e1b-262c-4a51-9a95-26222dee3112)
![20](https://github.com/user-attachments/assets/3a1c681c-dd05-427b-9374-fed32e0d5e77)
![21](https://github.com/user-attachments/assets/a566b00f-9174-4f0c-9d87-10eb59d0d40b)
![22](https://github.com/user-attachments/assets/c44cbf08-712b-4f92-850c-4d039c898dc3)
![23](https://github.com/user-attachments/assets/0d764990-7459-458d-a0b9-9e01444f6661)
![24](https://github.com/user-attachments/assets/526b2117-d347-4f54-8d14-dde3a09f2b95)
![25](https://github.com/user-attachments/assets/f9a344af-d148-4eb2-8fd5-1b3f476c3d29)
![26](https://github.com/user-attachments/assets/fd41214a-3a5a-44bd-b4d8-37068707a41c)
![27](https://github.com/user-attachments/assets/044fee5a-e9cd-4d37-9a7b-19e94429f6ef)
![28](https://github.com/user-attachments/assets/72719bdf-7548-4437-858c-8455a34bc72a)
![30](https://github.com/user-attachments/assets/96f54d3d-9fd1-4d23-97eb-59cd119c2955)





