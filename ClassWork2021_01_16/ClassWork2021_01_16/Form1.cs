using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork2021_01_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label labelx = (Label)sender;
            labelx.BackColor = Color.Red;
            MessageBox.Show("Нажата метка " + label2.Text, "Сообщение");
            labelx.Text = labelx.Text + '+';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (acceptBox.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Принято", "Состояние чекбокса", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                
            }
            if (acceptBox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Не нринято", "Состояние чекбокса", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            }
            if (acceptBox.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("Не выяснено", "Состояние чекбокса", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            monthCalendar1.SelectionStart = new DateTime(2022, 01, 2);
            monthCalendar1.SelectionEnd = new DateTime(2022, 1, 28);
        }

        private void onRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if(radio.Checked)
            {
                acceptBox.CheckState = CheckState.Unchecked;
            }
            else
            {
                acceptBox.CheckState = CheckState.Indeterminate;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker tim = sender as DateTimePicker;
            Text = tim.Value.ToLongDateString() + ' ' + tim.Value.ToShortTimeString();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar tim = sender as MonthCalendar;
            Text = tim.SelectionStart.ToLongDateString() + " до " + tim.SelectionEnd.ToLongDateString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(sender != this)
            {
                Control control = sender as Control;
                Point xy = control.Location;
                Text = $"[{e.X+xy.X}:{e.Y+xy.Y}] {e.Button}";

            }
            else
            {
                Text = $"[{e.X}:{e.Y}] {e.Button}";

            }
        }
        int tiks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counterBox1.Text = tiks++.ToString();
            if (tiks > 10)
                Timer1.Stop();
        }
    }
}
