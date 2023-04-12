using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunKMVCWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
           var kategoriler = new List<Category>()
            {

                new Category {Name = "Kamera", Description="Kamera Ürünleri"},
                new Category { Name = "Bilgisayar", Description = "Bilgisayar Ürünleri" },
                new Category { Name = "Telefon", Description = "Telefon Ürünleri" },
                new Category { Name = "Elektronik", Description = "Elektronik Ürünleri" },
                new Category { Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri" }

            };

            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product {Name ="Canon EOS 2000D + EF-S 18-55mm", Description="24,1 Megapiksel EOS 2000D ile düşük ışık koşullarında bile zahmetsizce detaylı DSLR kalitesinde fotoğraflar ve sinematik Full HD filmler çekin.\r\n Wi-Fi*, NFC** ve Canon Connect uygulaması ile anında uzaktan çekim yapın ve paylaşın. - 24,1 MP APS-C CMOS Sensör - Wi-Fi & NFC Bağlantı - Full HD Video Çekimi - Saniyede 3 Kare Çekim Hızı - 9 adet AF Noktası"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1 , IsHome=true },
                new Product {Name ="Canon EOS 600D 18-55 ", Description="Hassas ve kaliteli fotoğraf çekimleri ve video kayıtlar gerçekleştirmek için dizayn edilen Canon EOS 600D 18-55 IS II dijital fotoğraf makinesi,\r\n pratik ve konforlu kullanımıyla beğeni kazanıyor. Üstün teknolojisi ve zengin teknik özellikleriyle dikkat çeken dijital fotoğraf makinesi"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1 },
                new Product {Name ="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi", Description="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi (İthalatçı Garantili)"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1, IsHome=true },
                new Product {Name ="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi", Description="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi (İthalatçı Garantili)"  ,Price=1200 , Stock=500 , IsApproved=false , CategoryId=1, IsHome=true },
                new Product {Name ="Canon EOS 600D 18-55 ", Description="Hassas ve kaliteli fotoğraf çekimleri ve video kayıtlar gerçekleştirmek için dizayn edilen Canon EOS 600D 18-55 IS II dijital fotoğraf makinesi,\r\n pratik ve konforlu kullanımıyla beğeni kazanıyor. Üstün teknolojisi ve zengin teknik özellikleriyle dikkat çeken dijital fotoğraf makinesi"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1 },

                new Product {Name ="ALIENWARE M15 RYZEN EDITION R5 DİZÜSTÜ OYUN BİLGİSAYARI", Description="İster boş zamanınızda rahat bir oyun oynuyor veya savaşın tam ortasında olun, sorunsuz oyun deneyimi sayesinde asla hiçbir kritik detayı kaçırmayacaksınız.\r\n En yeni m15, hassas mühendislik kararlarımız sayesinde 165 Hz ve daha hızlı ekranlarla inanılmaz derecede hızlı görüntü yenilemesi sunar. Ancak tabi ki biz bununla yetinmedik. En yeni m15, ekranınızın yenileme hızını, yüksek hızlı aksiyonlar sırasında daha akıcı bir oyun deneyimi için grafik kartınızın sahip olduğu performansla senkronize etmek için NVIDIA(R) G-SYNC(R) teknolojisini kullanır. Bu özellik, yalnızca isteğe bağlı QHD 240 Hz panelde mevcuttur."  ,Price=4500 , Stock=1200 , IsApproved=true , CategoryId=2 , IsHome=true},
                new Product {Name ="ALİENWARE M15 R7 DİZÜSTÜ OYUN BİLGİSAYARI ", Description="AMD Ryzen™ 6000 serisi işlemciler ve Alienware Cryo-tech™ soğutma teknolojisine sahip Alienware'in en güçlü AMD 15 inç dizüstü bilgisayarı."  ,Price=3400 , Stock=0 , IsApproved=false , CategoryId=2 },
                new Product {Name ="ALIENWARE M15 RYZEN EDITION R5 DİZÜSTÜ OYUN BİLGİSAYARI", Description="İster boş zamanınızda rahat bir oyun oynuyor veya savaşın tam ortasında olun, sorunsuz oyun deneyimi sayesinde asla hiçbir kritik detayı kaçırmayacaksınız.\r\n En yeni m15, hassas mühendislik kararlarımız sayesinde 165 Hz ve daha hızlı ekranlarla inanılmaz derecede hızlı görüntü yenilemesi sunar. Ancak tabi ki biz bununla yetinmedik. En yeni m15, ekranınızın yenileme hızını, yüksek hızlı aksiyonlar sırasında daha akıcı bir oyun deneyimi için grafik kartınızın sahip olduğu performansla senkronize etmek için NVIDIA(R) G-SYNC(R) teknolojisini kullanır. Bu özellik, yalnızca isteğe bağlı QHD 240 Hz panelde mevcuttur."  ,Price=4500 , Stock=1200 , IsApproved=true , CategoryId=2, IsHome=true },
                new Product {Name ="ALİENWARE M15 R7 DİZÜSTÜ OYUN BİLGİSAYARI ", Description="AMD Ryzen™ 6000 serisi işlemciler ve Alienware Cryo-tech™ soğutma teknolojisine sahip Alienware'in en güçlü AMD 15 inç dizüstü bilgisayarı."  ,Price=3400 , Stock=700 , IsApproved=true , CategoryId=2 , IsHome=true},

                new Product {Name ="Apple iPhone 11 128 GB Beyaz Cep Telefonu", Description="Apple iPhone 11 128 GB Beyaz Cep Telefonu"  ,Price=5600 , Stock=1200 , IsApproved=true , CategoryId=3 },
                new Product {Name ="Samsung Galaxy M13 128 GB 4 GB Ram ", Description="Samsung Galaxy M13, uygun fiyatının yanı sıra içerdiği teknik ayrıntılarla da kullanıcılarının beğenisini kazanır. Geliştirilmiş sistemi, güçlü yonga seti,\r\n iyi düşünülmüş kamera düzeni ve kasanın altında yer alan büyük pil ile performans söz konusu olduğunda beklentileri karşılamayı başarır. Samsung Galaxy M13 128 GB 4 GB Ram (Samsung Türkiye Garantili) batarya kapasitesi sayesinde günlük yaşantınızda ihtiyaç duyduğunuz kullanım süresini elde etmenize imkan tanır. Ekran detaylarıyla da dikkatleri üzerinde toplayan model,"  ,Price=3400 , Stock=0 , IsApproved=false , CategoryId=3, },
                new Product {Name ="Tcl 30 Plus 128GB 4gb Ram", Description="TCL 30 Plus 128GB 4GB RAM Siyah Cep Telefonu – TCL Türkiye Garantili Tcl 30 Plus 128GB 4gb Ram (Tcl Türkiye Garantili) Özellikleri Dahili Hafıza128 GB \r\nEkran Boyut Aralığı6 inç ve ÜzeriEkran Boyutu6,7 inç Garanti TipiResmi Distribütör GarantiliKablosuz ŞarjYokKamera Çözünürlüğü Aralığı20 MP ve ÜzeriKamera Çözünürlüğü50 MP + 2 MP + 2 MPÖn (Selfie) Kamera Aralığı8 - 13,9 MPÖn (Selfie) Kamera13 MPPil Gücü Aralığı5000 mAh ve ÜzeriPil Gücü5010 mAhRAM Kapasitesi4 GBYüz TanımaVarDiğerGaranti Süresi (Ay)24Yurt Dışı SatışYok"  ,Price=3000 , Stock=500 , IsApproved=true , CategoryId=3 , IsHome=true},
                new Product {Name ="Vivo Y35 256 GB 8 GB Ram", Description="Vivo Y35 256 GB 8 GB Ram"  ,Price=2300 , Stock=200 , IsApproved=false , CategoryId=3 },

                new Product {Name ="Onvo OV42250 42\" 106 Ekran Uydulu Full HD Android Smart LED TV", Description="Onvo OV42250 LED TV şık tasarımı ve gelişmiş teknik özellikleriyle dikkat çeker. A+ sınıfı enerji tasarruflu bir ürün olan bu TV,\r\n seyir deneyiminizi iyileştirir. OV42250 TV özellikleri, her bütçeye uygun fiyatları ve kullanımı ile tercih edilen televizyonlardan biridir. Ürünü inceleyerek evinizin veya ofisinizin bir köşesinde bu televizyon için yer yaratmak isteyebilirsiniz."  ,Price=4500 , Stock=700 , IsApproved=true , CategoryId=4 ,IsHome=true },
                new Product {Name ="Blaupunkt BL55145G UHD Smart Uydu Alıcılı LED Tv ", Description="Daha fazlasını istiyorsanız, UHD 4K teknolojisini tercih edin! Android 9 Google tarafından geliştirilen Android sistem, Android TV’lerle evinize taşınıyor! \r\nBu sayede ,TV’nizi telefon ya da tabletinizle kontrol edebilirsiniz. Android TV ile en yeni filmler, diziler, TV programları ve oyunlar elinizin altında olacak!"  ,Price=5000 , Stock=0 , IsApproved=false , CategoryId=4, },
                new Product {Name ="Samsung 55BU8000 55\" 139 Ekran Uydu Alıcılı Crystal 4K Ultra HD Smart LED TV", Description="Kaliteli tasarımlarıyla teknoloji dünyasında yerini alan Samsung markası yeni nesil televizyon tasarımlarıyla göz doldurur.\r\n Samsung 55BU8000 55\" 139 Ekran Uydu Alıcılı Crystal 4K Ultra HD Smart LED TV ultra ince profil tasarımı sayesinde eşlik ettiği alana şıklık katar."  ,Price=6500 , Stock=800 , IsApproved=true , CategoryId=4 , IsHome=true},
                new Product {Name ="Vestel 50UA9630 50\" 126 Ekran Uydu Alıcılı 4K Ultra HD Android Smart LED TV", Description="Vestel 50UA9630 50\" 126 Ekran Android Smart 4K Ultra HD Led TV"  ,Price=2300 , Stock=150 , IsApproved=true , CategoryId=4 },

                new Product {Name ="Samsung RT46K6000WW/TR No-Frost Buzdolabı", Description="\r\nSamsung RT46K6000WW/TR No-Frost Buzdolabı"  ,Price=12000 , Stock=700 , IsApproved=true , CategoryId=5 ,IsHome=true },
                new Product {Name ="Finlux Ultra Sessiz 92120 C Enerji Sınıfı 9 Kg 1200 Devir Çamaşır Makinası", Description="\r\n❖ 9 kg, 1200 devir ❖ Inverter Motor ❖ LED Ekran Kontrol Paneli ❖ Beyaz Renk ❖ Geniş Kapak ❖ Kristal İnci Kazan ❖ Zaman Erteleme Ayar Düğmesi ❖ 15 Program ❖ Hijyen Programı ❖ Hızlı 15 Dakika / 30° Programı ❖ Kolay Ütü ❖ Sıcaklık Ayarı / Devir Ayarı Fonksiyonu ❖ Gecikmeli Başlat Fonksiyonu ❖ Hızlı Yıkama Fonksiyonu ❖ Elde Yıkama ❖ Ücretsiz Kurulum Vardır"  ,Price=5000 , Stock=0 , IsApproved=false , CategoryId=5 },
                new Product {Name ="Samsung RB50RS334SA/TR No-Frost Buzdolabı", Description="Samsung markası Güney Kore merkezli olup tüketiciye elektronik ve teknolojik ürünleri geniş bir yelpazede sunmaktadır. Buzdolabı çeşitlerinde çığır açmanın yanı sıra çamaşır makineleri, akıllı cep telefonları ve yüksek çözünürlüğe sahip olan televizyonlarıyla günümüzde tercih edilen markalar arasında ilk sırada yerini almıştır."  ,Price=6500 , Stock=550 , IsApproved=true , CategoryId=5 , IsHome=true},
                new Product {Name ="Altus AL 9103 D 9 kg 1000 Devir Çamaşır Makinesi", Description="Altus AL 9103 D çamaşır makinesi geniş iç hacmiyle işlerinizi kolaylaştırır, ev işleriniz arasında dinlenmek için vakit bulabilirsiniz. Yıllık su ve enerji tüketimini minimuma indirmeyi hedefler. En az enerjiyi kullanarak yüksek verim elde eder ve otomatik su ayarlama sistemi sayesinde bütçenize katkıda bulunur. Kaynak israfının önüne geçerek tasarruf yapmanızı sağlar."  ,Price=3500 , Stock=0 , IsApproved=false , CategoryId=5 }



            };
            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}