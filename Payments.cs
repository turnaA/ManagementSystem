using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.model;

namespace ManagementSystem
{
    public partial class Payments : Form
    {
        ManegementSystemDbEntities db = new ManegementSystemDbEntities();
        public Payments()
        {
            InitializeComponent();
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

        private void dataGridViewPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            dataGridViewPayment.DataSource = db.Odemeler.ToList();
        }
    }
}
