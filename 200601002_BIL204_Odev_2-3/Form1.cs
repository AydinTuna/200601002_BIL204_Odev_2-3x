using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _200601002_BIL204_Odev_2_3
{
    public partial class formMetin : Form
    {
        static Stack MetinStack = new Stack();
        static Tree MetinTree;
        public formMetin()
        {
            InitializeComponent();
        }

        OpenFileDialog dialog;

        private void formMetin_Load(object sender, EventArgs e)
        {
            

        }

        public void btnMetinYukle_Click(object sender, EventArgs e)
        {
            DosyayiOku();
        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {

            lvStackYaz.Items.Add(MetinStack.ReadFile(txtDosyaPath.Text));

            DosyayiYaz();
        }






        // Functions
        public void DosyayiYaz()
        {
            var fileStream = dialog.OpenFile();
            StreamReader sr = new StreamReader(fileStream);
            lvStackYaz.Columns.Add("Cümle", 500);
            lvStackYaz.Columns.Add("Kelime Sayısı", 100);
            lvStackYaz.Columns.Add("Ortalama Kelime Sayısı", 100);
            lvStackYaz.Columns.Add("Toplam Cümle Sayısı", 100);
            string satir = "";
            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    break;
                }
                lvStackYaz.Items.Add(satir);
                lvStackYaz.Items.Add(MetinStack.InsertStack(satir).ToString());
            }

        }

        public void DosyayiOku()
        {
            dialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDosyaPath.Text = dialog.FileName;

            }
        }
    }
    
}
