using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingertzApp.Common.Command
{
    public interface ICommandResult
    {
        bool Success { get; }
    }
}
