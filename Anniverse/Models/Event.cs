using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anniverse.Models
{
    public class Event
    {
        public enum Type
        {
            Birthday,
            Deadline,
            Anniversary,
            Monthly,
            Meeting,
            Other
        }

        public string? ProgressBarColour { get; set; }
        public string? DaysLeftText { get; set; }
        public byte Id { get; set; }
        public Type EventType { get; set; }
        public String? Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateWhenAdded { get; set; }
        public int TimeLeft { get; set; }
        public int DifferenceBetweenDates { get; set; }
    }
}
