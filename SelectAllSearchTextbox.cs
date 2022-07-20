using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace DerivedControls
{
    public class SelectAllSearchTextbox : ClickSelectAllTextBox
    {
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if(e.Key == Key.Enter)
            {
                MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                this.Focus();
            }
        }
    }
}
