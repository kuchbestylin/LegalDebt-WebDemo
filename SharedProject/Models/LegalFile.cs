using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharedProject.Models
{
    class LegalFile
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string FileID { get; set; }
        [ForeignKey(nameof(Client))]
        public int ClientID { get; set; }
        public Client? Client { get; set; }
        [ForeignKey(nameof(Company))]
        public int CompanyID { get; set; }
        public Company? Company { get; set; }
        public int Balance { get; set; }
    }
}
