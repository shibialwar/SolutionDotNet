using System;
using NLog;

namespace KC.SPARTA.Logging
{
    public class Log
    {
        private static Logger _log  = null;
        private static Log _thislog = null;

        private Log()
        {
          
        }

        /// <summary>
        /// Get the instance of the Log
        /// </summary>
        /// <returns></returns>
        public static Log GetInstance()
        {
            if (_thislog == null)
            {
                //Get instance
                _thislog = new Log();
                _log = LogManager.GetCurrentClassLogger(); 

            }

            return _thislog;
        }

        /// <summary>
        /// Writes the Message to the log
        /// </summary>
        /// <param name="Message">String</param>
        public void WriteInfo(String Message)
        {
            _log.Info(Message);
        }

  
        /// <summary>
        /// Writes Error Log
        /// </summary>
        /// <param name="Message">String</param>
        public void WriteError(String Message)
        {
            _log.Error(Message);
        }

        public void WriteError(Exception ex)
        {

            _log.Error(ex);
        }

        public void WriteWarning(String Message)
        {
            _log.Warn(Message);
        }

        /// <summary>
        /// To track the start end of a method or process
        /// </summary>
        /// <param name="progress"></param>
        public  void StartProcessing(string progress)
        {
            _log.Info(progress + " Started !");
        }

        /// <summary>
        /// To track the start end of a method or process
        /// </summary>
        /// <param name="progress"></param>
        public  void EndProcessing(string progress)
        {
            _log.Info(progress + " Completed successfully !");
        }
    }
}
