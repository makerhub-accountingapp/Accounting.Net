using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.BLL.Forms;
using AccountingApp.DB.Entities;

namespace AccountingApp.BLL.Mappers
{
    public static class UserMapper
    {
        public static User ToEntity(this UserForm u)
        {
            return new User
            {
                Email = u.Email,
            };
        }
    }
}
