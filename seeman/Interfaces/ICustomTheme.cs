using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seeman.Interfaces
{
    interface ICustomTheme
    {
        string Name { get; set; }
        #region color
        Color ColorBack { get; }
        Color ColorButton { get; }
        Color ColorBorder { get; }
        Color ColorTab { get; }
        Color ColorText { get; }
        Color ColorHyper { get; }
        Color ColorCritical { get; }

        Color ColorStatusLocalOnly { get; }
        Color ColorStatusOnline { get; }
        #endregion

        ITheme GetTheme();
    }
}
