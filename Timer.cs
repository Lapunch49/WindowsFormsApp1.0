using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class Timer : Form
    {
        MyTime rem_time = new MyTime(); // время, оставшееся до конца отсчета
        public Timer()
        {
            InitializeComponent();
            // заполняем comboBox часов от 0 до 12
            //for (int i = 0; i < 13; ++i)
            //{
            //    this.cmbx_hour.Items.AddRange(new object[] {
            //i.ToString() });
            //}
            // заполняем comboBox минут от 0 до 59
            for (int i = 0; i < 60; ++i)
            {
                this.cmbx_min.Items.AddRange(new object[] {
            i.ToString() });
            }
            // заполняем comboBox секунд от 0 до 59
            for (int i = 0; i < 60; ++i)
            {
                this.cmbx_sec.Items.AddRange(new object[] {
            i.ToString() });
            }
        }
        private void update_lbTime()
        { // обновление label при изменении любого comboBox и при событии Tick(уменьшение на 1 секунду ост. вр.)
            lb_timeToEnd.ResetText();
            lb_timeToEnd.Text = String.Format("{0:00}", rem_time.hour) + ":" + String.Format("{0:00}", rem_time.min) + 
                ":" + String.Format("{0:00}", rem_time.sec);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            rem_time.sec--;  // уменьшаем ост. время на секунду
            bool end = rem_time.check(); // проверяем корректность чисел
            if (end)
            { // если время истекло, таймер ост-ся, выводится сообщение пользователю
                timer1.Stop();
                // воспроизводим звук таймера
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Music\shkolnyiy-zvonok-na-peremenu.wav");
                player.Play();
                if (MessageBox.Show("Time is up", "Timer", MessageBoxButtons.OK) == DialogResult.OK)
                { // обновляем время (у объекта и у label)
                    rem_time.hour = int.Parse(nud_hour.Text.ToString());
                    rem_time.min = int.Parse(cmbx_min.Text.ToString());
                    rem_time.sec = int.Parse(cmbx_sec.Text.ToString());
                    update_lbTime();
                    // меняем кнопки
                    btn_stop_Click(this, null);
                }
            }
            else
            { // если время не истекло, обновляем время на label
                update_lbTime();
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        { // запуск таймера
            //timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000; // вызов события Tick через каждую секунду
            // прячем кнопку start, выводим кнопки stop и restart
            btn_start.Visible = false;
            btn_stop.Visible = true;
            btn_restart.Visible = true;
        }
        private void nud_hour_ValueChanged(object sender, EventArgs e)
        {
            // ограничения на изменение ост. времени при работающем таймере
            if (timer1.Enabled == false)
            {
                rem_time.hour = int.Parse(nud_hour.Value.ToString());
                update_lbTime();
            }
        }
        private void cmbx_min_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                rem_time.min = int.Parse(cmbx_min.Text.ToString());
                update_lbTime();
            }
        }
        private void cmbx_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                rem_time.sec = int.Parse(cmbx_sec.Text.ToString());
                update_lbTime();
            }
        }
        private void btn_stop_Click(object sender, EventArgs e)
        { // останавливаем таймер
            timer1.Enabled = false;
            // прячем кнопки stop и restart, выводим кнопку start 
            btn_stop.Visible = false;
            btn_restart.Visible = false;
            btn_start.Visible = true;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        { // обновляем свойства у объекта time 
            rem_time.hour = int.Parse(nud_hour.Text.ToString());
            rem_time.min = int.Parse(cmbx_min.Text.ToString());
            rem_time.sec = int.Parse(cmbx_sec.Text.ToString());
            update_lbTime();
            // запускаем timer
            timer1.Start();
        }
    }
    public class MyTime // объект класса - "время" со свойствами часы, минуты и секунды
    {
        public int hour = 0;
        public int min = 0;
        public int sec = 0;
        public bool check() // проверяем, не истекло ли время, и обновляем часы, минуты, секунды
        {
            if (sec ==  -1) // если последняя сек в мин истекла, отнимем мин и прибавим 59 сек
            {
                min--;
                if (min >= 0)
                    sec = 59;
            }
            if (min == -1) // если последняя мин в часе истекла, отнимем час и прибавим 59 мин, 59 сек
            {
                hour--;
                if (hour >= 0)
                {
                    min = 59;
                    sec = 59;
                }
            }
            if (hour == -1 && min == -1 && sec == -1)
            {
                return true;
            }
            return false;
        }
    }
}
