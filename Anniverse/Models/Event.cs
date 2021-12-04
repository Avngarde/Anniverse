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

        public String ProgressBarColour { get; set; }

        public byte Id { get; set; }
        public Type EventType { get; set; }
        public String? Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateWhenAdded { get; set; }
    }
}
