using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace seeman
{
    public partial class MainForm : Forms.ThemedForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context_Manage.Show(PointToScreen(new Point(button_manage.Location.X + 5, button_manage.Location.Y + button_manage.Height)));
        }

        private void btn_NewContainer_Welcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button_edit_Click(object sender, EventArgs e)
        {

        }

        private void button_sync_Click(object sender, EventArgs e)
        {

        }

        private void panel_manage_tab_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DimGray, new Point(0, 1), new Point(Width, 1));
        }
    }
}
