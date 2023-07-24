using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject.Models
{
    [PrimaryKey(nameof(Id))]
    public class ScheduledMessage
    {
        public int Id { get; set; }
        required public string Message { get; set; }
        required public string Title { get; set; }
        required public DateTime? Date { get; set; }
        required public IEnumerable<int> RecipientIds { get; set; }

    }
}
