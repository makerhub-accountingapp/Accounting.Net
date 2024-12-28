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
using AccountingApp.DB.Entities;
using AccountingApp.Tools.Exceptions;

namespace AccountingApp.BLL.Services
{
    public class UserService(IUserRepository repo) : IUserService
    {
        public User? Create(UserForm user)
        {
            if (repo.Any(u => u.Email.Equals(user.Email, StringComparison.CurrentCultureIgnoreCase)))
            {
                throw new AlreadyExistException("The user already exists.");
            }

            User userToCreate = user.ToEntity();

            //TODO Hash password
            userToCreate.Password = "Password";

            return repo.Create(userToCreate);
        }

        public void Delete(int id)
        {
            User? userToDelete = repo.GetOne(u => u.Id == id);

            if (userToDelete is null)
            {
                throw new NotFoundException("The user was not found.");
            }

            //TODO Make trigger for Delete
            repo.Delete(userToDelete);
        }

        public User? Update(UserUpdateForm user)
        {
            User? foundUser = repo.GetOne(u => u.Email == user.OldEmail);
            if (foundUser is null)
            {
                throw new NotFoundException("The user was not found.");
            }
            
            if (user.NewEmail is not null) foundUser.Email = user.NewEmail;

            //TODO Hash password
            if (user.NewPassword is not null) foundUser.Password = user.NewPassword;

            return repo.Update(foundUser);
        }
    }
}
