namespace FingertzApp.DAL.Implementations
{
    using FingertzApp.DAL.Contracts;
    using FingertzApp.Model;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private FingertzAppContext dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected FingertzAppContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            dataContext.Commit();
        }
    }
}
