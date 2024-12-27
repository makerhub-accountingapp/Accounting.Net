using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AccountingApp.BLL.Forms;
using AccountingApp.BLL.Interfaces;
using AccountingApp.BLL.Mappers;
using AccountingApp.DAL.Interfaces;
using AccountingApp.DB.Models;
using AccountingApp.Tools.Exceptions;

namespace AccountingApp.BLL.Services
{
    public class UserService(IUserRepository repo) : IUserService
    {
        public User? CreateAsync(UserForm user)
        {
            if (repo.Any(u => u.Email.Equals(user.Email, StringComparison.CurrentCultureIgnoreCase)))
            {
                throw new AlreadyExistException("The user already exists.");
            }

            User userToAdd = user.ToEntity();
            //TODO Hash password
            userToAdd.Password = "Password";

            return repo.Create(userToAdd);
        }

        public void UpdatePassword(UserForm user)
        {
            User? foundUser = repo.GetOne(u => u.Email == user.Email);
            if (foundUser is null)
            {
                throw new NotFoundException("The user was not found.");
            }
            //TODO Hash password
            foundUser.Password = user.Password;

            repo.Update(foundUser);
        }
    }
}
