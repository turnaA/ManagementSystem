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
    public partial class NewPlan : Form
    {
        ManegementSystemDbEntities db = new ManegementSystemDbEntities();
        public NewPlan()
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

        private void NewPlan_Load(object sender, EventArgs e)
        {
            dataGridViewPlan.DataSource = db.Plan_Tur.ToList();
        }
    }
}
