using Anniverse.Models;
using System;
using System.Collections.Generic;

namespace Anniverse.ViewModels
{
    class AddNewEventViewModel : ViewModelBase
    {
        public string[] types = {
            "Birthday",
            "Deadline",
            "Anniversary",
            "Monthly",
            "Other"
        };

        public Dictionary<Event.Type, string> progressBarColours = new()
        {
            { Event.Type.Birthday, "#B388FF" },
            { Event.Type.Deadline, "#FF1744" },
            { Event.Type.Anniversary, "#2979FF" },
            { Event.Type.Monthly, "#00E676" },
            { Event.Type.Meeting, "#76FF03" },
            { Event.Type.Other, "#FF6D00" }
        };

        private string _EventName;
        public string EventName
        {
            get { return _EventName; }
            set
            {
                _EventName = value;
            }
        }

        private int _EventTypeIndex;
        public int EventTypeIndex
        {
            get { return _EventTypeIndex; }
            set
            {
                _EventTypeIndex = value;
            }
        }

        private DateTime _EventDate = DateTime.Now;
        public DateTimeOffset EventDate
        {
            get { return _EventDate; }
            set
            {
                _EventDate = value.Date;
            }
        }

        public void AddNewEvent()
        {
            Connector connector = new Connector();
            connector.ReadEvents();
            Event e = new Event();
            e.Id = (byte)(connector.events.Count + 1);
            e.Name = _EventName;
            e.EventType = (Event.Type)Enum.Parse(typeof(Event.Type), types[_EventTypeIndex]);
            e.Date = _EventDate;
            e.ProgressBarColour = progressBarColours[e.EventType];
            e.DateWhenAdded = DateTime.Today;
            connector.AddNewEvent(e);
            connector.WriteToFile();
        }
    }
}
