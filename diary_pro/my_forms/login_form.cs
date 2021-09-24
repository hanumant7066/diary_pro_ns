using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_pro
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username_textBox2.Text;
            string password = this.password_textBox1.Text;

            string username_from_settings = diary_pro.Properties.Settings.Default.username;
            string password_from_settings = diary_pro.Properties.Settings.Default.user_pass;

            if(username == username_from_settings && password == password_from_settings)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");

            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            try
            {
                user_info_loader();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void user_info_loader()
        {
            this.username_textBox2.Text = diary_pro.Properties.Settings.Default.username;
            this.password_textBox1.Text = diary_pro.Properties.Settings.Default.user_pass;
            string fn = Application.StartupPath + "\\data\\user pics\\2.jpg";
            this.user_pictureBox1.Load(fn);


        }

    }
}
