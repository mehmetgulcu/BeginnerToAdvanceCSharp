# C# Veri Tipleri ve Değişkenler

## Giriş

C# programlamada, verileri saklamak ve işlemek için **değişkenler** (variables) kullanırız. Her değişkenin bir **veri tipi** (data type) vardır ve bu tip, değişkende ne tür veri saklanabileceğini belirler.

## Değişken Nedir?

Değişken, program çalışırken değeri değiştirilebilen bir bellek alanıdır. Değişkenler, verileri geçici olarak saklamak için kullanılır.

### Değişken Tanımlama

C#'ta değişken tanımlamak için aşağıdaki sözdizimi kullanılır:

```csharp
veriTipi değişkenAdı = değer;
```

**Örnek:**
```csharp
int sayi = 42;
string metin = "Merhaba Dünya";
bool durum = true;
```

## Temel Veri Tipleri (Primitive Types)

### 1. Tam Sayı Tipleri (Integer Types)

#### `int` (Integer)
- **Aralık:** -2,147,483,648 ile 2,147,483,647 arası
- **Boyut:** 32 bit (4 byte)
- **Varsayılan Değer:** 0

```csharp
int yas = 25;
int sayi = -100;
int toplam = 0;
```

#### `long` (Long Integer)
- **Aralık:** -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arası
- **Boyut:** 64 bit (8 byte)
- **Varsayılan Değer:** 0L

```csharp
long buyukSayi = 123456789012345L;
```

#### `short` (Short Integer)
- **Aralık:** -32,768 ile 32,767 arası
- **Boyut:** 16 bit (2 byte)
- **Varsayılan Değer:** 0

```csharp
short kucukSayi = 100;
```

#### `byte`
- **Aralık:** 0 ile 255 arası
- **Boyut:** 8 bit (1 byte)
- **Varsayılan Değer:** 0

```csharp
byte veri = 255;
```

### 2. Ondalıklı Sayı Tipleri (Floating Point Types)

#### `float` (Single Precision)
- **Aralık:** Yaklaşık ±1.5 × 10⁻⁴⁵ ile ±3.4 × 10³⁸
- **Hassasiyet:** 7 haneye kadar
- **Boyut:** 32 bit (4 byte)
- **Varsayılan Değer:** 0.0f
- **Not:** Değer sonuna `f` veya `F` eklenmelidir

```csharp
float pi = 3.14f;
float sicaklik = 25.5F;
```

#### `double` (Double Precision)
- **Aralık:** Yaklaşık ±5.0 × 10⁻³²⁴ ile ±1.7 × 10³⁰⁸
- **Hassasiyet:** 15-16 haneye kadar
- **Boyut:** 64 bit (8 byte)
- **Varsayılan Değer:** 0.0d
- **Not:** C#'ta ondalıklı sayılar için varsayılan tiptir

```csharp
double pi = 3.141592653589793;
double fiyat = 99.99;
double oran = 0.15d;
```

#### `decimal` (High Precision)
- **Aralık:** ±1.0 × 10⁻²⁸ ile ±7.9228 × 10²⁸
- **Hassasiyet:** 28-29 haneye kadar
- **Boyut:** 128 bit (16 byte)
- **Varsayılan Değer:** 0.0m
- **Not:** Finansal hesaplamalar için idealdir. Değer sonuna `m` veya `M` eklenmelidir

```csharp
decimal para = 1234.56m;
decimal vergi = 0.18M;
```

### 3. Metin Tipleri (Text Types)

#### `char` (Character)
- **Aralık:** Tek bir Unicode karakter
- **Boyut:** 16 bit (2 byte)
- **Varsayılan Değer:** '\0'

```csharp
char harf = 'A';
char sembol = '@';
char turkceKarakter = 'ğ';
```

#### `string` (String)
- **Aralık:** Sınırsız karakter dizisi
- **Boyut:** Değişken (her karakter 2 byte)
- **Varsayılan Değer:** null
- **Not:** C#'ta string bir referans tipidir (reference type)

```csharp
string isim = "Ahmet";
string mesaj = "Merhaba, C#!";
string bosString = "";
string nullString = null;
```

### 4. Mantıksal Tip (Boolean Type)

#### `bool` (Boolean)
- **Değerler:** `true` veya `false`
- **Boyut:** 8 bit (1 byte)
- **Varsayılan Değer:** false

```csharp
bool aktif = true;
bool tamamlandi = false;
bool kontrol = (5 > 3); // true
```

## Değişken İsimlendirme Kuralları

1. **Geçerli Karakterler:** Harf, rakam ve alt çizgi (_)
2. **Başlangıç:** Harf veya alt çizgi ile başlamalı (rakam ile başlayamaz)
3. **Büyük/Küçük Harf Duyarlılığı:** `isim` ve `Isim` farklı değişkenlerdir
4. **Rezerve Kelimeler:** C# anahtar kelimeleri kullanılamaz (int, string, class, vb.)
5. **Anlamlı İsimler:** Değişken isimleri ne işe yaradığını açıklamalı

**İyi Örnekler:**
```csharp
int kullaniciYasi = 25;
string kullaniciAdi = "Ahmet";
bool isAktif = true;
```

