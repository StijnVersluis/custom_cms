
namespace View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.websiteDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshWebsitesBtn = new System.Windows.Forms.Button();
            this.pagesDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshPagesBtn = new System.Windows.Forms.Button();
            this.refreshComponentsBtn = new System.Windows.Forms.Button();
            this.componentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.websiteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // websiteDataGridView
            // 
            this.websiteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.websiteDataGridView.Location = new System.Drawing.Point(12, 12);
            this.websiteDataGridView.Name = "websiteDataGridView";
            this.websiteDataGridView.RowTemplate.Height = 25;
            this.websiteDataGridView.Size = new System.Drawing.Size(275, 284);
            this.websiteDataGridView.TabIndex = 0;
            this.websiteDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.websiteDataGridView_CellContentDoubleClick);
            // 
            // refreshWebsitesBtn
            // 
            this.refreshWebsitesBtn.Location = new System.Drawing.Point(12, 302);
            this.refreshWebsitesBtn.Name = "refreshWebsitesBtn";
            this.refreshWebsitesBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshWebsitesBtn.TabIndex = 1;
            this.refreshWebsitesBtn.Text = "Refresh";
            this.refreshWebsitesBtn.UseVisualStyleBackColor = true;
            this.refreshWebsitesBtn.Click += new System.EventHandler(this.refreshWebsitesBtn_Click);
            // 
            // pagesDataGridView
            // 
            this.pagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagesDataGridView.Location = new System.Drawing.Point(293, 12);
            this.pagesDataGridView.Name = "pagesDataGridView";
            this.pagesDataGridView.RowTemplate.Height = 25;
            this.pagesDataGridView.Size = new System.Drawing.Size(275, 284);
            this.pagesDataGridView.TabIndex = 2;
            // 
            // refreshPagesBtn
            // 
            this.refreshPagesBtn.Location = new System.Drawing.Point(293, 302);
            this.refreshPagesBtn.Name = "refreshPagesBtn";
            this.refreshPagesBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshPagesBtn.TabIndex = 3;
            this.refreshPagesBtn.Text = "Refresh";
            this.refreshPagesBtn.UseVisualStyleBackColor = true;
            this.refreshPagesBtn.Click += new System.EventHandler(this.refreshPagesBtn_Click);
            // 
            // refreshComponentsBtn
            // 
            this.refreshComponentsBtn.Location = new System.Drawing.Point(574, 302);
            this.refreshComponentsBtn.Name = "refreshComponentsBtn";
            this.refreshComponentsBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshComponentsBtn.TabIndex = 5;
            this.refreshComponentsBtn.Text = "Refresh";
            this.refreshComponentsBtn.UseVisualStyleBackColor = true;
            this.refreshComponentsBtn.Click += new System.EventHandler(this.refreshComponentsBtn_Click);
            // 
            // componentsDataGridView
            // 
            this.componentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsDataGridView.Location = new System.Drawing.Point(574, 12);
            this.componentsDataGridView.Name = "componentsDataGridView";
            this.componentsDataGridView.RowTemplate.Height = 25;
            this.componentsDataGridView.Size = new System.Drawing.Size(275, 284);
            this.componentsDataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.refreshComponentsBtn);
            this.Controls.Add(this.componentsDataGridView);
            this.Controls.Add(this.refreshPagesBtn);
            this.Controls.Add(this.pagesDataGridView);
            this.Controls.Add(this.refreshWebsitesBtn);
            this.Controls.Add(this.websiteDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.websiteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView websiteDataGridView;
        private System.Windows.Forms.Button refreshWebsitesBtn;
        private System.Windows.Forms.DataGridView pagesDataGridView;
        private System.Windows.Forms.Button refreshPagesBtn;
        private System.Windows.Forms.Button refreshComponentsBtn;
        private System.Windows.Forms.DataGridView componentsDataGridView;
    }
}

