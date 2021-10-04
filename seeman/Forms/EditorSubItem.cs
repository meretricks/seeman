using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seeman
{
    public partial class EditorSubItem : Form
    {
        #region properties

        public Boolean ShowHandle { get; set; }

        #endregion

        public EditorSubItem()
        {
            InitializeComponent();
            ShowHandle = true;
        }

        public EditorSubItem(bool handle) : base()
        {
            //InitializeComponent();
            ShowHandle = handle;
        }

        private void btn_close_MouseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.White;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.Silver;
        }
    }
}
