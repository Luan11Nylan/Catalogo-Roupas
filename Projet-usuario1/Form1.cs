using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_usuario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosCamisetas = Directory.GetFiles(@"C:\Users\PC\Pictures\projet-camiseta1");
            foreach (string img in nomeFotosCamisetas)
            {
                string[] separador = img.Split('\\');
                var nomeSelecionado = separador[5].Split('.');

                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\PC\Pictures\projet-camiseta1\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }         
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if (comboBox1.Text == "Nike")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Nike");
                comboBox2.Items.Add("Nike1");
            }
            else if (comboBox1.Text == "Lacoste")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Lacoste");
            }
            else if (comboBox1.Text == "Under Amour")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Under Amour");
            }
            else if (comboBox1.Text == "Levi's")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Levi's");
            }
            else if (comboBox1.Text == "Adidas")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Adidas");
                comboBox2.Items.Add("Adidas1");
            }
            else if (comboBox1.Text == "Brutal Rock")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Brutal Rock");
            }
            else if (comboBox1.Text == "John John")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("John John");
            }
        }
    }
}
