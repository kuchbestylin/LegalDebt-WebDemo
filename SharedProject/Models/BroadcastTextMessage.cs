using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject.Models
{
    internal class BroadcastTextMessage
    {
        public int Id { get; set; }
        public required string Message { get; set; }
        public required IEnumerable<int> CellNumbers { get; set; }
        public DateTime date { get; set; }
    }
}
