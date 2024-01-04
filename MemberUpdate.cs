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
    public partial class MemberUpdate : Form
    {
        ManegementSystemDbEntities db = new ManegementSystemDbEntities();
        public MemberUpdate()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {
            dataGridViewMember.DataSource = db.Uyeler.ToList();
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
