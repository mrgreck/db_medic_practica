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
    public partial class Doctors : Form
    {
        private static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;
        Point lastPoint;
        int[] d_id;

        private void Load_db()
        {
            Doct_list.Items.Clear();
            d_id = new int[1000];

            string query = "SELECT first_name, name, id FROM Doctor ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            int i = 0;
            while (result_command.Read())
            {
                d_id[i]=Convert.ToInt32(result_command[2].ToString());
                i++;
                Doct_list.Items.Add(result_command[0].ToString()+" "+result_command[1].ToString());
            }
        }



        public Doctors()
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

        private void Doctors_Load(object sender, EventArgs e)
        {
            Load_db();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT first_name FROM Doctor WHERE name = '" + name_textBox.Text + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();

            query = "INSERT INTO Doctor (name, first_name, cabinet, Pskill) VALUES ('" + name_textBox.Text + "','" + first_name_textBox.Text + "','" + cabin_numericUpDown.Value + "','" + Pskill_numericUpDown.Value + "')";
            if (result_command == null)
            {
                command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                Load_db();
                MessageBox.Show("Запись добавлена");
            }
            else
            {
                bool flag = false;
                while(!flag && result_command.Read())
                {
                    if (first_name_textBox.Text == result_command[0].ToString())
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    command = new OleDbCommand(query, myConnection);
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT first_name, name, id FROM Doctor ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                if (result_command[0].ToString() == first_name_textBox.Text && result_command[1].ToString() == name_textBox.Text)
                {
                    query = "DELETE FROM Doctor WHERE id = " + result_command[2].ToString();
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
            string query = "SELECT first_name, name, id FROM Doctor ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();
            while (result_command.Read())
            {
                if (result_command[0].ToString() == first_name_textBox.Text && result_command[1].ToString() == name_textBox.Text)
                {
                    query = "UPDATE Doctor SET cabinet = " + cabin_numericUpDown.Value +", Pskill="+ Pskill_numericUpDown.Value +" WHERE id = " + result_command[2];
                    command = new OleDbCommand(query, myConnection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена");
                    break;
                }
            }
            
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            if (Doct_list.SelectedIndex >= 0 && Doct_list.SelectedIndex < d_id.Length)
            {
                string[] SelectItems = Doct_list.GetItemText(Doct_list.SelectedItem).Split();
                string query = "SELECT cabinet, Pskill FROM Doctor WHERE id = " + d_id[Doct_list.SelectedIndex];
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader result_command = command.ExecuteReader();

                result_command.Read();
                first_name_textBox.Text = SelectItems[0];
                name_textBox.Text = SelectItems[1];
                cabin_numericUpDown.Value = Convert.ToInt32( result_command[0].ToString());
                Pskill_numericUpDown.Value =Convert.ToInt32( result_command[1].ToString());

                
            }
            else
            {
                Load_db();
            }
        }

        
    }


}
