
namespace seeman
{
    partial class EditorSubItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorSubItem));
            this.panel_handle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_searchbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_controlbox = new System.Windows.Forms.Panel();
            this.btn_hide = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Panel();
            this.btn_pin = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_base = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_handle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_controlbox.SuspendLayout();
            this.panel_base.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_handle
            // 
            this.panel_handle.BackColor = System.Drawing.Color.Gray;
            this.panel_handle.Controls.Add(this.panel1);
            this.panel_handle.Controls.Add(this.panel_controlbox);
            this.panel_handle.Controls.Add(this.label_name);
            this.panel_handle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_handle.Location = new System.Drawing.Point(0, 0);
            this.panel_handle.Name = "panel_handle";
            this.panel_handle.Size = new System.Drawing.Size(231, 42);
            this.panel_handle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.text_searchbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 19);
            this.panel1.TabIndex = 3;
            // 
            // text_searchbox
            // 
            this.text_searchbox.BackColor = System.Drawing.Color.Gray;
            this.text_searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_searchbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_searchbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchbox.ForeColor = System.Drawing.Color.LightGray;
            this.text_searchbox.Location = new System.Drawing.Point(0, 0);
            this.text_searchbox.Name = "text_searchbox";
            this.text_searchbox.Size = new System.Drawing.Size(209, 16);
            this.text_searchbox.TabIndex = 0;
            this.text_searchbox.Text = "Search Control";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel_controlbox
            // 
            this.panel_controlbox.Controls.Add(this.btn_hide);
            this.panel_controlbox.Controls.Add(this.btn_close);
            this.panel_controlbox.Controls.Add(this.btn_pin);
            this.panel_controlbox.Location = new System.Drawing.Point(169, 0);
            this.panel_controlbox.Name = "panel_controlbox";
            this.panel_controlbox.Size = new System.Drawing.Size(62, 24);
            this.panel_controlbox.TabIndex = 2;
            this.panel_controlbox.Visible = false;
            // 
            // btn_hide
            // 
            this.btn_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_hide.Location = new System.Drawing.Point(5, 4);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(16, 16);
            this.btn_hide.TabIndex = 2;
            this.btn_hide.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_hide.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_close.Location = new System.Drawing.Point(42, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.TabIndex = 1;
            this.btn_close.Click += new System.EventHandler(this.btn_close_MouseClick);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // btn_pin
            // 
            this.btn_pin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_pin.Location = new System.Drawing.Point(24, 4);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(16, 16);
            this.btn_pin.TabIndex = 2;
            this.btn_pin.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_pin.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 4);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(89, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Editor_SubItem";
            // 
            // panel_base
            // 
            this.panel_base.Controls.Add(this.button1);
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 42);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(231, 431);
            this.panel_base.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditorSubItem
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 473);
            this.Controls.Add(this.panel_base);
            this.Controls.Add(this.panel_handle);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditorSubItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EditorSubItem";
            this.panel_handle.ResumeLayout(false);
            this.panel_handle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_controlbox.ResumeLayout(false);
            this.panel_base.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_handle;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel btn_hide;
        private System.Windows.Forms.Panel btn_pin;
        private System.Windows.Forms.Panel btn_close;
        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.Panel panel_controlbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_searchbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}