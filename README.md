# Kütüphane Otomasyon Sistemi

Bu proje, C# programlama dili ve MSSQL veri tabanı kullanılarak geliştirilen bir kütüphane otomasyon sistemidir.

## Özellikler
* Kullanıcı ve admin girişi
* Kullanıcı kayıt olma ve profil güncelleme
* Kitap ekleme ve güncelleme (Admin)
* Kullanıcı - admin ekleme, güncelleme ve silme (Admin)
* Emanet kitap verme ve geri alma (Admin)
* Emanet süresi dolan kitaplar için giriş kısıtlaması

## Kurulum
1. Gerekli Yazılımlar:
   
* Visual Studio 2019 veya üzeri
* MSSQL Server 2016 veya üzeri
  
2. Veri Tabanını Oluşturun:

* MSSQL Server'ı başlatın ve yeni bir veri tabanı oluşturun.
* Projede bulunan Veri Tabanı isimli SqlQuery dosyasını çalıştırarak gerekli tablo, proc, func ve triggerları oluşturun.

3. Veri Tabanı Bağlantısını Ayarlayın:

* Proje dosyalarında ClassSql.cs dosyasını bulun.
* ClassSql sınıfındaki GetInstance metodunda bulunan bağlantı dizesini kendi veri tabanı bilgilerinizle güncelleyin.
  
4. Projeyi Çalıştırın:

* Visual Studio'da projeyi açın.
* Çözüm Gezgini'nde projeye sağ tıklayıp "Başlat" seçeneğini tıklayın.

## Kullanım
#### Admin Girişi
E-mail: tuanaaykiri@gmail.com  
Şifre: 123
#### Kullanıcı Girişi
E-mail: deryasusuz@gmail.com  
Şifre: 123
#### Cezalı Kullanıcı Girişi
E-mail: toprakaykiri@gmail.com  
Şifre: 1234
### Kullanıcı İşlemleri
* Kayıt Olma: Uygulama giriş ekranında "Kayıt Ol" butonuna tıklayarak yeni bir kullanıcı hesabı oluşturabilirsiniz.
* Giriş Yapma: Kullanıcı adı ve şifre ile giriş yapabilirsiniz.
* Profil Güncelleme: Giriş yaptıktan sonra profil sekmesinde bilgilerinizi güncelleyebilirsiniz.
* Emanet Kitapları Görüntüleme: "Emanetlerim" sekmesinde üzerinizde bulunan emanet kitapları görüntüleyebilirsiniz.
### Admin İşlemleri
* Kitap Yönetimi: "Kitaplar" sekmesinde kitap ekleyebilir, güncelleyebilir ve silebilirsiniz.
* Kullanıcı ve Admin Yönetimi: "Kullanıcılar" sekmesinde yeni kullanıcılar ve adminler ekleyebilir, mevcut olanları güncelleyebilir veya silebilirsiniz.
* Emanet İşlemleri: "Emanet Verme" sekmesinde kitapları kullanıcılara emanet verebilir ve geri alabilirsiniz.
