
namespace seeman
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_TopFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.button_manage = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_sync = new System.Windows.Forms.Button();
            this.panel_mod = new System.Windows.Forms.Panel();
            this.lable_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ico_Status = new System.Windows.Forms.PictureBox();
            this.context_Manage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.welcomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorView1 = new seeman.EditorView();
            this.panel_TopFlow.SuspendLayout();
            this.panel_mod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Status)).BeginInit();
            this.context_Manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TopFlow
            // 
            this.panel_TopFlow.AutoSize = true;
            this.panel_TopFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_TopFlow.BackColor = System.Drawing.Color.Transparent;
            this.panel_TopFlow.Controls.Add(this.button_manage);
            this.panel_TopFlow.Controls.Add(this.button_edit);
            this.panel_TopFlow.Controls.Add(this.button_sync);
            this.panel_TopFlow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopFlow.Location = new System.Drawing.Point(0, 0);
            this.panel_TopFlow.Name = "panel_TopFlow";
            this.panel_TopFlow.Size = new System.Drawing.Size(1134, 23);
            this.panel_TopFlow.TabIndex = 0;
            this.panel_TopFlow.Visible = false;
            // 
            // button_manage
            // 
            this.button_manage.AutoSize = true;
            this.button_manage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_manage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_manage.FlatAppearance.BorderSize = 0;
            this.button_manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage.Location = new System.Drawing.Point(0, 0);
            this.button_manage.Margin = new System.Windows.Forms.Padding(0);
            this.button_manage.Name = "button_manage";
            this.button_manage.Size = new System.Drawing.Size(59, 23);
            this.button_manage.TabIndex = 2;
            this.button_manage.Text = "&Manage";
            this.button_manage.UseVisualStyleBackColor = true;
            this.button_manage.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_edit
            // 
            this.button_edit.AutoSize = true;
            this.button_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Location = new System.Drawing.Point(59, 0);
            this.button_edit.Margin = new System.Windows.Forms.Padding(0);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(37, 23);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "&Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_sync
            // 
            this.button_sync.AutoSize = true;
            this.button_sync.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_sync.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_sync.FlatAppearance.BorderSize = 0;
            this.button_sync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sync.Location = new System.Drawing.Point(96, 0);
            this.button_sync.Margin = new System.Windows.Forms.Padding(0);
            this.button_sync.Name = "button_sync";
            this.button_sync.Size = new System.Drawing.Size(40, 23);
            this.button_sync.TabIndex = 4;
            this.button_sync.Text = "&Sync";
            this.button_sync.UseVisualStyleBackColor = true;
            this.button_sync.Click += new System.EventHandler(this.button_sync_Click);
            // 
            // panel_mod
            // 
            this.panel_mod.BackColor = System.Drawing.Color.Goldenrod;
            this.panel_mod.Controls.Add(this.lable_Status);
            this.panel_mod.Controls.Add(this.label1);
            this.panel_mod.Controls.Add(this.ico_Status);
            this.panel_mod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_mod.Location = new System.Drawing.Point(0, 597);
            this.panel_mod.Name = "panel_mod";
            this.panel_mod.Size = new System.Drawing.Size(1134, 24);
            this.panel_mod.TabIndex = 1;
            // 
            // lable_Status
            // 
            this.lable_Status.AutoSize = true;
            this.lable_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_Status.ForeColor = System.Drawing.Color.White;
            this.lable_Status.Location = new System.Drawing.Point(87, 5);
            this.lable_Status.Name = "lable_Status";
            this.lable_Status.Size = new System.Drawing.Size(63, 15);
            this.lable_Status.TabIndex = 3;
            this.lable_Status.Text = "Local Only";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sync Status:";
            // 
            // ico_Status
            // 
            this.ico_Status.Image = ((System.Drawing.Image)(resources.GetObject("ico_Status.Image")));
            this.ico_Status.Location = new System.Drawing.Point(6, 4);
            this.ico_Status.Name = "ico_Status";
            this.ico_Status.Size = new System.Drawing.Size(16, 16);
            this.ico_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ico_Status.TabIndex = 2;
            this.ico_Status.TabStop = false;
            // 
            // context_Manage
            // 
            this.context_Manage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomePageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newObjectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.context_Manage.Name = "context_Manage";
            this.context_Manage.Size = new System.Drawing.Size(154, 82);
            this.context_Manage.Text = "context_manage";
            // 
            // welcomePageToolStripMenuItem
            // 
            this.welcomePageToolStripMenuItem.Name = "welcomePageToolStripMenuItem";
            this.welcomePageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.welcomePageToolStripMenuItem.Text = "&Welcome Page";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // newObjectToolStripMenuItem
            // 
            this.newObjectToolStripMenuItem.Name = "newObjectToolStripMenuItem";
            this.newObjectToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newObjectToolStripMenuItem.Text = "&New Object";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editorView1
            // 
            this.editorView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.editorView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editorView1.Location = new System.Drawing.Point(0, 23);
            this.editorView1.Name = "editorView1";
            this.editorView1.Size = new System.Drawing.Size(1134, 574);
            this.editorView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1134, 621);
            this.Controls.Add(this.editorView1);
            this.Controls.Add(this.panel_mod);
            this.Controls.Add(this.panel_TopFlow);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container Manager";
            this.panel_TopFlow.ResumeLayout(false);
            this.panel_TopFlow.PerformLayout();
            this.panel_mod.ResumeLayout(false);
            this.panel_mod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ico_Status)).EndInit();
            this.context_Manage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_TopFlow;
        private System.Windows.Forms.Panel panel_mod;
        private System.Windows.Forms.Button button_manage;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_sync;
        private System.Windows.Forms.PictureBox ico_Status;
        private System.Windows.Forms.Label lable_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip context_Manage;
        private System.Windows.Forms.ToolStripMenuItem newObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private EditorView editorView1;
    }
}

