﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DB.Entities;

namespace AccountingApp.BLL.Forms
{
    public class DetailForm
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public string Note { get; set; } = string.Empty;

        [Required]
        public int TransactionId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int TransactionTypeId { get; set; }
    }

    public class DetailGetForm
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? TransactionType { get; set; }
        public string? Repetition { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class DetailUpdateForm
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public string Note { get; set; } = string.Empty;

        [Required]
        public int TransactionId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int TransactionTypeId { get; set; }
    }
}
