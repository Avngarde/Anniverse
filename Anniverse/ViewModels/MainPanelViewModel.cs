using Anniverse.Models;
using Anniverse.Views;
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
        private Connector connector = new Connector();

        public string CurrentDate => DateTime.Today.ToString("dd.MM.yyyy");

        public ObservableCollection<Event> Events => connector.GetEvents();

        public void OnClickCommand(int id)
        {
            connector.DeleteEvent(id);
        }
    }
}
