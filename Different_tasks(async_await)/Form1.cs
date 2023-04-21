using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Different_tasks_async_await_
{
    public partial class Form1 : Form
    {
        Task6 task6 = null;
        Task7 task7 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task6 = new Task6();
            task6.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            task7 = new Task7();
            task7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await Asynk_Await();
        }
        private async Task Asynk_Await()
        {
            if(task6 != null)
            {
               await task6.FinalCount();
            }
            if (task7 != null)
            {
                await task7.FinalCount();
            }
        }

    }
}
