
using KC.SPARTA.Logging;
using System;
using System.Text;

namespace KC.SPARTA.SpartaException
{
    public class ExceptionHandler
    {

        private static ExceptionHandler _ex = null;

        /// <summary>
        /// Gets the instance of the Exception Class
        /// </summary>
        /// <returns></returns>
        public static ExceptionHandler GetInstance()
        {
            if (_ex == null)
            {
                _ex = new ExceptionHandler();
            }

            return _ex;
        }

        /// <summary>
        /// Handle the exception and write into log
        /// </summary>
        /// <param name="ex">Exception</param>
        public void Handle(Exception ex)
        {
          //  ExceptionPolicy.HandleException(ex, "SpartaExceptionPolicy");
            Log.GetInstance().WriteError(ex);
        }

        public void HandleWarning(Exception ex)
        {
           // ExceptionPolicy.HandleException(ex, "SpartaExceptionPolicy");
            Log.GetInstance().WriteWarning(GetInnerExceptionMessage(ex));
        }

        /// <summary>
        /// Gets all the inner exceptions message of the exception
        /// </summary>
        /// <param name="ex">Exception</param>
        /// <returns>String</returns>
        private String GetInnerExceptionMessage(Exception ex)
        {
            StringBuilder message = new StringBuilder();

            do
            {
                message.AppendLine(ex.Message);
                message.AppendLine(ex.StackTrace);
                message.AppendLine();
                ex = ex.InnerException;
            } while (ex != null);

            return message.ToString();
        }
    }
}