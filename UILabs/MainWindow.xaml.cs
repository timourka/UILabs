using System.ComponentModel;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UILabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            number.Text = "123456789";

            CommandBinding binding = new CommandBinding(CustomCommands.command);
            binding.Executed += NewCommand;
            this.CommandBindings.Add(binding);

            CommandBinding binding0 = new CommandBinding(CustomCommands.zero);
            binding0.Executed += ChangeText;
            this.CommandBindings.Add(binding0);
        }
        private void ChangeText(object sender, RoutedEventArgs e)
        {
            number.Text = "0";
        }
        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New command triggered with " + e.Source.ToString());
        }
    }
}