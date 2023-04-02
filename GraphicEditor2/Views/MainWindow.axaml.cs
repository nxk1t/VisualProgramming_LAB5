using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using GraphicEditor2.ViewModels;

namespace GraphicEditor2.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
    }
}