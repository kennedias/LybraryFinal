namespace AITLibrary
{
    partial class LybraryBaseForm
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
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.myActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSystemLybrary = new System.Windows.Forms.MenuStrip();
            this.groupBoxSystemMessage = new System.Windows.Forms.GroupBox();
            this.labelSystemMessage = new System.Windows.Forms.Label();
            this.menuStripSystemLybrary.SuspendLayout();
            this.groupBoxSystemMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUserDetails,
            this.myActivitiesToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // toolStripMenuItemUserDetails
            // 
            this.toolStripMenuItemUserDetails.Name = "toolStripMenuItemUserDetails";
            this.toolStripMenuItemUserDetails.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemUserDetails.Text = "User Details";
            this.toolStripMenuItemUserDetails.Click += new System.EventHandler(this.toolStripMenuItemUserDetails_Click);
            // 
            // myActivitiesToolStripMenuItem
            // 
            this.myActivitiesToolStripMenuItem.Name = "myActivitiesToolStripMenuItem";
            this.myActivitiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myActivitiesToolStripMenuItem.Text = "My Activities";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.reserveToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // reserveToolStripMenuItem
            // 
            this.reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            this.reserveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reserveToolStripMenuItem.Text = "Reserve";
            this.reserveToolStripMenuItem.Click += new System.EventHandler(this.reserveToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.administrationToolStripMenuItem.Text = "System Management";
            // 
            // menuStripSystemLybrary
            // 
            this.menuStripSystemLybrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStripSystemLybrary.Location = new System.Drawing.Point(0, 0);
            this.menuStripSystemLybrary.Name = "menuStripSystemLybrary";
            this.menuStripSystemLybrary.Size = new System.Drawing.Size(1076, 24);
            this.menuStripSystemLybrary.TabIndex = 0;
            // 
            // groupBoxSystemMessage
            // 
            this.groupBoxSystemMessage.Controls.Add(this.labelSystemMessage);
            this.groupBoxSystemMessage.Location = new System.Drawing.Point(12, 443);
            this.groupBoxSystemMessage.Name = "groupBoxSystemMessage";
            this.groupBoxSystemMessage.Size = new System.Drawing.Size(1008, 32);
            this.groupBoxSystemMessage.TabIndex = 1;
            this.groupBoxSystemMessage.TabStop = false;
            this.groupBoxSystemMessage.Text = "System Message";
            // 
            // labelSystemMessage
            // 
            this.labelSystemMessage.AutoSize = true;
            this.labelSystemMessage.Location = new System.Drawing.Point(6, 16);
            this.labelSystemMessage.Name = "labelSystemMessage";
            this.labelSystemMessage.Size = new System.Drawing.Size(16, 13);
            this.labelSystemMessage.TabIndex = 0;
            this.labelSystemMessage.Text = "...";
            // 
            // LybraryBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 487);
            this.Controls.Add(this.groupBoxSystemMessage);
            this.Controls.Add(this.menuStripSystemLybrary);
            this.MainMenuStrip = this.menuStripSystemLybrary;
            this.Name = "LybraryBaseForm";
            this.Text = "LybraryBaseForm";
            this.menuStripSystemLybrary.ResumeLayout(false);
            this.menuStripSystemLybrary.PerformLayout();
            this.groupBoxSystemMessage.ResumeLayout(false);
            this.groupBoxSystemMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUserDetails;
        private System.Windows.Forms.ToolStripMenuItem myActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripSystemLybrary;
        private System.Windows.Forms.GroupBox groupBoxSystemMessage;
        protected System.Windows.Forms.Label labelSystemMessage;

    }
}