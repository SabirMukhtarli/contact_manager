namespace contact_manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteLink = new System.Windows.Forms.LinkLabel();
            this.updateLink = new System.Windows.Forms.LinkLabel();
            this.insertLink = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseLink = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logOutLink = new System.Windows.Forms.LinkLabel();
            this.pictureLogOut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.pictureLogOut);
            this.panel1.Controls.Add(this.logOutLink);
            this.panel1.Controls.Add(this.deleteLink);
            this.panel1.Controls.Add(this.updateLink);
            this.panel1.Controls.Add(this.insertLink);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
          
            // 
            // deleteLink
            // 
            this.deleteLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.deleteLink, "deleteLink");
            this.deleteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.deleteLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.TabStop = true;
            this.deleteLink.UseCompatibleTextRendering = true;
            this.deleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLink_LinkClicked);
            // 
            // updateLink
            // 
            this.updateLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.updateLink, "updateLink");
            this.updateLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.updateLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.updateLink.Name = "updateLink";
            this.updateLink.TabStop = true;
            this.updateLink.UseCompatibleTextRendering = true;
            this.updateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLink_LinkClicked);
            // 
            // insertLink
            // 
            this.insertLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.insertLink, "insertLink");
            this.insertLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.insertLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.insertLink.Name = "insertLink";
            this.insertLink.TabStop = true;
            this.insertLink.UseCompatibleTextRendering = true;
            this.insertLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.insertLink_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // CloseLink
            // 
            this.CloseLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(118)))), ((int)(((byte)(172)))));
            resources.ApplyResources(this.CloseLink, "CloseLink");
            this.CloseLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.CloseLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.CloseLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.CloseLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.CloseLink.Name = "CloseLink";
            this.CloseLink.TabStop = true;
            this.CloseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseLink_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // logOutLink
            // 
            this.logOutLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            resources.ApplyResources(this.logOutLink, "logOutLink");
            this.logOutLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.logOutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logOutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(85)))));
            this.logOutLink.Name = "logOutLink";
            this.logOutLink.TabStop = true;
            this.logOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutLink_LinkClicked);
            // 
            // pictureLogOut
            // 
            resources.ApplyResources(this.pictureLogOut, "pictureLogOut");
            this.pictureLogOut.Name = "pictureLogOut";
            this.pictureLogOut.TabStop = false;
            this.pictureLogOut.Click += new System.EventHandler(this.pictureLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.CloseLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel CloseLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel insertLink;
        private System.Windows.Forms.LinkLabel updateLink;
        private System.Windows.Forms.LinkLabel deleteLink;
        private System.Windows.Forms.PictureBox pictureLogOut;
        private System.Windows.Forms.LinkLabel logOutLink;
    }
}