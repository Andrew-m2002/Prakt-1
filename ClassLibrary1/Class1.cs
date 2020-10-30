using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_x
{
    public class Class1
    {
        public static void Min(int n, ref TextBox inX, ref TextBox outX)
        {
            int dop, min=40;//описываем переменные
            Random Rnd; Rnd = new Random();//создаем объект рандом
            for (int i = 0; i < n; i++)//перебираем числа
            {
                dop = Rnd.Next(10, 40);//генерируем число
                inX.Text = inX.Text + dop.ToString() + " ";//выводим его
                if (dop < min)//если оно меньше дополн. переменной
                    min = dop;//присваиваем новое мин. значение
            }
           outX.Text = outX.Text + min.ToString();//выводим минимальное число
           // return min;//возвращаем значение
        }
    }
}
