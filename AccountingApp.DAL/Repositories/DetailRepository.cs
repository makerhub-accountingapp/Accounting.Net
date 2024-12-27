using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DAL.Interfaces;
using AccountingApp.DB.Contexts;
using AccountingApp.DB.Entities;
using AccountingApp.Tools.Templates;

namespace AccountingApp.DAL.Repositories
{
    public class DetailRepository(AccountingContext context) : Repository<Detail>(context), IDetailRepository
    {
    }
}
