using System;
using System.Collections.Generic;
using color = System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int scores;//переменная счётчика правильных ответов
        int errors;//переменная счётчика неправильных ответов
        int answer;//переменная, указвающая на правильную кнопку
        public MainWindow()
        {
            InitializeComponent();
            answer = generator();//генерируем условие при запуске программы

        }


        private int generator()//создаёт условие и варианты ответов
        {
            
            Random rnd = new Random();
            int x = rnd.Next(1, 9);//генератор чисел
            int y = rnd.Next(1, 9);
            urav.Content = string.Format("{0} * {1} = ?", x, y);//генерация задания
            int otvet = x*y;//переменная для хранения результата
            int answer = rnd.Next(1, 4);//выбор кнопку с ответом
            switch (answer)
            {
                case 1:
                    var1.Content = otvet;
                    var2.Content = rnd.Next(1, 81);
                    var3.Content = rnd.Next(1, 81);
                    var4.Content = rnd.Next(1, 81);
                    break;
                case 2:
                    var2.Content = otvet;
                    var1.Content = rnd.Next(1, 81);
                    var3.Content = rnd.Next(1, 81);
                    var4.Content = rnd.Next(1, 81);
                    break;
                case 3:
                    var3.Content = otvet;
                    var1.Content = rnd.Next(1, 81);
                    var2.Content = rnd.Next(1, 81);
                    var4.Content = rnd.Next(1, 81);
                    break;
                case 4:
                    var4.Content = otvet;
                    var1.Content = rnd.Next(1, 81);
                    var2.Content = rnd.Next(1, 81);
                    var3.Content = rnd.Next(1, 81);
                    break;
            }
            return answer;//возвращаем номер кнопки
        }

        private void rightanswer()
        {
            scores++;
            res.Content = String.Format("Верно");
            score.Content = string.Format("Счёт: {0}", scores);
            res.Foreground = new SolidColorBrush(Color.FromArgb(255,0,255,0));
        }

        private void wronganswer()
        {
            errors++;
            res.Content = String.Format("Неверно");
            error.Content = string.Format("Ошибок: {0}", errors);
            res.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        }

        private void var1_Click(object sender, RoutedEventArgs e)
        {
            if(answer==1)
            {
                rightanswer();
                answer=generator();
            }
            else
            {
                wronganswer();
                answer = generator();
            }
        }

        private void var2_Click(object sender, RoutedEventArgs e)
        {
            if (answer == 2)
            {
                rightanswer();
                answer = generator();
            }
            else
            {
                wronganswer();
                answer = generator();
            }
        }

        private void var3_Click(object sender, RoutedEventArgs e)
        {
            if (answer == 3)
            {
                rightanswer();
                answer = generator();
            }
            else
            {
                wronganswer();
                answer = generator();
            }
        }

        private void var4_Click(object sender, RoutedEventArgs e)
        {
            if (answer == 4)
            {
                rightanswer();
                answer = generator();
            }
            else
            {
                wronganswer();
                answer = generator();
            }
        }
    }
}
