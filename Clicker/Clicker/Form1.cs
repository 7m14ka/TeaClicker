using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer mouseTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer clickTimer = new System.Windows.Forms.Timer();
        private int remainingClicks;
        private bool isDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const byte VK_CONTROL = 0x11;
        const byte VK_V = 0x56;
        const byte VK_RETURN = 0x0D;
        const uint KEYEVENTF_KEYUP = 0x0002;
        const int HOTKEY_ID_F1 = 1;
        const int HOTKEY_ID_F2 = 2;
        const int WM_HOTKEY = 0x0312;
        public Form1()
        {
            InitializeComponent();
            // Перетаскивание окна
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // Настройка таймера координат
            mouseTimer.Interval = 50;
            mouseTimer.Tick += MouseTimer_Tick;
            mouseTimer.Start();
            // Настройка таймера кликов
            clickTimer.Tick += clickTimer_Tick;
            // Регистрация глобальных горячих клавиш
            RegisterHotKey(this.Handle, HOTKEY_ID_F1, 0, (uint)Keys.F1);
            RegisterHotKey(this.Handle, HOTKEY_ID_F2, 0, (uint)Keys.F2);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_F1)
                {
                    clickTimer.Stop();
                    textBox3.Text = remainingClicks.ToString();
                }
                else if (id == HOTKEY_ID_F2)
                {
                    Start_Click(this, new EventArgs());
                }
            }
            base.WndProc(ref m);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_F1);
            UnregisterHotKey(this.Handle, HOTKEY_ID_F2);
            base.OnFormClosing(e);
        }
        //Отслеживание курсора
        private void MouseTimer_Tick(object sender, EventArgs e)
        {
            Point p = Cursor.Position;
            PositionX.Text = p.X.ToString();
            PositionY.Text = p.Y.ToString();
        }
        private void label1_Click(object sender, EventArgs e) { }
        //Задать интервал между кликами в секундах.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        //Задать общее количество кликов
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        //Прекратить клики
        private void Stop_Click(object sender, EventArgs e)
        {
            clickTimer.Stop();
            textBox3.Text = remainingClicks.ToString();
        }
        //Начать клики
        private void Start_Click(object sender, EventArgs e)
        {
            clickTimer.Stop(); // Сброс, если уже запущен
            try
            {
                double interval = double.Parse(textBox1.Text);
                remainingClicks = int.Parse(textBox2.Text);
                textBox3.Text = remainingClicks.ToString();
                if (interval > 0 && remainingClicks > 0)
                {
                    clickTimer.Interval = (int)(interval * 1000);
                    clickTimer.Start();
                }
            }
            catch { }
        }
        //закрыть приложение
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Свернуть приложение
        private void collapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Главная панель
        private void MainPanel_Paint(object sender, PaintEventArgs e) { }
        //Верхняя панель
        private void TopPanel_Paint(object sender, PaintEventArgs e) { }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void PositionX_TextChanged(object sender, EventArgs e) { }
        private void PositionY_TextChanged(object sender, EventArgs e) { }
        private void IntervalSeconds_Click(object sender, EventArgs e) { }
        private void TotalClicks_Click(object sender, EventArgs e) { }
        private void f1_Click(object sender, EventArgs e) { }
        private void f2_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void clickTimer_Tick(object sender, EventArgs e)
        {
            if (remainingClicks > 0)
            {
                // Нажатие Ctrl + V
                keybd_event(VK_CONTROL, 0, 0, 0);
                keybd_event(VK_V, 0, 0, 0);
                keybd_event(VK_V, 0, KEYEVENTF_KEYUP, 0);
                keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);

                // Ожидание 1 секунды
                Thread.Sleep(1000);

                // Нажатие Enter
                keybd_event(VK_RETURN, 0, 0, 0);
                keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0);

                remainingClicks--;
                textBox3.Text = remainingClicks.ToString();
            }
            else
            {
                clickTimer.Stop();
                textBox3.Text = "0";
            }
        }
    }
}
