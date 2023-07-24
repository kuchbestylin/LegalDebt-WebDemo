using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject.Models
{
    [PrimaryKey(nameof(Id))]
    internal class Collection
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<KeyValuePair<string, string>>? selectedTexts { get; set; }
        public List<KeyValuePair<string, string>>? selectedDocs { get; set; }

    }
}
