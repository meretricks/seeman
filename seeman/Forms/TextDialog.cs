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
    public partial class TextDialog : Forms.ThemedForm
    {
        public TextDialog()
        {
            InitializeComponent();
        }

        public TextDialog(Themes.Theme theme) : base(theme) { }

        public static DialogResult ShowMessage(string title, string message)
        {
            if (Properties.Settings.Default.SuppressErrors)
                return DialogResult.None;

            using (var d = new TextDialog(Program.Theme))
            {
                d.txtTitle.Text = title;
                d.txtError.Text = message;

                return d.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtError.Text);
        }
    }

}
