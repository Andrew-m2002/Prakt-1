//Монахов Андрей ИСП-31
//Практическая работа №1
/*4. Найти минимум из n целых случайных чисел  X, распределенных в диапазоне от   10 до 40. 
 * Вывести на экран на одной строке сгенерированные числа, на другой строке результат*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_x;

namespace Практическая_работа_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Вычислить
        private void button1_Click(object sender, EventArgs e)
        {
            int n, min;//описываем переменные
            if (Int32.TryParse(textBox1.Text, out n))//получаем количество чисел проверяя его на корректность
            {
               Class1.Min(n, ref textBox2, ref textBox3);//используем библиотеку для генерирования чисел, нахождения минимального числа и его вывода

            }
            else MessageBox.Show("Введите число!");//если ввод некорректный, выводим сообщение
        
        }
        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №1\n" +
                "Выполнил студент гр. ИСП-31 Монахов Андрей\n" +
                "Программа находит минимальное число из указанного кол-ва чисел в диапазоне от 10 до 40 и выводит эти числа и их минимальное в соответствующие поля");
        }
        //Очищаем текстбоксы при изменении значения
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
