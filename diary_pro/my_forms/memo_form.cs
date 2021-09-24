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
    public partial class memo_form : Form
    {
        public memo_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.save_memo_button2.Enabled = false;
            this.new_memo_button1.Enabled = true;

            // ------------------------
            int last_id;
            last_id = diary_pro.Properties.Settings.Default.last_id;
            last_id++;

            //-------------------------
            diary_pro.Properties.Settings.Default.last_id = last_id;
            diary_pro.Properties.Settings.Default.Save();

            // ----------------------
            string memo_title = this.memo_title_textBox1.Text;
            string memo_date = this.memo_date_textBox2.Text;
            string path_title=Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".txt";
            string path_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".txt";

            System.IO.File.WriteAllText(path_title, memo_title, Encoding.UTF8);
            System.IO.File.WriteAllText(path_date, memo_date, Encoding.UTF8);


            string file_name = Application.StartupPath +"\\data\\docs\\"+ last_id.ToString() +".rtf";
            this.richTextBox1.SaveFile(file_name);
            MessageBox.Show("Your Memo Saved ");


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void memo_form_Load(object sender, EventArgs e)
        {
            try
            {
                this.groupBox1.Enabled = false;
                this.save_memo_button2.Enabled = false;

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void new_memo_button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.new_memo_button1.Enabled = false;
            this.save_memo_button2.Enabled = true;

            //-----------------

            this.id_textBox1.Text = (diary_pro.Properties.Settings.Default.last_id + 1).ToString();

            //------------------------

            //------Reseting text Boxes-----
            this.memo_title_textBox1.ResetText();
            this.memo_date_textBox2.ResetText();
            this.richTextBox1.ResetText();

            //---------------

            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
