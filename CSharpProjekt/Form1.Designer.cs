namespace CSharpProjekt
{
    partial class Form1
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
            this.tabbed_views = new System.Windows.Forms.TabControl();
            this.hot_tab_page = new System.Windows.Forms.TabPage();
            this.newest_tab_page = new System.Windows.Forms.TabPage();
            this.tag_search_tab_page = new System.Windows.Forms.TabPage();
            this.gallery_tab_page = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabbed_views.SuspendLayout();
            this.tag_search_tab_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbed_views
            // 
            this.tabbed_views.Controls.Add(this.hot_tab_page);
            this.tabbed_views.Controls.Add(this.newest_tab_page);
            this.tabbed_views.Controls.Add(this.tag_search_tab_page);
            this.tabbed_views.Controls.Add(this.gallery_tab_page);
            this.tabbed_views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabbed_views.Location = new System.Drawing.Point(0, 0);
            this.tabbed_views.Name = "tabbed_views";
            this.tabbed_views.SelectedIndex = 0;
            this.tabbed_views.Size = new System.Drawing.Size(716, 664);
            this.tabbed_views.TabIndex = 0;
            // 
            // hot_tab_page
            // 
            this.hot_tab_page.Location = new System.Drawing.Point(4, 22);
            this.hot_tab_page.Name = "hot_tab_page";
            this.hot_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.hot_tab_page.Size = new System.Drawing.Size(790, 334);
            this.hot_tab_page.TabIndex = 0;
            this.hot_tab_page.Text = "Hot Deviations";
            this.hot_tab_page.UseVisualStyleBackColor = true;
            // 
            // newest_tab_page
            // 
            this.newest_tab_page.Location = new System.Drawing.Point(4, 22);
            this.newest_tab_page.Name = "newest_tab_page";
            this.newest_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.newest_tab_page.Size = new System.Drawing.Size(790, 334);
            this.newest_tab_page.TabIndex = 1;
            this.newest_tab_page.Text = "Newest";
            this.newest_tab_page.UseVisualStyleBackColor = true;
            // 
            // tag_search_tab_page
            // 
            this.tag_search_tab_page.Controls.Add(this.button1);
            this.tag_search_tab_page.Controls.Add(this.textBox1);
            this.tag_search_tab_page.Location = new System.Drawing.Point(4, 22);
            this.tag_search_tab_page.Name = "tag_search_tab_page";
            this.tag_search_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.tag_search_tab_page.Size = new System.Drawing.Size(708, 638);
            this.tag_search_tab_page.TabIndex = 2;
            this.tag_search_tab_page.Text = "Tag Search";
            this.tag_search_tab_page.UseVisualStyleBackColor = true;
            // 
            // gallery_tab_page
            // 
            this.gallery_tab_page.Location = new System.Drawing.Point(4, 22);
            this.gallery_tab_page.Name = "gallery_tab_page";
            this.gallery_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.gallery_tab_page.Size = new System.Drawing.Size(790, 334);
            this.gallery_tab_page.TabIndex = 3;
            this.gallery_tab_page.Text = "Local Gallery";
            this.gallery_tab_page.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 664);
            this.Controls.Add(this.tabbed_views);
            this.Name = "Form1";
            this.Text = "Deviantart Browser";
            this.tabbed_views.ResumeLayout(false);
            this.tag_search_tab_page.ResumeLayout(false);
            this.tag_search_tab_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabbed_views;
        private System.Windows.Forms.TabPage hot_tab_page;
        private System.Windows.Forms.TabPage newest_tab_page;
        private System.Windows.Forms.TabPage tag_search_tab_page;
        private System.Windows.Forms.TabPage gallery_tab_page;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;


    }
}

