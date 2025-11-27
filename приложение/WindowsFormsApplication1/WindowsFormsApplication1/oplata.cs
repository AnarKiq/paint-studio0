using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class oplata : Form
    {
        public oplata()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно!", "Успешно!");
            Application.Exit();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно!", "Успешно!");
            Application.Exit();
        }
    }
}
