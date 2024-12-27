using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.DB.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;
        public int RepetitionId { get; set; }
        public Repetition Repetition { get; set; } = null!;
        public List<Detail> Details { get; set; } = new List<Detail>();
    }
}
