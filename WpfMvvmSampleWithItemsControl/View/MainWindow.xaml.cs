using System.Windows;
using WpfMvvmSampleWithItemsControl.ViewModel;

namespace WpfMvvmSampleWithItemsControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
