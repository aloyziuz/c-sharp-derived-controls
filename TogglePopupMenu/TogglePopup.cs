using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace DerivedControls.TogglePopupMenu
{
    public class TogglePopup : Popup
    {
        public TogglePopup() : base()
        {
            IsOpen = false;
            PopupAnimation = PopupAnimation.Slide;
        }
    }
}