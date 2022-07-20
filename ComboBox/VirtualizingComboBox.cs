using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace DerivedControls
{
    public class VirtualizingComboBox : ComboBox
    {
        public VirtualizingComboBox(): base()
        {
            ItemsPanel = new ItemsPanelTemplate();
            var stackPanelTemplate = new FrameworkElementFactory(typeof(VirtualizingStackPanel));
            ItemsPanel.VisualTree = stackPanelTemplate;
        }
    }
}
