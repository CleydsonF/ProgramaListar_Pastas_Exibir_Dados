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

namespace Aula_3_WindowsForm_Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($@"C:\Users\Cleydson Fernando\Pictures\{textBox1.Text}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            string [] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            listBox1.Items.AddRange(files);





          /*  DirectoryInfo diretorio = new DirectoryInfo($@"C:\Users\Cleydson Fernando\Pictures\");
            FileInfo[] fotos = Directory.GetFiles("*");
            foreach (FileInfo arquivo in fotos)
            {
                listBox1.Items.Add(arquivo.Name);
            }
          */



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
        }
    }
}
