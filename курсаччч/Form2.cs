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

namespace курсаччч
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Ошибка исходных данных. \n" + "Необходимо ввести данные в оба поля.", "Телефонный справочник", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string m = textBox1.Text;
                string text = File.ReadAllText("C:\\f\\f.txt");
                using (StreamReader sr = new StreamReader("C:\\f\\f.txt"))
                {
                    if (text.Contains(m))
                    {
                        MessageBox.Show("Контакт существует, сохранение невозможно");
                    }
                    else
                    {
                        sr.Close();
                        System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\f\\f.txt", true);

                        writer.WriteLine(textBox1.Text);
                        writer.WriteLine(textBox2.Text);
                        writer.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MessageBox.Show("Контакт сохранен");
                    }
                }
            }
        }
    }
}
