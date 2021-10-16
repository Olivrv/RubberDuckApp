using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RubberDuck
{
    public partial class RubberDuck : Form
    {
        public string text = "";
        bool drag = false;
        Point start_point = new Point(0, 0);
        Random random = new Random();
        public bool enter = false;

        int count_messages = 0;
        public int height = 2;

        public RubberDuck()
        {
            InitializeComponent();
            toolTip1.SetToolTip(textBox, "Enter your problems to debug them.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel_header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enter = true;
                text = textBox.Text;
                Console.WriteLine(textBox.Text);
                textBox.Clear();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enter)
            {
                e.Handled = true;
                enter = false;
                if (text != " " && text != "")
                {
                    message(text);
                }
            }
        }

        private void message(string txt)
        {
            count_messages += 1;
            Button send = new Button
            {
                Text = txt,
                Size = new Size(0, 30),
                UseVisualStyleBackColor = true,
                AutoSize = true,
                Enabled = false,
                Location = new Point(0, 0),
            };
            messages.Controls.Add(send);
            send.Location = new Point((messages.Width - (send.Size.Width + 20)), (height - messages.VerticalScroll.Value));
            height += 35;
            int num = random.Next(1, 4);
            Button quack = new Button
            {
                Text = String.Concat(Enumerable.Repeat("Quack", num)),
                Size = new Size(0, 30),
                UseVisualStyleBackColor = true,
                AutoSize = true,
                Enabled = false,
                Location = new Point(2, height),
            };
            messages.Controls.Add(quack);
            quack.Location = new Point(15, (height - messages.VerticalScroll.Value));
            height += 35;
        }

        private void messages_ControlAdded(object sender, ControlEventArgs e)
        {
            messages.ScrollControlIntoView(e.Control);
        }

        private void Info_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Rubber_duck_debugging");
        }
    }
}
