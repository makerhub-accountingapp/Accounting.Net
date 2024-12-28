using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.BLL.Forms;
using AccountingApp.DB.Entities;

namespace AccountingApp.BLL.Interfaces
{
    public interface IDetailService
    {
        /// <summary>
        /// Adds a new detail to the database.
        /// </summary>
        /// <param name="detail">Detail to add.</param>
        /// <returns>The added detail, or null.</returns>
        Detail? Create(DetailForm detail);

        /// <summary>
        /// Deletes an detail from the database.
        /// </summary>
        /// <param name="id">Id to remove.</param>
        void Delete(int id);

        /// <summary>
        /// Retrieves details that match the given condition.
        /// </summary>
        /// <params>Condition to filter details (optional).</param>
        /// <returns>A collection of matching details.</returns>
        IEnumerable<Detail> Get(DetailGetForm detail);

        /// <summary>
        /// Retrieves a single detail that matches the condition.
        /// </summary>
        /// <param name="id">Id to test the detail.</param>
        /// <returns>The matching detail, or null.</returns>
        Detail? GetById(int id);

        /// <summary>
        /// Updates an existing detail in the repository.
        /// </summary>
        /// <param name="detail">Detail with updated values.</param>
        /// <returns>The updated detail.</returns>
        Detail? Update(DetailUpdateForm detail);
    }
}
