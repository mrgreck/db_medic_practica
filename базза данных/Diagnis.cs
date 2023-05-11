using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace базза_данных
{
    public partial class Diagnis : Form
    {
        private static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;
        Point lastPoint;
        int[] d_id;
        int select_id = 0;
        int[] item_id = new int[3];

        private void Load_db()
        {
            Diagnos_list.Items.Clear();
            d_id = new int[1000];

            string query = "SELECT people_card, diagnos, doctor_id, id FROM Diagnos ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            int i = 0;
            while (result_command.Read())
            {
                d_id[i] = Convert.ToInt32(result_command[3].ToString());
                i++;

                query = "SELECT first_name, name FROM People WHERE id = " + result_command[0].ToString();
                command = new OleDbCommand(query, myConnection);
                OleDbDataReader r_c = command.ExecuteReader();
                r_c.Read();
                Diagnos_list.Items.Add(string.Format("{0} {1} {2}.{3}.{4}", 
                    r_c[0].ToString(), 
                    r_c[1].ToString(), 
                    result_command[1].ToString(), 
                    result_command[2].ToString(), 
                    result_command[3].ToString()));
            }

            people_comboBox.Items.Clear();
            query = "SELECT first_name, name, id FROM People ORDER BY id";
            command = new OleDbCommand(query, myConnection);
            result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                people_comboBox.Items.Add(string.Format("{0} {1} {2}",result_command[0].ToString(), result_command[1].ToString(), result_command[2].ToString()));
            }

            diagnos_comboBox.Items.Clear();
            query = "SELECT name, id FROM Sick ORDER BY id";
            command = new OleDbCommand(query, myConnection);
            result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                diagnos_comboBox.Items.Add(string.Format("{0} {1}", result_command[0].ToString(), result_command[1].ToString()));
            }

            doctor_comboBox.Items.Clear();
            query = "SELECT first_name, name, id FROM Doctor ORDER BY id";
            command = new OleDbCommand(query, myConnection);
            result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                doctor_comboBox.Items.Add(string.Format("{0} {1} {2}", result_command[0].ToString(), result_command[1].ToString(), result_command[2].ToString()));
            }

            hour_unumericUpDown.Value= DateTime.Now.Hour;
            minute_numericUpDown.Value= DateTime.Now.Minute;

        }
        public Diagnis()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }

        private void Exit_button_MouseEnter(object sender, EventArgs e)
        {
            Exit_button.ForeColor = Color.Red;
        }

        private void Exit_button_MouseLeave(object sender, EventArgs e)
        {
            Exit_button.ForeColor = Color.Black;
        }



        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main MainWindow = new Main();
            myConnection.Close();
            MainWindow.Show();
            this.Hide();
        }

        private void Diagnis_Load(object sender, EventArgs e)
        {
            Load_db();
        }

        private void hour_unumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (hour_unumericUpDown.Value > 23)
            {
                hour_unumericUpDown.Value = 0;
            }
        }

        private void minute_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (minute_numericUpDown.Value > 59)
            {
                if (hour_unumericUpDown.Value < 23)
                {
                    hour_unumericUpDown.Value += 1;
                    minute_numericUpDown.Value = 0;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int people;
            int doctor;
            int diagnos;

            try
            {
                people = Convert.ToInt32( people_comboBox.Text.Split()[2]);
                doctor = Convert.ToInt32(doctor_comboBox.Text.Split()[2]);
                diagnos = Convert.ToInt32(diagnos_comboBox.Text.Split()[1]);
            }
            catch (Exception er)
            {
                return;
            }
            
            string d_time =string.Format("{0}:{1}",hour_unumericUpDown.Value,minute_numericUpDown.Value);

            string query = "";
            OleDbCommand command;
            OleDbDataReader result_command;

            query = string.Format("INSERT INTO Diagnos (people_card, doctor_id, diagnos, complaints, d_time, d_date) " +
                "VALUES ({0},{1},{2},'{3}','{4}',?)",
                people,
                doctor,
                diagnos,
                g_textBox.Text,
                d_time
                );

            command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@date", DateTime.Parse(date_dateTimePicker.Text));
            command.ExecuteNonQuery();

            Load_db();
            MessageBox.Show("Запись добавлена");
            
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (select_id >= 0)
            {
                string query = "DELETE FROM Diagnos WHERE id = " + select_id;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                Load_db();
                select_id = -1;
                ID_l.Text = "";
                MessageBox.Show("Запись удалена");
            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            if (Diagnos_list.SelectedIndex >= 0 && Diagnos_list.SelectedIndex < d_id.Length)
            {
                OleDbDataReader r_c;
                string[] SelectItems = Diagnos_list.GetItemText(Diagnos_list.SelectedItem).Split();
                string query = "SELECT people_card, doctor_id, d_date, complaints, diagnos, d_time FROM Diagnos WHERE id = " + d_id[Diagnos_list.SelectedIndex];
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader result_command = command.ExecuteReader();

                result_command.Read();

                if (true)
                {
                    query = "SELECT first_name, name, id FROM People WHERE id=" + result_command[0].ToString();
                    command = new OleDbCommand(query, myConnection);
                    r_c = command.ExecuteReader();
                    r_c.Read();
                    people_comboBox.Text = string.Format("{0} {1} {2}", r_c[0].ToString(), r_c[1].ToString(), r_c[2].ToString());


                    query = "SELECT first_name, name, id FROM Doctor WHERE id=" + result_command[1].ToString();
                    command = new OleDbCommand(query, myConnection);
                    r_c = command.ExecuteReader();
                    r_c.Read();
                    doctor_comboBox.Text = string.Format("{0} {1} {2}", r_c[0].ToString(), r_c[1].ToString(), r_c[2].ToString());

                    string test = result_command[2].ToString();
                    date_dateTimePicker.Value = DateTime.Parse(result_command[2].ToString());


                    g_textBox.Text = result_command[3].ToString();


                    diagnos_comboBox.Items.Clear();
                    query = "SELECT name, id FROM Sick WHERE id=" + result_command[4].ToString();
                    command = new OleDbCommand(query, myConnection);
                    r_c = command.ExecuteReader();
                    r_c.Read();
                    diagnos_comboBox.Text = string.Format("{0} {1}", r_c[0].ToString(), r_c[1].ToString());

                    hour_unumericUpDown.Value = Convert.ToInt32(result_command[5].ToString().Split(':')[0]);
                    minute_numericUpDown.Value = Convert.ToInt32(result_command[5].ToString().Split(':')[1]);

                    select_id = d_id[Diagnos_list.SelectedIndex];
                    ID_l.Text = Convert.ToString(select_id);
                }
                
            }
            else
            {
                Load_db();
            }
        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            select_id = -1;
            ID_l.Text = "";
        }
    }
}
