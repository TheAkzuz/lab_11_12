using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = label5.Text + ": символы чувствительны к регистру"; // небольшая приписка у тексту на экране.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string main_text = textBox1.Text; // считываем в переменную то, что ввели в ТекстБокс
            
          

            //две переменные, мы сюда записываем символы для сравнения
            char simvol_1 = textBox2.Text[0];
            char simvol_2 = textBox3.Text[0];


            int long_main_text = main_text.Length; // Тут мы создаём переменную и даём значение длины строки

            char count_bukv ; // Техническая переменная. В неё мы будет присваевать символ, который нам чаще встречаеться
            

            int best_scrore = 0; // переменая, которая считывает , сколько раз встретилась нам максимум буква.

            int score_1 = 0; //счёт совпадений для первого символа
            int score_2 = 0; //счёт совпадений для вторго символа

            for (int i = 0; i < long_main_text; i++) //алгоритм сравнения через цикл фор.
                
            {
                // сравниваем символы с текстом

                if(simvol_1 == main_text[i])
                {
                    score_1++; // и если есть совпадения, то увеличиваем счёт совпадений.
                }

                if (simvol_2 == main_text[i])
                {
                    score_2++;
                }

            }

            // Сравниваем счётсики
            if (score_1 > score_2)
            {
                label2.Text = "Первый символ встречается чаще: " + score_1 + " совпадений";
            }

            if (score_1 < score_2)
            {
                label2.Text = "второй символ встречается чаще: " + score_2 + " совпадений";
            }

            if (score_1 == 0 && score_2 == 0) // если нет совпадений
            {
                label2.Text = "совпадений нет: " ;
            }

            else if (score_1 == score_2)
            {
                label2.Text = "оба символа одинкакова часто встречаются: " + score_1 + " совпадений";
            }





        }
    }
}
