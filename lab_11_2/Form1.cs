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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string main_text = textBox1.Text; // считываем в переменную то, что ввели в ТекстБокс

            main_text = main_text.ToUpper(); // Переводим все символы в КАПС , чтобы не было ошибок регистра при сравнение

            int long_main_text = main_text.Length; // Тут мы создаём переменную и даём значение длины строки

            char count_bukv ; // Техническая переменная. В неё мы будет присваевать символ, который нам чаще встречаеться
            

            int best_scrore = 0; // переменая, которая считывает , сколько раз встретилась нам максимум буква.

            int score = 0; //счёт совпадений

            for (int i = 0; i < long_main_text; i++) //алгоритм сравнения по принцыпу пузырковой сратировку (тоесть сравниеваем через два цикла)
                
            {
                score = 0;

                count_bukv = main_text[i];
                    for (int a = 0; a<long_main_text-1; a++)
                {

                    if (main_text[a] == main_text[i]) // сравниваем символ со всей стракой, если совпало, то...
                    {
                        score++; //увеличиваем счётчие совпадений

                        
                    }

                    if (score > best_scrore) //Если счёт больше лучшего счёта, то тогда мы
                    {
                        
                        best_scrore = score; // Деалем этот счёт лучшим
                        count_bukv = main_text[i]; //И эту букву мы делаем эту букву самой повторяющейс.
                        

                        //и выводим результат. После сравнения, остаётся тот, что последний наибольший

                        label2.Text = "Буква, которая встречалась больше всех : " + count_bukv + "\nЕсли две или более буквы равны, то выводится первя буква ";

                    }

                }

            }




        }
    }
}
