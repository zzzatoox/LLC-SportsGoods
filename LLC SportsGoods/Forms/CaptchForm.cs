using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLC_SportsGoods.Forms
{
    public partial class CaptchForm : Form
    {
        public bool isCorrectAnswer = false;
        private string captchAnswer;
        public CaptchForm()
        {
            InitializeComponent();

            pbCaptch.Image = CreateCaptch();
        }

        private Bitmap CreateCaptch()
        {
            Random rnd = new Random();
            Bitmap bitmap = new Bitmap(pbCaptch.Width, pbCaptch.Height);

            int Xpos = rnd.Next(5, pbCaptch.Width - 70);
            int Ypos = rnd.Next(0, pbCaptch.Height - 25);

            Brush[] colors = {
                 Brushes.Red,
                 Brushes.Purple,
                 Brushes.Green,
                 Brushes.Black,
                 Brushes.Blue,
                 Brushes.Brown
             };

            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(Color.LightGray);

            captchAnswer = "";
            string numbers = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; ++i)
                captchAnswer += numbers[rnd.Next(numbers.Length)];

            for (int i = 0; i < 4; i++)
            {
                int x = (rnd.Next(0, 5));
                if (x % 2 == 0)
                    x = i;
                else
                    x -= (x * 2);
                g.DrawString(captchAnswer[i].ToString(),
                        new Font("Arial", 20),
                        colors[rnd.Next(colors.Length)],
                        new PointF(Xpos + (i * 10), Ypos + (x * 3)));
            }

            return bitmap;
        }

        private void btnEnterCaptch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCaptch.Text.Trim()))
            {
                MessageBox.Show("Заполните поле для ввода капчи.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbCaptch.Text.Trim().ToLower() == captchAnswer.ToLower())
            {
                MessageBox.Show("Вы успешно прошли капчу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isCorrectAnswer = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Капча введена неверно.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isCorrectAnswer = false;
                this.Close();
            }
        }

        private void btnUpdateCaptch_Click(object sender, EventArgs e)
        {
            pbCaptch.Image = CreateCaptch();
        }
    }
}
