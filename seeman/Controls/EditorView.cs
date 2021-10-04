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

namespace seeman
{
    public partial class EditorView : UserControl
    {
        public EditorView()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog() { Filter = "Container Theme (*.cthm)|*.cthm" })
            {
                save.DefaultExt = "*.cthm";
                save.AddExtension = true;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    ThemeManager.Save((Theme)propertyGrid1.SelectedObject, save.FileName);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog() { Filter = "Container Theme (*.cthm)|*.cthm" })
            {
                open.AddExtension = true;
                open.DefaultExt = "*.cthm";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    Program.Theme = ThemeManager.Load(open.FileName);
                    propertyGrid1.SelectedObject = Program.Theme;
                    ((Forms.ThemedForm)Parent).Theme = Program.Theme;
                }
            }
        }
    }
}
