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
    public partial class People : Form
    {
        private static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;
        Point lastPoint;
        int[] d_id;

        private void Load_db()
        {
            People_list.Items.Clear();
            d_id = new int[1000];

            string query = "SELECT first_name, name, id FROM People ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            int i = 0;
            while (result_command.Read())
            {
                d_id[i] = Convert.ToInt32(result_command[2].ToString());
                i++;
                People_list.Items.Add(result_command[0].ToString() + " " + result_command[1].ToString());
            }
        }

       

        public People()
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
            MainWindow.Show();
            myConnection.Close();
            this.Hide();
        }

        private void People_Load(object sender, EventArgs e)
        {
            Load_db();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            name_textBox.Text = name_textBox.Text.Split()[0];
            first_name_textBox.Text = first_name_textBox.Text.Split()[0];

            if (name_textBox.Text!="" && first_name_textBox.Text!="")
            {
                string query = "SELECT first_name FROM People WHERE name = '" + name_textBox.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader result_command = command.ExecuteReader();

                query = string.Format("INSERT INTO People (name, first_name, age, pl, p, otmet, location, last_date) " +
                    "VALUES ('{0}','{1}',{2},'{3}','{4}','{5}','{6}',?)",
                    name_textBox.Text,
                    first_name_textBox.Text,
                    age_numericUpDown.Value,
                    pl_textBox.Text,
                    p_textBox.Text,
                    otmet_textBox.Text,
                    l_textBox.Text);


                command = new OleDbCommand(query, myConnection);
                command.Parameters.AddWithValue("@date", DateTime.Parse(last_date_dateTimePicker.Text));
                if (result_command == null)
                {

                    command.ExecuteNonQuery();
                    Load_db();
                    MessageBox.Show("Запись добавлена");
                }
                else
                {
                    bool flag = false;
                    while (!flag && result_command.Read())
                    {
                        if (first_name_textBox.Text == result_command[0].ToString())
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        command.ExecuteNonQuery();
                        Load_db();
                        MessageBox.Show("Запись добавлена");
                    }
                    else
                    {
                        MessageBox.Show("Этот доктор уже добавлен");
                    }

                }
            }
            else
            {
                MessageBox.Show("Данные введены не коректно или нет имени и фамилии");
            }  
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT first_name, name, id FROM People ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                if (result_command[0].ToString() == first_name_textBox.Text && result_command[1].ToString() == name_textBox.Text)
                {
                    query = "DELETE FROM People WHERE id = " + result_command[2].ToString();
                    command = new OleDbCommand(query, myConnection);
                    command.ExecuteNonQuery();
                    Load_db();
                    MessageBox.Show("Запись удалена");
                    break;
                }

            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT first_name, name, id FROM People ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                if (result_command[0].ToString() == first_name_textBox.Text && result_command[1].ToString() == name_textBox.Text)
                {
                    query = string.Format("UPDATE People SET age = {0}, pl = '{1}', p = '{2}', otmet = '{3}', location = '{4}', last_date = ? WHERE id = {5}",
                        age_numericUpDown.Value, 
                        pl_textBox.Text,
                        p_textBox.Text,
                        otmet_textBox.Text,
                        l_textBox.Text,
                        result_command[2]);

                    command = new OleDbCommand(query, myConnection);
                    command.Parameters.AddWithValue("@date", DateTime.Parse(last_date_dateTimePicker.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена");
                    break;
                }
            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            if (People_list.SelectedIndex >= 0 && People_list.SelectedIndex < d_id.Length)
            {
                string[] SelectItems = People_list.GetItemText(People_list.SelectedItem).Split();
                string query = "SELECT age, pl, p, last_date, otmet, location FROM People WHERE id = " + d_id[People_list.SelectedIndex];
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader result_command = command.ExecuteReader();

                result_command.Read();
                first_name_textBox.Text = SelectItems[0];
                name_textBox.Text = SelectItems[1];
                age_numericUpDown.Value = Convert.ToInt32( result_command[0].ToString());
                pl_textBox.Text = result_command[1].ToString();
                p_textBox.Text = result_command[2].ToString();
                last_date_dateTimePicker.Value = DateTime.Parse(result_command[3].ToString());
                otmet_textBox.Text = result_command[4].ToString();
                l_textBox.Text = result_command[5].ToString();
                Id_L.Text = Convert.ToString(d_id[People_list.SelectedIndex]);
            }
            else
            {
                Load_db();
            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
            Id_L.Text = "";
        }
    }
}
