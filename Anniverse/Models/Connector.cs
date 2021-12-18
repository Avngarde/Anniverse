using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Anniverse.Models
{
    public class Connector
    {
        public ObservableCollection<Event> events;

        public Connector()
        {
            events = new ObservableCollection<Event>();
            if (!CheckIfEventsFileExists())
            {
                CreateEventsFile();
            }
        }

        private bool CheckIfEventsFileExists()
        {
            return File.Exists(@"./events/events.json");
        }

        private void CreateEventsFile()
        {
            Directory.CreateDirectory("./events/");
            WriteToFile();
        }

        public void ReadEvents()
        {
            string jsonString = File.ReadAllText(@"./events/events.json");
            this.events = JsonSerializer.Deserialize<ObservableCollection<Event>>(jsonString);
            foreach(Event e in this.events)
            {
                e.TimeLeft = (int)(e.Date - DateTime.Today).TotalDays;
            }
        }

        public ObservableCollection<Event> GetEvents()
        {
            ReadEvents();
            return events;
        }

        public void AddNewEvent(Event e)
        {
            this.events.Add(e);
        }

        public void WriteToFile()
        {
            string serializedEvents = JsonSerializer.Serialize(this.events);
            File.WriteAllText(@"./events/events.json", serializedEvents);
        }

        private void UpdateId()
        {
            int length = this.events.Count;
            for (int idx = 0; idx < length; idx++)
            {
                this.events[idx].Id = (byte)idx;
            }

            WriteToFile();
        }

        public void DeleteEvent(int id)
        {
            foreach(Event e in this.events)
            {
                if (e.Id == id)
                {
                    this.events.Remove(e);
                    UpdateId();
                    return;
                }
            }
        }
    }
}
