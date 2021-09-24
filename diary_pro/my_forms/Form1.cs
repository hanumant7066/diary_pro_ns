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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit? ","Exit",MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gettime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // ----------show login page first--------

                diary_pro.login_form login_form = new diary_pro.login_form();
                login_form.ShowDialog();

                //----------------------------------------
                gettime();
                getCalender();

                this.version_label2.Text = Application.ProductVersion;

                load_combobox();
                int image_index_from_setting = diary_pro.Properties.Settings.Default.selected_back_image_index;
                load_background_image(image_index_from_setting + 1);

                // load user information
                user_info_loader();

            }
            catch ( Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }
        public void user_info_loader()
        {
            this.username_label4.Text = diary_pro.Properties.Settings.Default.username;
            string fn = Application.StartupPath + "\\data\\user pics\\2.jpg";
            this.user_pictureBox1.Load(fn);


        }

        public void load_combobox()
        {
            for(int i = 1; i <= 8; i++)
            {
                this.back_images_comboBox1.Items.Add("Image "+i);
            }
        }

        public void load_background_image(int i)
        {
            string fn = Application.StartupPath + "//data//pictures//"+i+".jpg";
            this.BackgroundImage = Image.FromFile(fn);

        }
        public void gettime()
        {
            this.timer_label1.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        public void getCalender()
        {
            System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();
            this.y_label4.Text = g.GetYear(DateTime.Now).ToString();
            int m = g.GetMonth(DateTime.Now);
            string month = getMonth(m);
            this.m_label5.Text = month;
            this.d_label6.Text = g.GetDayOfMonth(DateTime.Now).ToString();

            //this.d_label6.Text = DateTime.Now.ToString();

            this.dw_label7.Text = g.GetDayOfWeek(DateTime.Now).ToString();

        }
        public string getMonth(int m)
        {
            string month = "";
            switch (m)
            {
                case 1:
                    month= "January";
                    break;

                case 2:
                    month = "February";
                    break;

                case 3:
                    month = "March";
                    break;

                case 4:
                    month = "April";
                    break;

                case 5:
                    month = "May";
                    break;

                case 6:
                    month = "June";
                    break;

                case 7:
                    month = "jully";
                    break;

                case 8:
                    month = "Auguest";
                    break;

                case 9:
                    month = "September";
                    break;

                case 10:
                    month = "October";
                    break;

                case 11:
                    month = "November";
                    break;

                case 12:
                    month = "December";
                    break;


                default:
                    month = null;
                    break;
            }
            return month;
        }

        private void back_images_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_background_image(this.back_images_comboBox1.SelectedIndex+1);
            diary_pro.Properties.Settings.Default.selected_back_image_index = this.back_images_comboBox1.SelectedIndex;
            diary_pro.Properties.Settings.Default.Save();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.my_forms.about_us au = new diary_pro.my_forms.about_us();
            au.MdiParent = this;
            au.Show();
        }

        private void m_label5_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.my_forms.Users_Management user_manag = new diary_pro.my_forms.Users_Management();
            user_manag.MdiParent = this;
            user_manag.Show();
        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.login_form login_form = new diary_pro.login_form();
            login_form.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            diary_pro.my_forms.memo_form memoform = new diary_pro.my_forms.memo_form();
            memoform.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            diary_pro.my_forms.search_memo search_memo = new my_forms.search_memo();
            search_memo.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                toolStripButton5_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                toolStripButton4_Click(sender, e);
            }

            if (e.KeyCode == Keys.F6)
            {
                this.about_toolStripButton1.ShowDropDown();
            }

            
        }

        private void settings_toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void tools_toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
