using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anniverse.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;
        public MainWindowViewModel()
        {
            Content = new MainPanelViewModel();
        }
        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }
        public void OpenAddNewEventView()
        {
            Content = new AddNewEventViewModel();
        }
    }
    
}
