using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewMember newMember = new NewMember();
            newMember.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewInstructor newInstructor = new NewInstructor();
            newInstructor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewPlan newPlan = new NewPlan();
            newPlan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberUpdate memberUpdate = new MemberUpdate();
            memberUpdate.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstructorUpdate ınstructorUpdate = new InstructorUpdate();
            ınstructorUpdate.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
