using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace DerivedControls.TogglePopupMenu
{
    public class TogglePopupButton : RadioButton
    {
        public TogglePopupButton() : base()
        {
            this.Style = FindResource(typeof(ToggleButton)) as Style;
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            var before = IsChecked;
            base.OnMouseLeftButtonUp(e);
            if (before == true && IsChecked == true)
                IsChecked = false;
        }

        public Popup AssignedPopup
        {
            get { return (Popup)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(Popup), typeof(TogglePopupButton), 
                new PropertyMetadata(null, new PropertyChangedCallback(OnAssignedPopupChanged)));

        private static void OnAssignedPopupChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var btn = d as TogglePopupButton;
            Binding b = new Binding("IsOpen");
            b.Source = btn.AssignedPopup;
            b.Mode = BindingMode.TwoWay;
            BindingOperations.SetBinding(btn, IsCheckedProperty, b);

            btn.AssignedPopup.PlacementTarget = btn;
        }
    }
}
