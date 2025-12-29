# C# ve .NET Nedir?

## C# Nedir?

**C#** (C-Sharp olarak okunur), Microsoft tarafından geliştirilen modern, nesne yönelimli (object-oriented) bir programlama dilidir.

### C#'ın Özellikleri

- **Modern ve Güçlü**: Type-safe (tip güvenli), güçlü tip kontrolüne sahip
- **Nesne Yönelimli**: Sınıflar, kalıtım, polimorfizm, encapsulation gibi OOP prensiplerini destekler
- **Platform Bağımsız**: .NET ile birlikte Windows, Linux, macOS, iOS, Android gibi birçok platformda çalışabilir
- **Geniş Kütüphane Desteği**: Zengin standart kütüphaneler ve framework'ler
- **Kolay Öğrenilebilir**: Temiz ve okunabilir sözdizimi
- **Aktif Geliştirme**: Microsoft tarafından sürekli güncellenir ve geliştirilir

### C# ile Neler Yapılabilir?

- 🌐 **Web Uygulamaları** (ASP.NET Core)
- 🖥️ **Masaüstü Uygulamaları** (WPF, WinForms)
- 📱 **Mobil Uygulamalar** (Xamarin, .NET MAUI)
- 🎮 **Oyun Geliştirme** (Unity)
- ☁️ **Bulut Uygulamaları** (Azure)
- 🔧 **Mikroservisler** ve **API'ler**
- 🤖 **Yapay Zeka ve Makine Öğrenimi**

## .NET Nedir?

**.NET** (dot NET olarak okunur), Microsoft tarafından geliştirilen açık kaynaklı bir geliştirme platformudur. C# dilinin çalıştığı çalışma zamanı (runtime) ortamıdır.

### .NET'in Bileşenleri

#### 1. .NET Runtime (CLR - Common Language Runtime)
- Programların çalıştığı sanal makine
- Bellek yönetimi (Garbage Collection)
- Güvenlik ve tip kontrolü
- Platform bağımsız çalışma

#### 2. .NET Framework Kütüphaneleri
- Hazır sınıflar ve fonksiyonlar
- Koleksiyonlar, dosya işlemleri, ağ işlemleri
- Veritabanı erişimi, XML/JSON işlemleri
- Web geliştirme araçları

#### 3. Derleyici (Compiler)
- C# kodunu makine koduna çevirir
- IL (Intermediate Language) koduna derler
- JIT (Just-In-Time) derleme ile çalışma zamanında optimize eder

### .NET Sürümleri

#### .NET Framework (Eski)
- Sadece Windows için
- Artık yeni projeler için önerilmiyor

#### .NET Core / .NET (Modern)
- **Çapraz platform** (Windows, Linux, macOS)
- **Açık kaynaklı**
- **Yüksek performans**
- **Modüler yapı**
- Güncel sürümler: .NET 6, .NET 7, .NET 8, .NET 9

### .NET'in Avantajları

✅ **Platform Bağımsızlık**: Bir kere yaz, her yerde çalıştır  
✅ **Yüksek Performans**: Optimize edilmiş runtime  
✅ **Güvenlik**: Güçlü tip kontrolü ve güvenlik özellikleri  
✅ **Geniş Topluluk**: Büyük ve aktif geliştirici topluluğu  
✅ **Microsoft Desteği**: Kurumsal düzeyde destek  
✅ **Açık Kaynak**: GitHub'da açık kaynak olarak geliştirilir  

## C# ve .NET İlişkisi

```
C# (Programlama Dili)
    ↓
.NET (Platform/Runtime)
    ↓
İşletim Sistemi (Windows/Linux/macOS)
```

- **C#** = Programlama dili (sözdizimi, kurallar)
- **.NET** = Çalışma ortamı (runtime, kütüphaneler, araçlar)
- C# kodu .NET platformunda çalışır
- .NET, C# dışında F#, VB.NET gibi dilleri de destekler

## Örnek C# Kodu

```csharp
using System;

namespace BasicsOfCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, C# ve .NET!");
            
            int sayi = 42;
            string mesaj = "C# öğreniyorum";
            
            Console.WriteLine($"Sayı: {sayi}");
            Console.WriteLine($"Mesaj: {mesaj}");
        }
    }
}
```

## Neden C# ve .NET Öğrenmeliyim?

1. **İş Piyasası**: Kurumsal yazılım geliştirmede yaygın kullanım
2. **Kariyer Fırsatları**: Yüksek maaşlı iş imkanları
3. **Microsoft Ekosistemi**: Azure, Office 365, SharePoint gibi teknolojilerle entegrasyon
4. **Modern Geliştirme**: Web, mobil, bulut uygulamaları için güçlü araçlar
5. **Topluluk Desteği**: Geniş topluluk ve kaynak
6. **Sürekli Gelişim**: Düzenli güncellemeler ve yeni özellikler

## Öğrenme Yolculuğu

Bu eğitim serisinde şunları öğreneceksiniz:

1. ✅ **Temel Kavramlar** - Veri tipleri, değişkenler
2. 🔄 **Kontrol Yapıları** - If/else, döngüler
3. 📦 **Nesne Yönelimli Programlama** - Sınıflar, kalıtım
4. 🔧 **Gelişmiş Özellikler** - LINQ, async/await
5. 🌐 **Pratik Uygulamalar** - Web API, veritabanı

## Kaynaklar

- [Microsoft C# Dokümantasyonu](https://learn.microsoft.com/tr-tr/dotnet/csharp/)
- [.NET Resmi Sitesi](https://dotnet.microsoft.com/)
- [C# Programlama Kılavuzu](https://learn.microsoft.com/tr-tr/dotnet/csharp/programming-guide/)

---

**Not:** Bu eğitim serisi, C# ve .NET'i sıfırdan ileri seviyeye kadar öğrenmeniz için tasarlanmıştır. Her konu pratik örneklerle desteklenmiştir.

