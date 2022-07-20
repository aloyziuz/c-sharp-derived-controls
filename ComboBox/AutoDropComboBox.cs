using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DerivedControls
{
    /// <summary>
    /// combo box which will auto open when getting keyboard focus and automatically move focus to the next object
    /// </summary>
    public class AutoDropComboBox : ComboBox
    {
        protected bool returnedFocus = false;

        public AutoDropComboBox() : base()
        {
        }

        protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnGotKeyboardFocus(e);

            //check that the event is caused by the auto drop combo box and not from the item
            if (e.OriginalSource is AutoDropComboBox)
            {
                //if combobox receive focus for the first time, automatically open the drop down
                if (!returnedFocus)
                    IsDropDownOpen = true;
            }
        }

        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnLostKeyboardFocus(e);

            //check that the event is caused by the auto drop combo box and not from the item
            if (e.OriginalSource is AutoDropComboBox)
            {
                var cb = e.OriginalSource as ComboBox;
                returnedFocus = cb.IsDropDownOpen;
            }
        }
    }
}
