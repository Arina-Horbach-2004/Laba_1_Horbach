using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public enum IntervalType { Increased, Decreased, NoChange }

    [ToolboxBitmap(@"C:\Users\Arina Gorbach\Desktop\Laba_1_Horbach\Library\Lab_1.ico")]
    public partial class Lab_1 : UserControl
    {
        public event Action<IntervalType> IntervalChanged;

        public Lab_1()
        {
            InitializeComponent();

            // Добавляем обработчики событий для трекбаров
            maintrackbar1.Scroll += minTrackBar_Scroll;
            maintrackbar2.Scroll += maxTrackBar_Scroll;

            // Устанавливаем метки для отображения значений трекбаров
            minLabel.Text = maintrackbar1.Value.ToString();
            maxLabel.Text = maintrackbar2.Value.ToString();
        }

        // Свойства для минимального и максимального значения первого трекбара
        public int MainTrackBar1MinValue
        {
            get { return maintrackbar1.Minimum; }
            set { maintrackbar1.Minimum = value; }
        }

        public int MainTrackBar1MaxValue
        {
            get { return maintrackbar1.Maximum; }
            set { maintrackbar1.Maximum = value; }
        }

        // Свойства для минимального и максимального значения второго трекбара
        public int MainTrackBar2MinValue
        {
            get { return maintrackbar2.Minimum; }
            set { maintrackbar2.Minimum = value; }
        }

        public int MainTrackBar2MaxValue
        {
            get { return maintrackbar2.Maximum; }
            set { maintrackbar2.Maximum = value; }
        }

        private void minTrackBar_Scroll(object sender, EventArgs e)
        {
            // При прокрутке первого трекбара обновляем минимальное значение и метку
            minLabel.Text = maintrackbar1.Value.ToString();
            UpdateInterval();
        }

        private void maxTrackBar_Scroll(object sender, EventArgs e)
        {
            // При прокрутке второго трекбара обновляем максимальное значение и метку
            maxLabel.Text = maintrackbar2.Value.ToString();
            UpdateInterval();
        }

        // Метод для обновления интервала
        private void UpdateInterval()
        {
            if (maintrackbar1.Value < maintrackbar2.Value)
            {
                IntervalChanged?.Invoke(IntervalType.Increased);
            }
            else if (maintrackbar1.Value > maintrackbar2.Value)
            {
                IntervalChanged?.Invoke(IntervalType.Decreased);
            }
            else
            {
                IntervalChanged?.Invoke(IntervalType.NoChange);
            }
        }
    }
}
