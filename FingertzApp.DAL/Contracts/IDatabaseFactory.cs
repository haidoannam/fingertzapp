using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingertzApp.DAL.Contracts
{
    using FingertzApp.Model;

    public interface IDatabaseFactory : IDisposable
    {
        FingertzAppContext Get();
    }
}
