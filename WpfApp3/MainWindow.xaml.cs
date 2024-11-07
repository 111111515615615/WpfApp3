using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
          private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //  Получаем входную строку и разбиваем ее на отдельные числа
                string input = InputTextBox.Text;
                string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                //  Преобразуем строки в целые числа и вычисляем сумму чисел > 5
                int sum = 0;
                foreach (string numberString in numbers)
                {
                    int number = int.Parse(numberString);
                    if (number > 5)
                    {
                        sum += number;
                    }
                }

                // Результат 
                ResultTextBlock.Text = $"Сумма чисел > 5: {sum}";
            }
            catch (Exception ex)
            {
                //  Обрабатывать любые исключения (например, неверный ввод)
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
namespace SumOfNumbers
{
    public partial class MainWindow : Window
    {
        // ...
    }
}
