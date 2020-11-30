
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**
**				ÖDEV NUMARASI…...: proje
**				ÖĞRENCİ ADI......: Canan Tokyay
**				ÖĞRENCİ NUMARASI.: B161210061
**				DERS GRUBU…………...: 2A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace HayvanCiftligiProje
{
    //gerekli sınıflardan kalıtım aldık

    class Ordek : AbstractClass, IHayvanCiftlik, IKumes
    {
        //hayvanımızın saniyede azalan can miktarını hesaplayan fonksiyonu yazdık

        public override int Can(int ordekAzalanCan)
        {
            int Can = 0;
            if (ordekAzalanCan>=3)
            { 
            Can = ordekAzalanCan -3;
            }
            else if(ordekAzalanCan<3)
            {
                Can = 0;
            }
            return Can;
        }

        public override void Olum()
        {
            //ses nesnesi ile sesi projeye ekledik.

            SoundPlayer player = new SoundPlayer();
            string path = @" D:\4.dönem\ndp\b161210061_Canan Tokyay_2A\HayvanCiftligiProje\ordek.wav";
            player.SoundLocation = path;
            player.Play();



            System.Threading.Thread.Sleep(2000);
            //player.Stop();
            player.Stop();
        }


        //urun sayısını arttıran fonksiyonumuz

        public int UrunVer(int urun)
        {
            urun++;
            return urun;
        }
        //yemver butonu ile canı 100 yapan fonksiyon

        public int YemVer(int ordekCan)
        {
            ordekCan = 100;
            return ordekCan;
        }
        //urunun satan ve fiyat hesaplayan fonksiyon

        public int YumurtaSat(int YumurdaAdet)
        {
            int deger = YumurdaAdet * 3;
            return deger;
        }
    }
}
