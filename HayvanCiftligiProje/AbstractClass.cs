
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

namespace HayvanCiftligiProje
{
    //Abstact class olusturup fonssiyonları tanımladık
    public abstract class AbstractClass
    {
        public abstract void Olum();

        public abstract int Can(int azalanCan);
    }
}
