using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Anniverse.Views
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
