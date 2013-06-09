using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingertzApp.Service.Contracts
{
    using FingertzApp.Model.Models;

    public interface IUserService
    {
        /// <summary>
        /// The get user by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        User GetUserById(Guid id);

        /// <summary>
        /// The save user.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        int SaveUser(User user);
    }
}
