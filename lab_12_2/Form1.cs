using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder main_str = new StringBuilder(textBox1.Text); // объявляем строку и присваем текст, который мы вели

            int pos_1 = -1; // переменная, которая отвечает за позицию первой круглой скобки

            int pos_2 = -1; // переменная, которая отвечает за позицию второй круглой скобки


            for (int i = 0; i<main_str.Length;i++) // алгоритм поиска позиций круглый скобок
            {


                if (main_str[i]== '(')
                {
                    pos_1= i;
                }

                if (main_str[i] == ')')
                {
                    pos_2= i;

                }

            }


                main_str.Remove(pos_1, pos_2); // удаляем всё, что в скобках
                
            label1.Text= main_str.ToString(); // выводим то, что получилось на экран

        }
    }
}
