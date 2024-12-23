using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.DB.Models
{
    public class Repetition
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime SetDate { get; set; }
        public DateTime NextDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TransactionId { get; set; }
    }
}
