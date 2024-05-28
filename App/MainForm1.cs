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

            // ϳ������ �� ���� IntervalChanged ���������� Lab_1
            intervaltrack.IntervalChanged += Lab_1_IntervalChanged;
        }

        // �������� ��䳿 IntervalChanged
        private void Lab_1_IntervalChanged(IntervalType changeType)
        {
            // �������� �� null ����� �������� ��䳿
            if (changeType != null)
            {
                switch (changeType)
                {
                    case IntervalType.Increased:
                        label1.Text = "�������� ��������";
                        break;
                    case IntervalType.Decreased:
                        label1.Text = "�������� ��������";
                        break;
                    case IntervalType.NoChange:
                        label1.Text = "�������� ��������� ��������";
                        break;
                    default:
                        label1.Text = "�������� ��� ���� ���������";
                        break;
                }
            }
        }
    }
}
