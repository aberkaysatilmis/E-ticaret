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
                new Product {Name ="Canon EOS 2000D + EF-S 18-55mm", Description="24,1 Megapiksel EOS 2000D ile düşük ışık koşullarında bile zahmetsizce detaylı DSLR kalitesinde fotoğraflar ve sinematik Full HD filmler çekin. Wi-Fi*, NFC** ve Canon Connect uygulaması ile anında uzaktan çekim yapın ve paylaşın. - 24,1 MP APS-C CMOS Sensör - Wi-Fi & NFC Bağlantı - Full HD Video Çekimi - Saniyede 3 Kare Çekim Hızı - 9 adet AF Noktası"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1 , IsHome=true },
                new Product {Name ="Canon EOS 600D 18-55 ", Description="Hassas ve kaliteli fotoğraf çekimleri ve video kayıtlar gerçekleştirmek için dizayn edilen Canon EOS 600D 18-55 IS II dijital fotoğraf makinesi, pratik ve konforlu kullanımıyla beğeni kazanıyor. Üstün teknolojisi ve zengin teknik özellikleriyle dikkat çeken dijital fotoğraf makinesi"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1 },
                new Product {Name ="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi", Description="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi (İthalatçı Garantili)"  ,Price=1200 , Stock=500 , IsApproved=true , CategoryId=1, IsHome=true },
                new Product {Name ="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi", Description="Canon 1200D + 18-55 Mm Lens Fotoğraf Makinesi (İthalatçı Garantili)"  ,Price=1200 , Stock=500 , IsApproved=false , CategoryId=1, IsHome=true },


                new Product {Name ="ALIENWARE M15 RYZEN EDITION R5 DİZÜSTÜ OYUN BİLGİSAYARI", Description="İster boş zamanınızda rahat bir oyun oynuyor veya savaşın tam ortasında olun, sorunsuz oyun deneyimi sayesinde asla hiçbir kritik detayı kaçırmayacaksınız. En yeni m15, hassas mühendislik kararlarımız sayesinde 165 Hz ve daha hızlı ekranlarla inanılmaz derecede hızlı görüntü yenilemesi sunar. Ancak tabi ki biz bununla yetinmedik. En yeni m15, ekranınızın yenileme hızını, yüksek hızlı aksiyonlar sırasında daha akıcı bir oyun deneyimi için grafik kartınızın sahip olduğu performansla senkronize etmek için NVIDIA(R) G-SYNC(R) teknolojisini kullanır. Bu özellik, yalnızca isteğe bağlı QHD 240 Hz panelde mevcuttur."  ,Price=4500 , Stock=1200 , IsApproved=true , CategoryId=2 , IsHome=true},
                new Product {Name ="ALİENWARE M15 R7 DİZÜSTÜ OYUN BİLGİSAYARI ", Description="AMD Ryzen™ 6000 serisi işlemciler ve Alienware Cryo-tech™ soğutma teknolojisine sahip Alienware'in en güçlü AMD 15 inç dizüstü bilgisayarı."  ,Price=3400 , Stock=0 , IsApproved=false , CategoryId=2 },
                new Product {Name ="ALIENWARE M15 RYZEN EDITION R5 DİZÜSTÜ OYUN BİLGİSAYARI", Description="İster boş zamanınızda rahat bir oyun oynuyor veya savaşın tam ortasında olun, sorunsuz oyun deneyimi sayesinde asla hiçbir kritik detayı kaçırmayacaksınız. En yeni m15, hassas mühendislik kararlarımız sayesinde 165 Hz ve daha hızlı ekranlarla inanılmaz derecede hızlı görüntü yenilemesi sunar. Ancak tabi ki biz bununla yetinmedik. En yeni m15, ekranınızın yenileme hızını, yüksek hızlı aksiyonlar sırasında daha akıcı bir oyun deneyimi için grafik kartınızın sahip olduğu performansla senkronize etmek için NVIDIA(R) G-SYNC(R) teknolojisini kullanır. Bu özellik, yalnızca isteğe bağlı QHD 240 Hz panelde mevcuttur."  ,Price=4500 , Stock=1200 , IsApproved=true , CategoryId=2, IsHome=true },
                new Product {Name ="ALİENWARE M15 R7 DİZÜSTÜ OYUN BİLGİSAYARI ", Description="AMD Ryzen™ 6000 serisi işlemciler ve Alienware Cryo-tech™ soğutma teknolojisine sahip Alienware'in en güçlü AMD 15 inç dizüstü bilgisayarı."  ,Price=3400 , Stock=700 , IsApproved=true , CategoryId=2 , IsHome=true},


                new Product {Name ="Apple iPhone 11 128 GB Beyaz Cep Telefonu", Description="Apple iPhone 11 128 GB Beyaz Cep Telefonu"  ,Price=5600 , Stock=1200 , IsApproved=true , CategoryId=3 },
                new Product {Name ="Samsung Galaxy M13 128 GB 4 GB Ram ", Description="Samsung Galaxy M13, uygun fiyatının yanı sıra içerdiği teknik ayrıntılarla da kullanıcılarının beğenisini kazanır. Geliştirilmiş sistemi, güçlü yonga seti, iyi düşünülmüş kamera düzeni ve kasanın altında yer alan büyük pil ile performans söz konusu olduğunda beklentileri karşılamayı başarır. Samsung Galaxy M13 128 GB 4 GB Ram (Samsung Türkiye Garantili) batarya kapasitesi sayesinde günlük yaşantınızda ihtiyaç duyduğunuz kullanım süresini elde etmenize imkan tanır. Ekran detaylarıyla da dikkatleri üzerinde toplayan model,"  ,Price=3400 , Stock=0 , IsApproved=false , CategoryId=3, IsHome=true },
                new Product {Name ="Tcl 30 Plus 128GB 4gb Ram", Description="TCL 30 Plus 128GB 4GB RAM Siyah Cep Telefonu – TCL Türkiye Garantili Tcl 30 Plus 128GB 4gb Ram (Tcl Türkiye Garantili) Özellikleri Dahili Hafıza128 GBEkran Boyut Aralığı6 inç ve ÜzeriEkran Boyutu6,7 inçGaranti TipiResmi Distribütör GarantiliKablosuz ŞarjYokKamera Çözünürlüğü Aralığı20 MP ve ÜzeriKamera Çözünürlüğü50 MP + 2 MP + 2 MPÖn (Selfie) Kamera Aralığı8 - 13,9 MPÖn (Selfie) Kamera13 MPPil Gücü Aralığı5000 mAh ve ÜzeriPil Gücü5010 mAhRAM Kapasitesi4 GBYüz TanımaVarDiğerGaranti Süresi (Ay)24Yurt Dışı SatışYok"  ,Price=3000 , Stock=500 , IsApproved=true , CategoryId=3 , IsHome=true},
                new Product {Name ="Vivo Y35 256 GB 8 GB Ram", Description="Vivo Y35 256 GB 8 GB Ram"  ,Price=2300 , Stock=200 , IsApproved=false , CategoryId=3 }
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