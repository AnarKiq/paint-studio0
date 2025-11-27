using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class anketa : Form
    {

        DataBase dataBase = new DataBase();

        public anketa()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void anketa_Load(object sender, EventArgs e)
        {

            textBox1.MaxLength = 50;
            textBox2.MaxLength = 11;
            textBox3.MaxLength = 150;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            var userName = textBox1.Text;
            var number = textBox2.Text;
            var description = textBox3.Text;
            var date = monthCalendar1.SelectionRange.Start.ToShortDateString();

            string queryString = $"insert into klienti (name_kl, phone, description, date_z) values('{userName}', '{number}', '{description}', '{date}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oplata opl = new oplata();
                this.Hide();
                opl.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка!", "Что то не так!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataBase.closeConnection();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
