using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200601002_BIL204_Odev_2_3
{
    public class TreeNode
    {
        public string Sozcuk;
        public int SozcukKullanimSayisi;
        public List<string> PozisyonBil = new List<string>();

        public TreeNode(string _sozcuk)
        {
            Sozcuk = _sozcuk;
            SozcukKullanimSayisi = 1;
        }
    }
}
