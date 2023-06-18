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



        /*  Вопросы по заданию.

        1) какие есть аналоги Split(), но для StringBuilder  ? В интренете не нашёл.
        2) Есть ли функции, которые вставляют братно знаки препинания, когда слова снова
        станоятся текстом, после обработкт ? Или надо писать отдельный алгоритм ?

        */


        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder main_str = new StringBuilder(richTextBox1.Text); // объявляем строку и присваем текст, который мы вели

            char char_remove = textBox1.Text[0];
            char[] delim= new[] { ' ', ',', '!', '-', '.', ';', ':' }; // символы, которые не входят в состав слов

            string for_split = main_str.ToString(); // Создаём стринг переменную, для сплит функции, которой нет в СтрингБиодер

            string[] for_remove = for_split.Split(delim, StringSplitOptions.RemoveEmptyEntries); //делим текст на слова 

            string summ_str = ""; //делаем переменную. в которой мы будем вставлять уже обраьотанный текст
            for(int i = 0; i < for_remove.Length; i++) //алгоритм удаление слова. если есть символ в конце, который мы задали
            {
                string time_str = for_remove[i]; //делаем временную переменую и даём значения из массивов слов.
                if (char_remove == time_str[time_str.Length-1]) //И если в конце есть запрещённый символ, то слова удаляется
                {
                    time_str = time_str.Remove(0);
                }
                summ_str = summ_str + time_str +" "; //сюда мы складываем всё, что получилось
            }    

            richTextBox2.Text = summ_str; // и и выводи всё, что у нас получилось

        }
    }
}
