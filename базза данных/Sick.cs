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
    public partial class Sick : Form
    {
        private static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;
        Point lastPoint;

        private void Load_db()
        {
            Sick_list.Items.Clear();

            string query = "SELECT name FROM Sick ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader result_command = command.ExecuteReader();

            while (result_command.Read())
            {
                Sick_list.Items.Add(result_command[0].ToString());
            }
        }

        public Sick()
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

        private void Sick_Load(object sender, EventArgs e)
        {
            Load_db();
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            string SelectItem = Sick_list.GetItemText(Sick_list.SelectedItem);
            string query = "SELECT comment FROM Sick WHERE name = '" + SelectItem + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            object result_command = command.ExecuteScalar();
            if (result_command != null)
            {
                name_textBox.Text = SelectItem;
                coment_textBox.Text = result_command.ToString();
            }
            else
            {
                Load_db();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT comment FROM Sick WHERE name = '" + name_textBox.Text + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            object result_command = command.ExecuteScalar();
            if (result_command == null)
            {
                query = "INSERT INTO Sick (name, comment) VALUES ('" + name_textBox.Text + "','" + coment_textBox.Text + "')";
                command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                Load_db();
                MessageBox.Show("Запись добавлена");
            }
            else
            {
                MessageBox.Show("Такая болезнь уже есть!!");
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {

            string query = "SELECT comment FROM Sick WHERE name = '" + name_textBox.Text + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            object result_command = command.ExecuteScalar();
            if (result_command != null)
            {
                query = "UPDATE Sick SET comment = '" + coment_textBox.Text + "' WHERE name = '" + name_textBox.Text + "'";
                command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись обновлена");
            }
            else
            {
                MessageBox.Show("Такой болезни нет!!!");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT comment FROM Sick WHERE name = '" + name_textBox.Text + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            object result_command = command.ExecuteScalar();
            if (result_command != null)
            {
                query = "DELETE FROM Sick WHERE name = '" + name_textBox.Text + "'";
                command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                Load_db();
                MessageBox.Show("Запись удалена");
            }
            else
            {
                MessageBox.Show("Такой болезни нет!!!");

            }
        }
    }
}
