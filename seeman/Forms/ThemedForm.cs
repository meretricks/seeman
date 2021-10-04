using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seeman.Themes;

namespace seeman.Forms
{
    public partial class ThemedForm : Form
    {
        private Theme _theme;
        public Theme Theme { get { return _theme; } set { _theme = value; OnThemeChanged.Invoke(value, EventArgs.Empty); } }
        public event EventHandler OnThemeChanged;

        public ThemedForm() : base() { InitializeComponent(); OnThemeChanged += ThemedForm_OnThemeChanged; Theme = new DarkTheme(); }

        public ThemedForm(Theme theme) : base() { InitializeComponent(); OnThemeChanged += ThemedForm_OnThemeChanged; Theme = theme; }

        private void ThemedForm_OnThemeChanged(object sender, EventArgs e)
        {
            SetTheme(this);
        }

        private void SetTheme(Control c)
        {
            c.BackColor = Theme.Form;
            c.ForeColor = Theme.ForeColor;
            c.Font = Theme.Font;

            if (c.HasChildren)
            {
                foreach (Control con in c.Controls)
                    SetTheme(con);
            }

            if (c.GetType() == typeof(Panel) && c.Name == "panel_mod")
                ((Panel)c).BackColor = Program.NetworkStatus == NetStatus.Local ? Theme.StatusLocal : Theme.StatusOnline;

            if (c.GetType() == typeof(Button)) {
                ((Button)c).FlatAppearance.BorderColor = Theme.ButtonBorder;
                ((Button)c).BackColor = Theme.Button;
            }

            if (c.GetType() == typeof(LinkLabel))
                ((LinkLabel)c).ActiveLinkColor = Theme.HyperLink;
        }
    }
}
