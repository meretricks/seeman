
namespace winct
{
    partial class _container
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
            this.components = new System.ComponentModel.Container();
            this.panel_mod = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Manager = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_status = new System.Windows.Forms.Panel();
            this.label_SyncStatus = new System.Windows.Forms.Label();
            this.label_sync = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tConsole = new System.Windows.Forms.TextBox();
            this.panel_mod.SuspendLayout();
            this.panel_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mod
            // 
            this.panel_mod.AutoSize = true;
            this.panel_mod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_mod.BackColor = System.Drawing.Color.White;
            this.panel_mod.Controls.Add(this.btn_Manager);
            this.panel_mod.Controls.Add(this.btn_Edit);
            this.panel_mod.Controls.Add(this.btn_About);
            this.panel_mod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_mod.Location = new System.Drawing.Point(0, 0);
            this.panel_mod.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mod.Name = "panel_mod";
            this.panel_mod.Size = new System.Drawing.Size(1169, 23);
            this.panel_mod.TabIndex = 2;
            // 
            // btn_Manager
            // 
            this.btn_Manager.AutoSize = true;
            this.btn_Manager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Manager.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Manager.FlatAppearance.BorderSize = 0;
            this.btn_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manager.Location = new System.Drawing.Point(0, 0);
            this.btn_Manager.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Manager.Name = "btn_Manager";
            this.btn_Manager.Size = new System.Drawing.Size(59, 23);
            this.btn_Manager.TabIndex = 0;
            this.btn_Manager.Text = "&Manager";
            this.btn_Manager.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoSize = true;
            this.btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(59, 0);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(35, 23);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "&Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_About
            // 
            this.btn_About.AutoSize = true;
            this.btn_About.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_About.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Location = new System.Drawing.Point(94, 0);
            this.btn_About.Margin = new System.Windows.Forms.Padding(0);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(45, 23);
            this.btn_About.TabIndex = 2;
            this.btn_About.Text = "&About";
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.GhostWhite;
            this.splitter1.Location = new System.Drawing.Point(212, 23);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 564);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HotTracking = true;
            this.treeView1.Indent = 16;
            this.treeView1.Location = new System.Drawing.Point(0, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(212, 564);
            this.treeView1.TabIndex = 0;
            // 
            // panel_status
            // 
            this.panel_status.BackColor = System.Drawing.Color.Goldenrod;
            this.panel_status.Controls.Add(this.label_SyncStatus);
            this.panel_status.Controls.Add(this.label_sync);
            this.panel_status.Controls.Add(this.pictureBox1);
            this.panel_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_status.Location = new System.Drawing.Point(0, 587);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(1169, 21);
            this.panel_status.TabIndex = 0;
            // 
            // label_SyncStatus
            // 
            this.label_SyncStatus.AutoSize = true;
            this.label_SyncStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_SyncStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_SyncStatus.ForeColor = System.Drawing.Color.White;
            this.label_SyncStatus.Location = new System.Drawing.Point(76, 4);
            this.label_SyncStatus.Name = "label_SyncStatus";
            this.label_SyncStatus.Size = new System.Drawing.Size(63, 15);
            this.label_SyncStatus.TabIndex = 2;
            this.label_SyncStatus.Text = "Local Only";
            // 
            // label_sync
            // 
            this.label_sync.AutoSize = true;
            this.label_sync.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label_sync.ForeColor = System.Drawing.Color.White;
            this.label_sync.Location = new System.Drawing.Point(19, 4);
            this.label_sync.Name = "label_sync";
            this.label_sync.Size = new System.Drawing.Size(70, 15);
            this.label_sync.TabIndex = 1;
            this.label_sync.Text = "Cloud Sync:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seeman.Properties.Resources._019;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContainerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // newContainerToolStripMenuItem
            // 
            this.newContainerToolStripMenuItem.Name = "newContainerToolStripMenuItem";
            this.newContainerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newContainerToolStripMenuItem.Text = "New &Container";
            this.newContainerToolStripMenuItem.Click += new System.EventHandler(this.newContainerToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button_run);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(215, 23);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(954, 23);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Placeholder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_run
            // 
            this.button_run.AutoSize = true;
            this.button_run.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_run.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_run.FlatAppearance.BorderSize = 0;
            this.button_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run.Location = new System.Drawing.Point(73, 0);
            this.button_run.Margin = new System.Windows.Forms.Padding(0);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(37, 23);
            this.button_run.TabIndex = 1;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(218, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(948, 362);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "name=\'_asset_container\' dir=\'C:\\_assets\' encoding=\'UTF8\'\r\nname=\'resources\' parent" +
    "=\'_asset_container\' node_type=\'Folder\'\r\nname=\'file 1\' parent=\'resources\' size=\'1" +
    "024\' index=\'0\' node_type=\'File\'";
            // 
            // tConsole
            // 
            this.tConsole.BackColor = System.Drawing.Color.Black;
            this.tConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tConsole.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tConsole.ForeColor = System.Drawing.Color.White;
            this.tConsole.Location = new System.Drawing.Point(215, 413);
            this.tConsole.Multiline = true;
            this.tConsole.Name = "tConsole";
            this.tConsole.Size = new System.Drawing.Size(954, 174);
            this.tConsole.TabIndex = 8;
            // 
            // _container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1169, 608);
            this.Controls.Add(this.tConsole);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel_mod);
            this.Controls.Add(this.panel_status);
            this.Name = "_container";
            this.Text = "Container Manager";
            this.panel_mod.ResumeLayout(false);
            this.panel_mod.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panel_mod;
        private System.Windows.Forms.Button btn_Manager;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_sync;
        private System.Windows.Forms.Label label_SyncStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newContainerToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tConsole;
    }
}

