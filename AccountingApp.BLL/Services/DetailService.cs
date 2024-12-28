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
            // Check if the detail already exists
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
            // Check if the detail exists
            Detail? detailToDelete = repo.GetOne(d => d.Id == id);

            if (detailToDelete is null)
            {
                throw new NotFoundException("The transaction detail was not found.");

            }

            repo.Delete(detailToDelete);
        }

        public IEnumerable<Detail> Get(DetailGetForm detail)
        {
            return repo.Get(d => 
                (detail.Id is null || d.Id == detail.Id) &&
                (detail.Name is null || d.Transaction.Name == detail.Name) &&
                (detail.CategoryId is null || d.CategoryId == detail.CategoryId) &&
                (detail.TransactionTypeId is null || d.TransactionTypeId == detail.TransactionTypeId) &&
                (detail.RepetitionId is null || d.Transaction.RepetitionId == detail.RepetitionId) &&
                (detail.StartDate is null || detail.EndDate is null || 
                (d.TransactionDate >= detail.StartDate && d.TransactionDate <= detail.EndDate))
            );
        }

        public Detail? GetById(int id)
        {
            return repo.GetOne(d => d.Id == id);
        }

        public Detail? Update(DetailUpdateForm detail)
        {
            // Check if the detail exists
            Detail? foundDetail = repo.GetOne(d => d.Id == detail.Id);

            if (foundDetail is null)
            {
                throw new NotFoundException("The transaction detail was not found");
            }

            return repo.Update(detail.ToEntity());
        }
    }
}
