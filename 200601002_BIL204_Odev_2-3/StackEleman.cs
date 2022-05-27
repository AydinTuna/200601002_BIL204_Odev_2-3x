using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200601002_BIL204_Odev_2_3
{
    public class StackEleman
    {
        public string Cumle;
        public int SozcukSayisi = 0;
        public string[] Kelimeler;
        public StackEleman Next;

        public StackEleman(string _cumle)
        {
            Cumle = _cumle;

            string[] punctuation = { ".", ":", ",", ";", "-", "!", "?" };

            foreach (var punc in punctuation)
            {
                Cumle = Cumle.Replace(punc, "");
            }

            Normalization(Cumle);
        }

        public void Normalization(string _cumle)
        {
            Kelimeler = _cumle.Split(' ');
            SozcukSayisi = Kelimeler.Length;
        }
    }
}
