using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DerivedControls.TogglePopupMenu
{
    /// <summary>
    /// Interaction logic for TogglePopupButton.xaml
    /// </summary>
    public partial class TogglePopupButton : UserControl
    {
        public TogglePopupButton()
        {
            InitializeComponent();
        }

        public TogglePopup AssignedPopup
        {
            get { return (TogglePopup)GetValue(AssignedPopupProperty); }
            set { SetValue(AssignedPopupProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AssignedPopup.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AssignedPopupProperty =
            DependencyProperty.Register("AssignedPopup", typeof(TogglePopup), typeof(TogglePopupButton), 
                new PropertyMetadata(null, new PropertyChangedCallback(OnPopupChanged)));

        private static void OnPopupChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var btn = d as TogglePopupButton;
            btn.AssignedPopup.PropertyChanged += btn.AssignedPopup_PropertyChanged;
        }

        public void AssignedPopup_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "IsOpen":
                    this.ische
                    break;
            }
        }
    }
}
