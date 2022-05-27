using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _200601002_BIL204_Odev_2_3
{
    public class Stack
    {
        public StackEleman head;
        public int boyut;
        public int toplamSozcukSay;
        public int ortalamaSozcukSay;

        public string ReadFile(string str)
        {
            string mesaj = "";
            string[] kelimeler;
            using (FileStream fs = File.OpenRead(str))
            {
                byte[] harfler = new byte[1024];
                

                UTF8Encoding utf = new UTF8Encoding(true);
                kelimeler = utf.GetString(harfler).Split('\n');

                fs.Close();

            }
            foreach(string kelime in kelimeler)
            {
                mesaj = kelime;
            }
            return mesaj;
            
        }

        public int InsertStack(string str)
        {
            StackEleman stc = head;

            if (stc == null)
            {
                head = new StackEleman(str);
            }
            else
            {
                stc = new StackEleman(str);
                stc.Normalization(str);
                stc.Next = head;
                head = stc;
            }
            toplamSozcukSay += head.SozcukSayisi;
            return toplamSozcukSay;
        }

        public Tree AgacaAktar()
        {
            StackEleman eleman = head;
            Tree tree = new Tree(toplamSozcukSay);
            int sayac = 0, eklenenSayisi = 0;
            int control = 0;

            while (eleman != null)
            {
                for (int i = 0; i < eleman.Kelimeler.Length; i++)
                {
                    for (int j = 0; j < tree.HeapDizi.Length; j++)
                    {
                        if (eleman.Kelimeler[i] == tree.HeapDizi[j].Sozcuk)
                        {
                            tree.HeapDizi[j].SozcukKullanimSayisi++;
                            tree.HeapDizi[j].PozisyonBil.Add("Cümle Sırası: " + sayac + "Harf Sırası: " + i);
                            control++;
                            tree.YukariTasi(j);
                            break;
                        }
                    }
                    if (control == 1)
                    {
                        tree.Insert(eleman.Kelimeler[i]);
                        tree.HeapDizi[eklenenSayisi].PozisyonBil.Add("Cümle Sırası: " + sayac + "Harf Sırası: " + i);
                        eklenenSayisi++;
                    }
                    control--;
                }

                eleman = eleman.Next;
                sayac++;
            }
            return tree;
        }
    }
}
