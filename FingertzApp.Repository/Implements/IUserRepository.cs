// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The user repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FingertzApp.Repository.Implements
{
    using FingertzApp.DAL.Contracts;
    using FingertzApp.DAL.Implementations;
    using FingertzApp.Model;
    using FingertzApp.Model.Models;
    using FingertzApp.Repository.Contracts;

    /// <summary>
    /// The user repository.
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        /// <summary>
        /// The data context.
        /// </summary>
        private FingertzAppContext dataContext;

        /// <summary>
        /// Gets the database factory.
        /// </summary>
        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="databaseFactory">
        /// The database factory.
        /// </param>
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        /// <summary>
        /// Gets the data context.
        /// </summary>
        protected FingertzAppContext DataContext
        {
            get { return this.dataContext ?? (this.dataContext = this.DatabaseFactory.Get()); }
        }

    }
}
