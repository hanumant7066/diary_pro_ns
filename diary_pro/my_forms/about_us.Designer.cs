
namespace diary_pro.my_forms
{
    partial class about_us
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.project_name_label4 = new System.Windows.Forms.Label();
            this.information_label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.company_name_label1 = new System.Windows.Forms.Label();
            this.product_version_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // project_name_label4
            // 
            this.project_name_label4.AutoSize = true;
            this.project_name_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_name_label4.Location = new System.Drawing.Point(199, 160);
            this.project_name_label4.Name = "project_name_label4";
            this.project_name_label4.Size = new System.Drawing.Size(169, 25);
            this.project_name_label4.TabIndex = 7;
            this.project_name_label4.Text = "diary application";
            // 
            // information_label3
            // 
            this.information_label3.AutoSize = true;
            this.information_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_label3.Location = new System.Drawing.Point(199, 217);
            this.information_label3.Name = "information_label3";
            this.information_label3.Size = new System.Drawing.Size(362, 25);
            this.information_label3.TabIndex = 6;
            this.information_label3.Text = "Some information about appplication";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "All rights reserved to Lenze SDC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // company_name_label1
            // 
            this.company_name_label1.AutoSize = true;
            this.company_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_name_label1.ForeColor = System.Drawing.Color.Red;
            this.company_name_label1.Location = new System.Drawing.Point(198, 25);
            this.company_name_label1.Name = "company_name_label1";
            this.company_name_label1.Size = new System.Drawing.Size(335, 46);
            this.company_name_label1.TabIndex = 4;
            this.company_name_label1.Text = "WinForm Project";
            this.company_name_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // product_version_label1
            // 
            this.product_version_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_version_label1.Location = new System.Drawing.Point(204, 264);
            this.product_version_label1.Name = "product_version_label1";
            this.product_version_label1.Size = new System.Drawing.Size(331, 23);
            this.product_version_label1.TabIndex = 8;
            this.product_version_label1.Text = "Product version";
            // 
            // about_us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.product_version_label1);
            this.Controls.Add(this.project_name_label4);
            this.Controls.Add(this.information_label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.company_name_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about_us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.about_us_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label project_name_label4;
        private System.Windows.Forms.Label information_label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label company_name_label1;
        private System.Windows.Forms.Label product_version_label1;
    }
}