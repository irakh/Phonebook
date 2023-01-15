using System.IO;

namespace курсаччч
{
    public struct people
    {
        public string name;
        public string number;

    }



    public partial class Form1
    {
        List<people> l = new List<people>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }


        int find(string s)
        {
            for (int i = 0; i < l.Count; i++)
                if (l[i].name.Equals(s))
                    return i;

            return -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Ошибка исходных данных. \n" + "Необходимо ввести данные в оба поля.", "Телефонный справочник", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                /*people A;
                A.name = textBox1.Text;
                A.number = textBox2.Text;
                int x = find(A.name);
                if (x == -1)
                {
                    l.Add(A);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Контакт внесен");
                }
                else
                {
                    MessageBox.Show("Такой контакт существует");
                }*/
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

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int x = find(s);
            if (x != -1)
                textBox2.Text = l[x].number;
            else
            {
                MessageBox.Show("контакт не найден");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\f\\f.txt");
            string m;
            while ((m = sr.ReadLine()) != null)
            {
                people A;
                A.name = m;
                A.number = sr.ReadLine();
                l.Add(A);
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\f\\f.txt");
            string m;
            while ((m = sr.ReadLine()) != null)
            {
                people A;
                A.name = m;
                A.number = sr.ReadLine();
                l.Add(A);
            }
            sr.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
        }
    }
}