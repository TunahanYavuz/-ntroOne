using Methods;

Product urun1 = new Product();
urun1.adi = "Elma";
urun1.Id = 1;
urun1.fiyati = 30;
urun1.aciklamasi = "Kavun elması";
Product urun2 = new Product();
urun2.Id= 2;
urun2.fiyati = 20;
urun2.adi = "Süt";
urun2.aciklamasi = "İnek Sütü";
Product[] urunler = new Product[] {urun1,urun2};
foreach (Product product in urunler)
    Console.WriteLine(product.Id+" "+product.adi+" "+product.fiyati+" "+product.aciklamasi);
Console.WriteLine("-------Metodlar-------");

SepetMenager sepetmenager = new SepetMenager();
sepetmenager.Ekle(urun1);
sepetmenager.Ekle(urun2);
sepetmenager.Ekle2("Armut" , "yeşil armut");