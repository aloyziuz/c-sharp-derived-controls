using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DerivedControls
{
    public class AutoDropVirtualizingComboBox : AutoDropComboBox
    {
        public AutoDropVirtualizingComboBox(): base()
        {
            ItemsPanel = new ItemsPanelTemplate();
            var stackPanelTemplate = new FrameworkElementFactory(typeof(VirtualizingStackPanel));
            ItemsPanel.VisualTree = stackPanelTemplate;
        }
    }
}
