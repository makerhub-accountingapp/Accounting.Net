using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.BLL.Forms;
using AccountingApp.BLL.Interfaces;
using AccountingApp.BLL.Mappers;
using AccountingApp.DAL.Interfaces;
using AccountingApp.DB.Entities;
using AccountingApp.Tools.Exceptions;

namespace AccountingApp.BLL.Services
{
    public class DetailService(IDetailRepository repo) : IDetailService
    {
        public Detail? Create(DetailForm detail)
        {
            if (repo.Any(d => 
                d.TransactionId == detail.TransactionId &&
                d.TransactionDate == detail.TransactionDate))
            {
                throw new AlreadyExistException("The transaction detail already exists.");
            }

            return repo.Create(detail.ToEntity());
        }

        public void Delete(int id)
        {
            Detail? detailToDelete = repo.GetOne(d => d.Id == id);

            if (detailToDelete is null)
            {
                throw new NotFoundException("The transaction detail was not found.");

            }

            repo.Delete(detailToDelete);
        }

        public IEnumerable<Detail> Get(int? id, string? name, string? category, string? transactionType, string? repetition, DateTime? startDate, DateTime? endDate)
        {
            return repo.Get(d => 
                (id is null || d.Id == id) &&
                (category is null || d.Category.Name == category) &&
                (name is null || d.TransactionType.Name == transactionType) &&
                (repetition is null || d.Transaction.Repetition.Name == repetition) &&
                (startDate is null || endDate is null || d.TransactionDate >= startDate && d.TransactionDate <= endDate));
        }

        public Detail? GetById(int id)
        {
            return repo.GetOne(d => d.Id == id);
        }

        public Detail? Update(Detail detail)
        {
            Detail? foundDetail = repo.GetOne(d => d.Id == detail.Id);

            if (foundDetail is null)
            {
                throw new NotFoundException("The transaction detail was not found");
            }

            return repo.Update(detail);
        }
    }
}
