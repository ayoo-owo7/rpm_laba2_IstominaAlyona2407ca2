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

namespace Rpm_Lab2
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModelStage2 _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new MainViewModelStage2();

            DataContext = _viewModel;

            ThemeComboBox.SelectedItem = _viewModel.SelectedTheme;
        }

        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (_viewModel != null)
            {
                _viewModel.CreateFigures();
            }
        }

    }
}