**Kötü Örnekler:**
```csharp
int x = 25;              // Anlamsız
string a1 = "Ahmet";     // Anlamsız
bool b = true;           // Anlamsız
```

## İsimlendirme Konvansiyonları

### Camel Case (camelCase)
- İlk kelime küçük harfle başlar
- Sonraki kelimelerin ilk harfi büyük
- Yerel değişkenler ve parametreler için kullanılır

```csharp
string kullaniciAdi = "Ahmet";
int toplamUrunSayisi = 100;
bool isKayitli = true;
```

### Pascal Case (PascalCase)
- Her kelimenin ilk harfi büyük
- Sınıf, metod ve özellik isimleri için kullanılır

```csharp
public class KullaniciBilgisi { }
public void HesaplaToplam() { }
public int UrunSayisi { get; set; }
```

## Değişken Kapsamı (Scope)

Değişkenler, tanımlandıkları blok içinde geçerlidir.

```csharp
public void OrnekMetod()
{
    int yerelDegisken = 10;  // Sadece bu metod içinde geçerli
    
    if (true)
    {
        int blokIcindekiDegisken = 20;  // Sadece bu if bloğu içinde geçerli
        Console.WriteLine(yerelDegisken);  // OK
    }
    
    // Console.WriteLine(blokIcindekiDegisken);  // HATA! Bu değişken burada erişilemez
}
```

## Değişken Tanımlama Yöntemleri

### 1. Açık Tip Belirtme (Explicit Typing)
```csharp
int sayi = 42;
string metin = "Merhaba";
bool durum = true;
```

### 2. Örtük Tip Belirtme (Implicit Typing - var)
```csharp
var sayi = 42;           // int olarak algılanır
var metin = "Merhaba";   // string olarak algılanır
var durum = true;        // bool olarak algılanır
```

**Not:** `var` kullanırken değişkene mutlaka bir değer atanmalıdır.

### 3. Çoklu Değişken Tanımlama
```csharp
int a = 1, b = 2, c = 3;
string isim = "Ahmet", soyisim = "Yılmaz";
```

## Sabitler (Constants)

Değeri değiştirilemeyen değişkenlerdir. `const` anahtar kelimesi ile tanımlanır.

```csharp
const double PI = 3.14159;
const int MAX_SAYI = 100;
const string UYGULAMA_ADI = "MyApp";

// PI = 3.14;  // HATA! Sabit değer değiştirilemez
```

**Sabit İsimlendirme:** Genellikle BÜYÜK_HARF ile yazılır ve kelimeler alt çizgi ile ayrılır.

## readonly Değişkenler

`readonly` anahtar kelimesi ile tanımlanan değişkenler, sadece tanımlandığı yerde veya constructor'da değer alabilir.

```csharp
public class Ornek
{
    private readonly int sayi;
    
    public Ornek()
    {
        sayi = 10;  // Constructor'da değer atanabilir
    }
    
    // public void Degistir() { sayi = 20; }  // HATA! readonly değiştirilemez
}
```

## Nullable Tipler

Değer tipleri (int, bool, double, vb.) normalde null olamaz. Ancak `?` operatörü ile nullable yapılabilir.

```csharp
int? nullableInt = null;
bool? nullableBool = null;
double? nullableDouble = null;

// Null kontrolü
if (nullableInt.HasValue)
{
    int deger = nullableInt.Value;
    // veya
    int deger2 = nullableInt ?? 0;  // Null ise 0 kullan
}
```

## Örnek Kod

```csharp
public void Run()
{
    // Tam sayı tipleri
    int yas = 25;
    long buyukSayi = 123456789012345L;
    short kucukSayi = 100;
    byte veri = 255;
    
    // Ondalıklı sayı tipleri
    float piFloat = 3.14f;
    double piDouble = 3.141592653589793;
    decimal para = 1234.56m;
    
    // Metin tipleri
    char harf = 'A';
    string isim = "Ahmet";
    
    // Mantıksal tip
    bool aktif = true;
    
    // Çıktı
    Console.WriteLine($"Yaş: {yas}");
    Console.WriteLine($"İsim: {isim}");
    Console.WriteLine($"Aktif: {aktif}");
    Console.WriteLine($"Para: {para:C}");  // Para formatı
}
```

## Özet

- **Değişkenler**, verileri saklamak için kullanılır
- Her değişkenin bir **veri tipi** vardır
- C#'ta **temel veri tipleri**: int, long, float, double, decimal, char, string, bool
- Değişken isimleri **anlamlı** ve **konvansiyonlara uygun** olmalıdır
- `const` ile **sabitler**, `readonly` ile **salt okunur değişkenler** tanımlanabilir
- Değer tipleri `?` ile **nullable** yapılabilir

## Pratik Öneriler

1. ✅ Her zaman anlamlı değişken isimleri kullanın
2. ✅ Değişkenleri kullanmadan önce tanımlayın
3. ✅ Uygun veri tipini seçin (örneğin, para için `decimal` kullanın)
4. ✅ Değişken kapsamına dikkat edin
5. ✅ `var` kullanırken dikkatli olun, kodun okunabilirliğini bozmayın
6. ✅ Sabitler için `const` kullanın
7. ✅ Nullable tipleri gerektiğinde kullanın

