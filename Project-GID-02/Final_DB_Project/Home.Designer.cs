
namespace Final_DB_Project
{
    partial class Home
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
            this.home_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // home_table_panel
            // 
            this.home_table_panel.BackgroundImage = global::Final_DB_Project.Properties.Resources.backgroundPic5;
            this.home_table_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_table_panel.ColumnCount = 1;
            this.home_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_table_panel.Location = new System.Drawing.Point(0, 0);
            this.home_table_panel.Name = "home_table_panel";
            this.home_table_panel.RowCount = 1;
            this.home_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.home_table_panel.Size = new System.Drawing.Size(903, 512);
            this.home_table_panel.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 512);
            this.Controls.Add(this.home_table_panel);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel home_table_panel;
    }
}