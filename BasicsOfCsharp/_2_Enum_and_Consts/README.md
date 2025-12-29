# Enum ve Consts (Sabitler)

## Enum (Enumeration) Nedir?

**Enum**, sabit değerlerin isimlendirilmiş bir listesidir. Belirli bir değişkenin alabileceği değerleri sınırlandırmak ve kodun okunabilirliğini artırmak için kullanılır.

### Enum Tanımlama

```csharp
enum Days
{
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6
}
```

### Enum Kullanımı

```csharp
// Enum değerine erişim
Console.WriteLine(Days.Monday);  // Monday

// Enum değişkeni tanımlama
Days today = Days.Monday;
Days weekend = Days.Saturday;
```

### Enum Özellikleri

- ✅ **Tip Güvenliği**: Sadece tanımlı değerler kullanılabilir
- ✅ **Okunabilirlik**: Sayısal değerler yerine anlamlı isimler
- ✅ **Bakım Kolaylığı**: Değerler tek bir yerde tanımlanır
- ✅ **Varsayılan Değerler**: İlk eleman 0'dan başlar (belirtilmezse)

### Enum Örnekleri

```csharp
// Haftanın günleri
enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

// Durumlar
enum Status { Active, Inactive, Pending, Deleted }

// Öncelik seviyeleri
enum Priority { Low = 1, Medium = 2, High = 3, Critical = 4 }

// Renkler
enum Color { Red, Green, Blue, Yellow }
```

### Enum ile Çalışma

```csharp
// Enum değerini integer'a çevirme
int dayValue = (int)Days.Monday;  // 1

// Integer'ı enum'a çevirme
Days day = (Days)3;  // Wednesday

// Enum kontrolü
if (today == Days.Monday)
{
    Console.WriteLine("Pazartesi!");
}
```

## Const (Sabit) Nedir?

**Const**, değeri program çalışırken değiştirilemeyen değişkenlerdir. Derleme zamanında değeri bilinmeli ve sabit olmalıdır.

### Const Tanımlama

```csharp
const double pi = 3.14;
const int maxUsers = 100;
const string appName = "MyApplication";
const bool isActive = true;
```

### Const Özellikleri

- ✅ **Değiştirilemez**: Değer atandıktan sonra değiştirilemez
- ✅ **Derleme Zamanı**: Değer derleme zamanında bilinmelidir
- ✅ **Performans**: Derleyici tarafından optimize edilir
- ✅ **Bellek**: Her kullanımda aynı değer kullanılır

### Const Kullanım Örnekleri

```csharp
// Matematiksel sabitler
const double PI = 3.14159265359;
const double E = 2.71828;

// Uygulama sabitleri
const int MAX_RETRY_COUNT = 3;
const string API_BASE_URL = "https://api.example.com";
const int TIMEOUT_SECONDS = 30;

// Sabit mesajlar
const string WELCOME_MESSAGE = "Hoş geldiniz!";
const string ERROR_MESSAGE = "Bir hata oluştu!";
```

### Const vs Readonly

| Özellik | const | readonly |
|---------|-------|----------|
| **Değer Atama** | Tanımlandığı yerde | Constructor'da da atanabilir |
| **Derleme Zamanı** | Evet | Hayır (çalışma zamanı) |
| **Hesaplanabilir** | Hayır | Evet |
| **Sınıf Üyesi** | Statik gibi davranır | Instance'a özgü olabilir |

```csharp
// const örneği
const double PI = 3.14;

// readonly örneği
readonly DateTime createdDate = DateTime.Now;  // const ile yapılamaz!
```

## Enum ve Const Birlikte Kullanım

```csharp
public class Configuration
{
    // Const sabitler
    public const int MAX_USERS = 100;
    public const string APP_NAME = "MyApp";
    
    // Enum tanımlama
    public enum UserRole
    {
        Admin = 1,
        User = 2,
        Guest = 3
    }
    
    public void Example()
    {
        UserRole role = UserRole.Admin;
        Console.WriteLine($"Max Users: {MAX_USERS}");
        Console.WriteLine($"Role: {role}");
    }
}
```

## İsimlendirme Kuralları

### Enum İsimlendirme
- ✅ **PascalCase** kullanın: `Days`, `UserStatus`
- ✅ Tekil isim kullanın: `Day` değil `Days`
- ✅ Anlamlı isimler seçin

### Const İsimlendirme
- ✅ **BÜYÜK_HARF** kullanın: `PI`, `MAX_USERS`
- ✅ Kelimeler arası alt çizgi: `API_BASE_URL`
- ✅ Anlamlı ve açıklayıcı isimler

## Örnek Kod

```csharp
public class _2_Enum_and_Consts
{
    public void Run()
    {
        Days days = new Days();
        const double pi = 3.14;

        Console.WriteLine(Days.Monday);  // Monday
        Console.WriteLine(pi);           // 3.14
    }

    enum Days
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }
}
```

## Pratik Kullanım Senaryoları

### Enum Kullanım Senaryoları
- 📅 Haftanın günleri, aylar
- 🎯 Durumlar (Active, Inactive, Pending)
- 🔐 Kullanıcı rolleri (Admin, User, Guest)
- 🎨 Renkler, temalar
- 📊 Sipariş durumları (New, Processing, Shipped, Delivered)

### Const Kullanım Senaryoları
- 🔢 Matematiksel sabitler (PI, E)
- ⚙️ Yapılandırma değerleri (MAX_USERS, TIMEOUT)
- 📝 Sabit mesajlar
- 🔗 API URL'leri
- 📏 Ölçü birimleri

## Özet

- **Enum**: Sabit değerlerin isimlendirilmiş listesi, tip güvenliği sağlar
- **Const**: Değiştirilemez sabit değerler, derleme zamanında bilinmelidir
- **Enum** okunabilirliği artırır, **Const** performansı optimize eder
- Her ikisi de kodun bakımını kolaylaştırır ve hataları önler

## Önemli Notlar

⚠️ **Enum**: Varsayılan olarak `int` tipindedir, farklı tipler belirtilebilir  
⚠️ **Const**: Sadece temel veri tipleri ve string için kullanılabilir  
⚠️ **Const**: Değer derleme zamanında bilinmelidir (hesaplanamaz)  
✅ Her ikisi de kodun okunabilirliğini ve bakımını kolaylaştırır

