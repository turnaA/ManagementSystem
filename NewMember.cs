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
    
    public partial class NewMember : Form
    {
        ManegementSystemDbEntities db = new ManegementSystemDbEntities();
        public NewMember()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NewMember M = new NewMember();
           
        }

        private void NewMember_Load(object sender, EventArgs e)
        {
           
        }

}
}
