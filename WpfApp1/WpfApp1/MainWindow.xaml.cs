using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfSplitDropdown
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DropDownButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.ContextMenu.IsOpen = true;
        }

        private void SplitButton_Toggle_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = sender as ToggleButton;
            toggleButton.ContextMenu.IsOpen = true;
        }

        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Main Action Executed!");
        }
    }
}
