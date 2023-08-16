Console.WriteLine("Hello, World!");
string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
bool sistemeGirisYapmısmi = true;
double dolarDun = 27.10;
double dolarBugün = 27.11;

if (dolarDun>dolarBugün)
{
    Console.WriteLine( "Azalış butonu");
}

else if (dolarBugün>dolarDun)
{
    Console.WriteLine( "Artış butonu");
}

else
{
    Console.WriteLine("Değişmedi");
}


if (sistemeGirisYapmısmi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
    Console.WriteLine(kategoriEtiketi);
}

else
{
    Console.WriteLine("Giriş yap butonu");
}
