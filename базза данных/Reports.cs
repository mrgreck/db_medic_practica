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
    public partial class Reports : Form
    {
        Point lastPoint;
        private static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;
        string[] db_table_list = {"Doctor", "People", "Sick"};
        string select_table = "";
        int select_item = 0;
        int select_child_item = 0;




        public Reports()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            InitializeComponent();
            selest_list.Items.Add("Врачи");
            selest_list.Items.Add("Поциенты");
            selest_list.Items.Add("Болезни");
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

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main MainWindow = new Main();
            myConnection.Close();
            MainWindow.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Button test_1 = new Button();
            test_1.Location = new Point(100,100);
            this.Controls.Add(test_1);
            test_1.Location = new Point(200, 10);
            
        }

        private void selest_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selest_list.SelectedItems != null)
            {
                item_list.Items.Clear();
                child_item_list.Items.Clear();

                select_table = db_table_list[selest_list.SelectedIndex];
                string query = "";
                if (select_table == "Sick")
                {
                    query = "SELECT id, name FROM " + select_table + " ORDER BY id";
                }
                else
                {
                    query = "SELECT id, name, first_name FROM " + select_table + " ORDER BY id";
                }


                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader result_command = command.ExecuteReader();
                
                while (result_command.Read())
                {
                    if (select_table == "Sick")
                    {
                        item_list.Items.Add(result_command[0].ToString() + " " + result_command[1].ToString());
                    }
                    else
                    {
                        item_list.Items.Add(result_command[0].ToString() + " " + result_command[1].ToString() + " " + result_command[2].ToString());
                    }
                }
            }
        }

        private void item_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (item_list.SelectedItem != null)
            {
                string query = "SELECT id, doctor_id, people_card, diagnos, d_date FROM Diagnos WHERE id = ORDER BY id";

                int xx = Convert.ToInt32(item_list.SelectedItem.ToString().Split()[0]);

                if (select_table== "Doctor")
                {
                    query = "SELECT id, doctor_id, people_card, diagnos, d_date FROM Diagnos WHERE doctor_id = " + xx;

                }
                else if (select_table == "People")
                {
                    query = "SELECT id, doctor_id, people_card, diagnos, d_date FROM Diagnos WHERE people_card = " + xx;

                }
                else if (select_table == "Sick")
                {
                    query = "SELECT id, doctor_id, people_card, diagnos, d_date FROM Diagnos WHERE diagnos = " + xx;
                }

                OleDbCommand command = new OleDbCommand(query, myConnection);
            
                OleDbDataReader result_command = command.ExecuteReader();
                child_item_list.Items.Clear();

                while (result_command.Read())
                {
                    query = "SELECT name, first_name FROM People WHERE id = " + result_command[2];
                    OleDbCommand command2 = new OleDbCommand(query, myConnection);
                    OleDbDataReader x = command2.ExecuteReader();
                    if (x.Read())
                    {
                        query = "SELECT name FROM Sick WHERE id = " + result_command[3];
                        OleDbCommand command3 = new OleDbCommand(query, myConnection);
                        OleDbDataReader sick = command3.ExecuteReader();
                        if (sick.Read())
                        {
                            child_item_list.Items.Add(result_command[0] + ":" + result_command[1] + ")" + x[0] + " " + x[1] + ":" + sick[0] + " " + result_command[4].ToString().Split()[0]);
                        }
                    }
                }
                
            }
        }

        private void child_item_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (child_item_list.SelectedItem != null)
            {
                report_textBox.Text = "";
                char[] p = { ')', ':', ' ' };

                string[] select_items = child_item_list.SelectedItem.ToString().Split(p);
                string text = "";

                string query = "SELECT name, first_name FROM Doctor WHERE id = " + select_items[1];
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader command_result = command.ExecuteReader();
                command_result.Read();
                text += "Врач: " + command_result[0].ToString() + " " + command_result[1].ToString() + "\r\n";
                text += "Поциент: " + select_items[2] + " " + select_items[3] + "\r\n";
                text += "Дата:" + select_items[5] + "\r\n";
                text += "Диагноз:" + select_items[4] + "\r\n";

                query = "SELECT complaints FROM Diagnos WHERE id = " + select_items[0];
                command = new OleDbCommand(query, myConnection);
                command_result = command.ExecuteReader();
                command_result.Read();

                text += "Коментарии Врача:" + command_result[0] + "\r\n";

                report_textBox.Text = text;
            }
            
        }
    }
}
