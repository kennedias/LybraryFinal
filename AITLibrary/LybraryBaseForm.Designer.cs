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
            this.reserveABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultCancelReserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSystemLybrary = new System.Windows.Forms.MenuStrip();
            this.groupBoxSystemMessage = new System.Windows.Forms.GroupBox();
            this.labelSystemMessage = new System.Windows.Forms.Label();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowedReservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBorrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.userToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.userToolStripMenuItem.Text = "My Details";
            // 
            // toolStripMenuItemUserDetails
            // 
            this.toolStripMenuItemUserDetails.Name = "toolStripMenuItemUserDetails";
            this.toolStripMenuItemUserDetails.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemUserDetails.Text = "User Details";
            this.toolStripMenuItemUserDetails.Click += new System.EventHandler(this.toolStripMenuItemUserDetails_Click);
            // 
            // myActivitiesToolStripMenuItem
            // 
            this.myActivitiesToolStripMenuItem.Name = "myActivitiesToolStripMenuItem";
            this.myActivitiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.myActivitiesToolStripMenuItem.Text = "My Activity";
            this.myActivitiesToolStripMenuItem.Click += new System.EventHandler(this.myActivitiesToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.reserveToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewBorrowedReservedToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // reserveToolStripMenuItem
            // 
            this.reserveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveABookToolStripMenuItem,
            this.consultCancelReserveToolStripMenuItem});
            this.reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            this.reserveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.reserveToolStripMenuItem.Text = "Reserve";
            this.reserveToolStripMenuItem.Click += new System.EventHandler(this.reserveToolStripMenuItem_Click);
            // 
            // reserveABookToolStripMenuItem
            // 
            this.reserveABookToolStripMenuItem.Name = "reserveABookToolStripMenuItem";
            this.reserveABookToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reserveABookToolStripMenuItem.Text = "Reserve a book";
            this.reserveABookToolStripMenuItem.Click += new System.EventHandler(this.reserveABookToolStripMenuItem_Click);
            // 
            // consultCancelReserveToolStripMenuItem
            // 
            this.consultCancelReserveToolStripMenuItem.Name = "consultCancelReserveToolStripMenuItem";
            this.consultCancelReserveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultCancelReserveToolStripMenuItem.Text = "Consult/Cancel reserve";
            this.consultCancelReserveToolStripMenuItem.Click += new System.EventHandler(this.consultCancelReserveToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem1,
            this.returnToolStripMenuItem});
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            // 
            // borrowToolStripMenuItem1
            // 
            this.borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
            this.borrowToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.borrowToolStripMenuItem1.Text = "Borrow";
            this.borrowToolStripMenuItem1.Click += new System.EventHandler(this.borrowToolStripMenuItem1_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem1,
            this.informationMaintenanceToolStripMenuItem,
            this.userMaintenanceToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.administrationToolStripMenuItem.Text = "System Management";
            // 
            // informationMaintenanceToolStripMenuItem
            // 
            this.informationMaintenanceToolStripMenuItem.Name = "informationMaintenanceToolStripMenuItem";
            this.informationMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informationMaintenanceToolStripMenuItem.Text = "Master Information Domain";
            // 
            // userMaintenanceToolStripMenuItem
            // 
            this.userMaintenanceToolStripMenuItem.Name = "userMaintenanceToolStripMenuItem";
            this.userMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.userMaintenanceToolStripMenuItem.Text = "Users";
            // 
            // menuStripSystemLybrary
            // 
            this.menuStripSystemLybrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.userToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStripSystemLybrary.Location = new System.Drawing.Point(0, 0);
            this.menuStripSystemLybrary.Name = "menuStripSystemLybrary";
            this.menuStripSystemLybrary.Size = new System.Drawing.Size(1108, 24);
            this.menuStripSystemLybrary.TabIndex = 0;
            // 
            // groupBoxSystemMessage
            // 
            this.groupBoxSystemMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSystemMessage.Controls.Add(this.labelSystemMessage);
            this.groupBoxSystemMessage.Location = new System.Drawing.Point(12, 590);
            this.groupBoxSystemMessage.Name = "groupBoxSystemMessage";
            this.groupBoxSystemMessage.Size = new System.Drawing.Size(1084, 32);
            this.groupBoxSystemMessage.TabIndex = 2;
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
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.bookToolStripMenuItem1.Text = "Books";
            this.bookToolStripMenuItem1.Click += new System.EventHandler(this.bookToolStripMenuItem1_Click);
            // 
            // viewBorrowedReservedToolStripMenuItem
            // 
            this.viewBorrowedReservedToolStripMenuItem.Name = "viewBorrowedReservedToolStripMenuItem";
            this.viewBorrowedReservedToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.viewBorrowedReservedToolStripMenuItem.Text = "View Borrowed/Reserved";
            this.viewBorrowedReservedToolStripMenuItem.Click += new System.EventHandler(this.viewBorrowedReservedToolStripMenuItem_Click);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookBorrowedToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // bookBorrowedToolStripMenuItem
            // 
            this.bookBorrowedToolStripMenuItem.Name = "bookBorrowedToolStripMenuItem";
            this.bookBorrowedToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bookBorrowedToolStripMenuItem.Text = "Book Borrowed";
            // 
            // LybraryBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 634);
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
        private System.Windows.Forms.ToolStripMenuItem reserveABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultCancelReserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBoxSystemMessage;
        protected System.Windows.Forms.Label labelSystemMessage;
        private System.Windows.Forms.ToolStripMenuItem informationMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowedReservedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookBorrowedToolStripMenuItem;

    }
}