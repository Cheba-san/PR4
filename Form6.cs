using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace work
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public void getInfo()
        {
            string query = ("SELECT id_workers as '№', fio_worker as 'ФИО', phone_number as 'Номер телефона', id_positions as 'Должность', id_department as 'Отделение' from workers;");
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView6.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_add6_Click(object sender, EventArgs e)
        {
            string addwork = "insert into workers (fio_worker, phone_number, id_positions, id_department) values('" + fio.Text + "' , '" + numb.Text + "', '"+ pos.Text +"' , '"+ dep.Text +"');";
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlCommand cmDB = new MySqlCommand(addwork, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Добавлено.");
                getInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла непредвиденная ошибка.");
            }
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fio.Text = dataGridView6[1, dataGridView6.CurrentRow.Index].Value.ToString();
            numb.Text = dataGridView6[2, dataGridView6.CurrentRow.Index].Value.ToString();
            pos.Text = dataGridView6[3, dataGridView6.CurrentRow.Index].Value.ToString();
            dep.Text = dataGridView6[4, dataGridView6.CurrentRow.Index].Value.ToString();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            string update = "update workers set fio_worker = '" + fio.Text + "', phone_number = '"+ numb.Text +"', id_positions = "+ pos.Text +", id_department = "+ dep.Text +" where id_workers = " + dataGridView6[0, dataGridView6.CurrentRow.Index].Value.ToString() + ";";
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlCommand cmDB = new MySqlCommand(update, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("данные обновлены");
                getInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла непредвиденная ошибка.");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Уверены, что хотите удалить персонажа?", "Вы уверены?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string del = "delete from workers where id_workers = " + dataGridView6[0, dataGridView6.CurrentRow.Index].Value.ToString() + ";";
                MySqlConnection conn = Class2.GetSqlConnection();
                MySqlCommand cmDB = new MySqlCommand(del, conn);
                try
                {
                    conn.Open();
                    cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("данные удалены");
                    getInfo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка.");
                }
            }
        }
    }
}
