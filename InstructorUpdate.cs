using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.model;

namespace ManagementSystem
{
    public partial class InstructorUpdate : Form
    {
        ManegementSystemDbEntities db = new ManegementSystemDbEntities();
        public InstructorUpdate()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void dataGridViewInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InstructorUpdate_Load(object sender, EventArgs e)
        {
            dataGridViewInstructor.DataSource = db.Egitmenler.ToList();
        }
    }
}
