using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloAvalonia.ViewModels;

namespace HelloAvalonia
{
    public class MainView : UserControl
    {
        public MainView()
        {
            this.InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
