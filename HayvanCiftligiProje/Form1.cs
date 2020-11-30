using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HayvanCiftligiProje
{
    public partial class Form1 : Form
    {
        //sınıflardan erişim için nesneleri urettik
        Tavuk tavuk = new Tavuk();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();
        Keci keci = new Keci();

        public Form1()
        {
            InitializeComponent();
        }
        int Sure = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer nesnesini baslattık
            timer1.Start();
            tavukCan.Value = 100;
            ordekCan.Value = 100;
            inekCan.Value = 100;
            keciCan.Value = 100;
        }
        //yemver butonu ile progressbar nesnesini controlunu sagladık
        private void tavukYemVer_Click(object sender, EventArgs e)
        {
            int can = tavukCan.Value;
            tavukCan.Value=tavuk.YemVer(can);


        }

        private void ordekYemVer_Click(object sender, EventArgs e)
        {
            int can = ordekCan.Value;
            ordekCan.Value = ordek.YemVer(can);
        }

        private void inekYemVer_Click(object sender, EventArgs e)
        {
            int can = inekCan.Value;
            inekCan.Value = inek.YemVer(can);
        }

        private void keciYemVer_Click(object sender, EventArgs e)
        {
            int can = keciCan.Value;
            keciCan.Value = keci.YemVer(can);
        }
        //timer nesnesinin tick olayı ile olusan durumları sıraladık
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Sure++;
            sure.Text = Convert.ToString(Sure) + "SN";
            //azalan canları hesapladık
            if (Sure != 0 && Sure % 1 == 0)
            {
                int deger;
                int canTavuk = tavukCan.Value;
                deger = tavuk.Can(canTavuk);
                tavukCan.Value = deger;
            }

            if (Sure != 0 && Sure % 1 == 0)
            {
                int deger;
                int canOrdek = ordekCan.Value;
                deger = ordek.Can(canOrdek);
                ordekCan.Value = deger;
            }

            if (Sure != 0 && Sure % 1 == 0)
            {
                int deger;
                int canInek = inekCan.Value;
                deger = inek.Can(canInek);
                inekCan.Value = deger;
            }

            if (Sure != 0 && Sure % 1 == 0)
            {
                int deger;
                int canKeci = keciCan.Value;
                deger = keci.Can(canKeci);
                keciCan.Value = deger;
            }
            //urun sayısını hesapladık
            if (Sure != 0 && Sure % 3 == 0)
            {
                if (tavukCan.Value != 0)
                {
                    string[] urunSayi = tavukAdet.Text.Split(' ');
                    int yumurta = Convert.ToInt32(urunSayi[0]);
                    int yumurtaSayisi = tavuk.UrunVer(yumurta);
                    tavukAdet.Text = Convert.ToString(yumurtaSayisi) + " ADET";
                }
            }

            if (Sure != 0 && Sure % 5 == 0)
            {
                if (ordekCan.Value != 0)
                {
                    string[] urunSayi = ordekAdet.Text.Split(' ');
                    int yumurta = Convert.ToInt32(urunSayi[0]);
                    int yumurtaSayisi = ordek.UrunVer(yumurta);
                    ordekAdet.Text = Convert.ToString(yumurtaSayisi) + " ADET";
                }
            }

            if (Sure != 0 && Sure % 8 == 0)
            {
                if (inekCan.Value != 0)
                {
                    string[] urunSayi = inekAdet.Text.Split(' ');
                    int sut = Convert.ToInt32(urunSayi[0]);
                    int sutMiktari = inek.UrunVer(sut);
                    inekAdet.Text = Convert.ToString(sutMiktari) + " KG";
                }
            }
            if (Sure != 0 && Sure % 7 == 0)
            {
                if (keciCan.Value != 0)
                {
                    string[] urunSayi = keciAdet.Text.Split(' ');
                    int sut = Convert.ToInt32(urunSayi[0]);
                    int sutMiktari = keci.UrunVer(sut);
                    keciAdet.Text = Convert.ToString(sutMiktari) + " KG";
                }
            }
            //progressbar kontrolü ile hayvanın canlı olup olmadıgına baktık ve öldü ile ses dosyasını calıştırdık.
            if(tavukCan.Value==0&& tavukYemVer.Enabled==true)
            {
                if (tavukCan.Value == 0)
                {
                tavukCanli.Text = "ÖLDÜ";
                tavukYemVer.Enabled = false;
                tavuk.Olum();
                }
            }
            
            else
            {
                tavukCanli.Text = "CANLI";
            }
            if(ordekCan.Value==0&&ordekYemVer.Enabled==true)
            { 
                if (ordekCan.Value == 0)
                {
                ordekCanli.Text = "ÖLDÜ";
                ordekYemVer.Enabled = false;
                    ordek.Olum();
                }
            }
            else
            {
                ordekCanli.Text = "CANLI";
            }
            if (inekCan.Value == 0 && inekYemVer.Enabled== true)
            {
                if (inekCan.Value == 0)
                {
                    inekCanli.Text = "ÖLDÜ";
                    inekYemVer.Enabled = false;
                     inek.Olum();

                  
                }

               
            }
            
            else
            {
                inekCanli.Text = "CANLI";
            }
            if(keciCan.Value==0&&keciYemVer.Enabled==true)
            {
                if (keciCan.Value == 0)
                {
                    keciCanli.Text = "ÖLDÜ";
                    keciYemVer.Enabled = false;
                    keci.Olum();

                }
            }
           
            else
            {
                keciCanli.Text = "CANLI";
            }
        }
        //üretilen urunleri satarak, kasa hesapladık
       
        private void tavukYumSat_Click(object sender, EventArgs e)
        {
            string[] degisken =tavukAdet.Text.Split(' ');
            int ucret = tavuk.YumurtaSat(Convert.ToInt32(degisken[0]));
            tavukAdet.Text = "0";
            string[] kasaDeger = kasa.Text.Split(' ');
            kasa.Text =Convert.ToString( Convert.ToInt32(kasaDeger[0]) + ucret)+" TL";
        }

        private void ordekYumSat_Click(object sender, EventArgs e)
        {
            string[] degisken = ordekAdet.Text.Split(' ');
            int ucret = ordek.YumurtaSat(Convert.ToInt32(degisken[0]));
            ordekAdet.Text = "0";
            string[] kasaDeger = kasa.Text.Split(' ');
            kasa.Text = Convert.ToString(Convert.ToInt32(kasaDeger[0]) + ucret)+" TL";
        }

        private void inekSutSat_Click(object sender, EventArgs e)
        {
            string[] degisken = inekAdet.Text.Split(' ');
            int ucret = inek.SutSat(Convert.ToInt32(degisken[0]));
            inekAdet.Text = "0";
            string[] kasaDeger = kasa.Text.Split(' ');
            kasa.Text = Convert.ToString(Convert.ToInt32(kasaDeger[0]) + ucret)+" TL";

        }

        private void keciSutSat_Click(object sender, EventArgs e)
        {
            string[] degisken = keciAdet.Text.Split(' ');
            int ucret = keci.SutSat(Convert.ToInt32(degisken[0]));
            keciAdet.Text = "0";
            string[] kasaDeger = kasa.Text.Split(' ');
            kasa.Text = Convert.ToString(Convert.ToInt32(kasaDeger[0]) + ucret)+" TL";
        }
        
    }
}
