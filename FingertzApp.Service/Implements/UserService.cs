using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingertzApp.Service.Implements
{
    using FingertzApp.DAL.Contracts;
    using FingertzApp.Model.Models;
    using FingertzApp.Repository.Contracts;
    using FingertzApp.Service.Contracts;

    public class UserService : IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _userRepository;

        public UserService(
            IUnitOfWork unitOfWork, 
            IUserRepository userRepository)
        {
            this._unitOfWork = unitOfWork;
            this._userRepository = userRepository;
        }

        public User GetUserById(Guid id)
        {
            var user = this._userRepository.GetAll().FirstOrDefault();
            return user;
        }

        /// <summary>
        /// The save user.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        public int SaveUser(User user)
        {
            this._userRepository.Add(user);
            this._unitOfWork.Commit();

            return user.UserId;
        }
    }
}
