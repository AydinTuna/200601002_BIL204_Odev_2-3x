using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200601002_BIL204_Odev_2_3
{
    public class Tree
    {
        public TreeNode[] HeapDizi;
        public int MaxBoyut;
        public int Boyut;

        public Tree(int maxBoyut)
        {
            MaxBoyut = maxBoyut;
            Boyut = 0;
            HeapDizi = new TreeNode[MaxBoyut];
        }

        public int Insert(string str)
        {
            if (Boyut == MaxBoyut)
            {
                return 0;
            }

            TreeNode heapNode = new TreeNode(str);
            HeapDizi[Boyut] = heapNode;
            YukariTasi(Boyut++);
            return 1;
        }

        public void YukariTasi(int index)
        {
            int parent = (index - 1) / 2;
            TreeNode bottom = HeapDizi[index];
            while (index > 0 && HeapDizi[parent].SozcukKullanimSayisi < bottom.SozcukKullanimSayisi)
            {
                HeapDizi[index] = HeapDizi[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            HeapDizi[index] = bottom;
        }
    }
}
