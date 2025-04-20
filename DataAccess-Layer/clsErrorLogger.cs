using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayar_EC_
{
    public class clsErrorLogger
    {
        private Action<string, Exception> _logAction;

        public clsErrorLogger(Action<string, Exception> logAction)
        {
            _logAction = logAction;
        }

        public void LogError(string errorType, Exception ex)
        {
            _logAction?.Invoke(errorType, ex);
        }
    }
}
