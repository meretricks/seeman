using System;
using System.ComponentModel;
using System.Drawing;
using seeman.Interfaces;

namespace seeman.Themes
{
    public class Theme
    {
        [Category("Controls")]
        public Color Form { get; set; }
        [Category("Controls")]
        public Color Button { get; set; }
        [Category("Controls")]
        public Color ButtonBorder { get; set; }
        [Category("Controls")]
        public Color FormBorder { get; set; }
        [Category("Controls")]
        public Color TabButton { get; set; }
        [Category("Controls")]
        public Color ErrorCritical { get; set; }
        [Category("Controls")]
        public Color StatusLocal { get; set; }
        [Category("Controls")]
        public Color StatusOnline { get; set; }

        [Category("Text")]
        public Color ForeColor { get; set; }
        [Category("Text")]
        public Color HyperLink { get; set; }
        [Category("Text")]
        public Font Font { get; set; }

        [Category("Attributes")]
        public virtual string Name { get; set; }
        [Category("Attributes")]
        public virtual string Description { get; set; }
    }

    public static class ThemeManager
    {
        public static bool Save(Theme theme, string fileName)
        {
            try
            {
                var data = Newtonsoft.Json.JsonConvert.SerializeObject(theme, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(fileName, data);
                return true;
            }catch (Exception ex)
            {
                TextDialog.ShowMessage("A fatal error occured while saving theme.", ex.Message);
                return false;
            }
        }

        public static Theme Load(string fileName)
        {
            try
            {
                string data = System.IO.File.ReadAllText(fileName);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Theme>(data);
            }catch (Exception ex)
            {
                TextDialog.ShowMessage("Error Loading Theme - 0x0002", ex.Message);
                return null;
            }
        }
    }
}
