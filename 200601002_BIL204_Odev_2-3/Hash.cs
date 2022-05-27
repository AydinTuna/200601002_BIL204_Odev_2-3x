using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200601002_BIL204_Odev_2_3
{
    public class Hash
    {
        public HashEleman[] HashDizi;

        public Hash(Tree _tree)
        {
            HashDizi = new HashEleman[_tree.HeapDizi.Length];

            foreach (TreeNode i in _tree.HeapDizi)
            {
                Insert(i);
            }
        }

        public void Insert(TreeNode _tree)
        {
            int mod = _tree.SozcukKullanimSayisi % HashDizi.Length;

            if (HashDizi[mod] == null)
            {
                HashDizi[mod] = new HashEleman(_tree.Sozcuk, _tree.SozcukKullanimSayisi / HashDizi.Length);
            }
            else
            {
                while (HashDizi[mod] != null)
                {
                    mod++;
                }
                HashDizi[mod] = new HashEleman(_tree.Sozcuk, _tree.SozcukKullanimSayisi / HashDizi.Length);
            }
        }
    }
}
