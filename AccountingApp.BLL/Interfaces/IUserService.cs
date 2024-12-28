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
        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="user">User to add.</param>
        /// <returns>The added user, or null.</returns>
        User? Create(UserForm user);

        /// <summary>
        /// Deletes an user from the database.
        /// </summary>
        /// <param name="id">Id to remove.</param>
        void Delete(int id);

        /// <summary>
        /// Updates an existing user in the repository.
        /// </summary>
        /// <param name="user">User with updated values.</param>
        User? Update(UserUpdateForm user);
    }
}
