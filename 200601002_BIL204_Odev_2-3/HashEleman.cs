using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200601002_BIL204_Odev_2_3
{
    public class HashEleman
    {
        public string sozcuk;
        public int key;

        public HashEleman(string str, int ts)
        {
            sozcuk = str;
            key = ts;
        }
    }
}
