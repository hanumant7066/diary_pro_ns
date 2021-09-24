using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diary_pro.my_forms
{
    public partial class Users_Management : Form
    {
        public Users_Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string file_name = this.openFileDialog1.FileName;

            this.pictureBox1.Load(file_name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.username_textBox1.Text))
            {
                MessageBox.Show("Username cant be empty");
                return;
            }

            if(this.password_textBox3.Text != this.confirm_Password_textBox2.Text)
            {
                MessageBox.Show("Password and confirm password are not same!!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.password_textBox3.Text))
            {
                MessageBox.Show("Password cant be null!!!");
                return;
            }
            diary_pro.Properties.Settings.Default.username = this.username_textBox1.Text;
            diary_pro.Properties.Settings.Default.user_pass = this.password_textBox3.Text;
            diary_pro.Properties.Settings.Default.Save();

            // save user images ---------------

            if (this.openFileDialog1.FileName != "openFileDialog1")
            {
                string file_name = this.openFileDialog1.FileName;
                string dest_file = Application.StartupPath + "\\data\\user pics\\1.jpg";
                System.IO.File.Copy(file_name, dest_file, true);

            }

            MessageBox.Show("Saved !");
        }

        private void Users_Management_Load(object sender, EventArgs e)
        {
            try
            {
                user_info_loader();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void user_info_loader()
        {
            this.username_textBox1.Text = diary_pro.Properties.Settings.Default.username;
            this.password_textBox3.Text = diary_pro.Properties.Settings.Default.user_pass;
            string fn = Application.StartupPath + "\\data\\user pics\\1.jpg";
            this.pictureBox1.Load(fn);


        }
    }
}
