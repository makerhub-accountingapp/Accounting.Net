using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.BLL.Forms;
using AccountingApp.DB.Entities;

namespace AccountingApp.BLL.Interfaces
{
    public interface IUserService
    {
        User? Create(UserForm user);
        void Delete(UserForm user);
        void Update(UserUpdateForm user);
    }
}
