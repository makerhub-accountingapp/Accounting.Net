using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.BLL.Forms;
using AccountingApp.DB.Models;

namespace AccountingApp.BLL.Interfaces
{
    public interface IUserService
    {
        User? CreateAsync(UserForm user);
        void UpdatePassword(UserForm user);
    }
}
