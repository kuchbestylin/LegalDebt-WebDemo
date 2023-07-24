using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharedProject.Models
{
    [PrimaryKey(nameof(Id))]
    internal class Conversation
    {
        public int Id { get; set; }
        public List<ConversationMessage>? Messages { get; set; }
        [ForeignKey("Collection")]
        public int CollectionId { get; set; }
        public Collection? Collection { get; set; }
    }
}
