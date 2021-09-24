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
    public partial class about_us : Form
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void about_us_Load(object sender, EventArgs e)
        {
            this.company_name_label1.Text = Application.CompanyName;
            this.project_name_label4.Text = "Product Name- "+Application.ProductName;
            this.product_version_label1.Text = "Product Version- "+Application.ProductVersion;
        }
    }
}
