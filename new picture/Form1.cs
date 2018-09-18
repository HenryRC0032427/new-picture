using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_picture
{
    public partial class pathway : Form
    {
        public pathway()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X + 5, pBxLink.Location.Y);
                await Task.Delay(100);
            }
            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X, pBxLink.Location.Y+5);
                await Task.Delay(100);
            }
            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X - 5, pBxLink.Location.Y);
                await Task.Delay(100);
            }
            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X, pBxLink.Location.Y-5);
                await Task.Delay(100);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X + 6, pBxLink.Location.Y);
                await Task.Delay(100);
            }
            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X - 3, pBxLink.Location.Y + 6);
                await Task.Delay(100);
            }

            for (int i = 0; i < 50; i++)
            {
                pBxLink.Location = new Point(pBxLink.Location.X - 3, pBxLink.Location.Y - 6);
                await Task.Delay(100);
            }


        }
    }
}
