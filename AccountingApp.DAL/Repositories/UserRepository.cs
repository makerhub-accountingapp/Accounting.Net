using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DAL.Interfaces;
using AccountingApp.DB.Contexts;
using AccountingApp.DB.Models;
using AccountingApp.Tools.Templates;

namespace AccountingApp.DAL.Repositories
{
    public class UserRepository(AccountingContext context) : Repository<User>(context), IUserRepository
    {
    }
}
