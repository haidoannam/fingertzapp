using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingertzApp.DAL.Implementations
{
    using FingertzApp.DAL.Contracts;
    using FingertzApp.Model;

    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private FingertzAppContext dataContext;
        public FingertzAppContext Get()
        {
            return dataContext ?? (dataContext = new FingertzAppContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
