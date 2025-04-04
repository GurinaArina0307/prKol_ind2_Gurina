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
using System.Linq;

namespace prKol_ind2_v1_Gurina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "file.txt";

            try
            {
                // проверка на наличие файла
                if (!File.Exists(file))
                {
                    MessageBox.Show("Файл не найден!");
                    return;
                }

                string fileRead = File.ReadAllText(file);
                // выбираем все символы отличные от цифр
                var notNumbers = fileRead.Where(c => !char.IsDigit(c));
                // выбираем только цифры
                var numbers = fileRead.Where(c => char.IsDigit(c));

                char[] result = notNumbers.Concat(numbers).ToArray();

                label1.Text = new string(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
