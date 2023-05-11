using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace базза_данных
{
    public partial class Main : Form
    {
        Point lastPoint;
        People PeopleWindow = new People();
        Doctors DoctorsWondow = new Doctors();
        Diagnis DiagnisWindow = new Diagnis();
        Sick SickWindow = new Sick();


        public Main()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_button_MouseEnter(object sender, EventArgs e)
        {
            Exit_button.ForeColor= Color.Red;
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

        private void button_people_Click(object sender, EventArgs e)
        {           
            PeopleWindow.Show();
            this.Hide();
        }

        private void button_disgnos_Click(object sender, EventArgs e)
        {
            DiagnisWindow.Show();
            this.Hide();
        }

        private void button_sick_Click(object sender, EventArgs e)
        {           
            SickWindow.Show();
            this.Hide();
        }

        private void button_doctor_Click(object sender, EventArgs e)
        {         
            DoctorsWondow.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports report_window = new Reports();
            report_window.Show();
            this.Hide();
        }
    }
}
