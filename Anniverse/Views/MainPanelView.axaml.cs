using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Anniverse.Views
{
    public partial class MainPanelView : UserControl
    {
        public MainPanelView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
