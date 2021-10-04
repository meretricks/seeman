using System;
using System.Drawing;

namespace seeman.Interfaces
{
    public interface ITheme
    {
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
        string Name { get; }
    }
}
