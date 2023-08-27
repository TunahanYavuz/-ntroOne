// See https://aka.ms/new-console-template for more information
string isimler = "Tunahan";
string baslik = "ÖSYM Aday İşlemleri";
bool sistemeGiris = false;
string girisYapmis = "ÖSYM Aday İşlemlerine Hoş Geldiniz";
string girisYapmamis = "Lütfen Giriş Yapınız";
string pozitif = "Pozitif Simgesi";
string negatif = "Negatif Simgesi";
double siralamaOnce = 164.321;
double siralamaSimdi = 100.000;
Console.WriteLine(baslik);
Console.WriteLine(isimler);
string bos = " ";
Console.WriteLine(baslik + bos + isimler);
if (sistemeGiris == true)
{
    Console.WriteLine(girisYapmis);
}
else
{
    Console.WriteLine(girisYapmamis);
}
if (siralamaSimdi < siralamaOnce)
{
    Console.WriteLine(pozitif);
}
else if (siralamaSimdi>siralamaOnce)
{
    Console.WriteLine(negatif);
}
