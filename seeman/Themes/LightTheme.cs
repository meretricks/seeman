using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seeman.Interfaces;

namespace seeman.Themes
{
    class LightTheme : Theme
    {
        public new Color ColorBack            => Color.FromArgb(35, 35, 40);
        public new Color ColorButton          => ColorBack;
        public new Color ColorBorder          => Color.FromArgb(55, 45, 50);
        public new Color ColorTab             => ColorButton;
        public new Color ColorText            => Color.White;
        public new Color ColorHyper           => Color.FromArgb(140, 240, 150);
        public new Color ColorCritical        => Color.Red;
        public new Color ColorStatusLocalOnly => Color.DodgerBlue;
        public new Color ColorStatusOnline    => Color.LawnGreen;

        public Theme GetTheme()
        {
            return this;
        }
    }
}
