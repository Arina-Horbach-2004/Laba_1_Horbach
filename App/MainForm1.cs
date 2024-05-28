using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using Library;

namespace App
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();

            // Підписка на подію IntervalChanged компонента Lab_1
            intervaltrack.IntervalChanged += Lab_1_IntervalChanged;
        }

        // Обробник події IntervalChanged
        private void Lab_1_IntervalChanged(IntervalType changeType)
        {
            // Перевірка на null перед викликом події
            if (changeType != null)
            {
                switch (changeType)
                {
                    case IntervalType.Increased:
                        label1.Text = "Інтервал збільшено";
                        break;
                    case IntervalType.Decreased:
                        label1.Text = "Інтервал зменшено";
                        break;
                    case IntervalType.NoChange:
                        label1.Text = "Інтервал залишився незмінним";
                        break;
                    default:
                        label1.Text = "Невідомий тип зміни інтервалу";
                        break;
                }
            }
        }
    }
}
