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
    public partial class search_memo : Form
    {
        public search_memo()
        {
            InitializeComponent();
        }

        private void search_memo_Load(object sender, EventArgs e)
        {
            try
            {
                int no_of_memos = diary_pro.Properties.Settings.Default.last_id;
                for (int i = 1; i <= no_of_memos; i++)
                {
                    this.listBox1.Items.Add(i.ToString());
                }
            }
            catch (Exception ep)
            {

                MessageBox.Show(ep.ToString());
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_id;
            int.TryParse(this.listBox1.Text, out selected_id);

            string path_rtf = Application.StartupPath + "\\data\\docs\\" + selected_id.ToString() + ".rtf";
            string path_title = Application.StartupPath + "\\data\\docs\\title_" + selected_id.ToString() + ".txt";
            string path_date = Application.StartupPath + "\\data\\docs\\date_" + selected_id.ToString() + ".txt";

            this.id_textBox1.Text = selected_id.ToString();
            this.memo_title_textBox1.Text = System.IO.File.ReadAllText(path_title, Encoding.UTF8);
            this.memo_date_textBox2.Text = System.IO.File.ReadAllText(path_date, Encoding.UTF8);

            this.richTextBox1.LoadFile(path_rtf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected_id = this.listBox1.FindStringExact(this.search_textBox1.Text);

            this.listBox1.SelectedIndex = selected_id;
        }
    }
}
