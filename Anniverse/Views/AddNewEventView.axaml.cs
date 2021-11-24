using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Anniverse.Views
{
    public partial class AddNewEventView : UserControl
    {
        public AddNewEventView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
