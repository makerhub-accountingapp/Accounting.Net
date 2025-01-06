using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DAL.Interfaces;
using AccountingApp.DB.Contexts;
using AccountingApp.DB.Entities;
using AccountingApp.Tools.Templates;
using Microsoft.EntityFrameworkCore;

namespace AccountingApp.DAL.Repositories
{
    public class DetailRepository(AccountingContext context) : Repository<Detail>(context), IDetailRepository
    {
        public override IEnumerable<Detail> Get(Func<Detail, bool>? predicate)
        {
            if (predicate is not null) 
                return Entities.Include(d => d.Transaction).Where(predicate);
            else 
                return Entities.Include(d => d.Transaction);
        }
        public override Detail? GetOne(Func<Detail, bool> predicate)
        {
            return Entities.Include(d => d.Transaction).FirstOrDefault(predicate);
        }
    }
}
