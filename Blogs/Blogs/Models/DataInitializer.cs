using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Blogs.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {

               new Kategori(){KategoriAd="C#"},
                      new Kategori(){KategoriAd="PHP"},
                             new Kategori(){KategoriAd="JAVA"},

            };
            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);
            }
            context.SaveChanges();

            var makale = new List<Makale>()
            {

                new Makale(){Baslik="C# Dilindeki Temel Veri Türleri",Aciklama="Öncelikle veri tipi nedir ve ne gibi bir görevi vardır sorularının cevabını arayalım. C# dili için her sınıf bir veri tipidir. Klasik programlama dillerinde karakterler, tamsayılar, kesirli sayılar ve boolean gibi ilkel veri tipleri dile gömülüdür ve her bir veri tipi bir anahtar sözcükle ifade edilmektedir. Fakat C# gibi nesne yönelimli programlama dillerinde her sınıf soyut bir veri yapısını göstermektedir. Bundan dolayı C# ilkel veri tiplerinden arındırılmış haldedir.",Resim="a1.png",YayinTarih=Convert.ToDateTime("2020-06-06"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="talhademir"},
                 new Makale(){Baslik="C# Akış Kontrol Mekanizmaları",Aciklama="Program yazarken çoğu zaman herşey ak ve kara gibi net olmaz, çoğu zaman çeşitli koşullara göre farklı komutlar çalıştırmamız gerekir. Benzer şekilde çoğu komutun da yalnızca bir kez çalıştırılması bizim için yeterli gelmez, belli koşulları sağladığı sürece sürekli çalıştırılmasını istediğimiz komutlar olabilir. İşte bu gibi durumlar için C#'ta akış kontrol mekanizmaları vardır. Aslında en basitinden en karmaşığına kadar bütün programlama dillerinde bu mekanizmalar mevcuttur ve programlama dillerinin en önemli ögelerinden birisidir.",Resim="a1.png",YayinTarih=Convert.ToDateTime("2020-06-05"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="onurafsin"},
                   new Makale(){Baslik="PHP Operatörleri",Aciklama="İki ya da  daha fazla karekteri ard arda eklemek için kullanacağın bu operatörü aslında bir kaç ders öncesinde örnek vererek kullandım . Orada anlamamış olabilirsin . Ama şimdi bu eksikliği giderecğiz hiç problem yok kardeşim .Yazıları  ve diğerdeğerleri yan yana birleştirmek için ve başka değerlere eklemek için /. nokta operatörünü kullanırız hemen bir örnekte gösterelim",Resim="a4.jpeg",YayinTarih=Convert.ToDateTime("2020-06-05"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="onurafsin"},

            };
            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();
            base.Seed(context); 
        }
    }
}