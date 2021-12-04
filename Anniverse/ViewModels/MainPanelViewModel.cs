using Anniverse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anniverse.ViewModels
{
    class MainPanelViewModel : ViewModelBase
    {
        public string CurrentDate => DateTime.Today.ToString("dd.MM.yyyy");

        public ObservableCollection<Event> Events => new Connector().GetEvents();
    }
}
