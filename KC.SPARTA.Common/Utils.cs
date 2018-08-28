using System.Web;
using System.Web.Configuration;

namespace KC.SPARTA.Common
{
    /// <summary>
    /// Methods used accross layers
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Method to get the Application settings from Web.Config
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string GetAppSettings(string Key)
        {
            return WebConfigurationManager.AppSettings[Key];
        }

        /// <summary>
        /// Method to get the connection string from Web.Config.
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static string GetConnectionString(string Key)
        {
            return WebConfigurationManager.ConnectionStrings[Key].ConnectionString;
        }

        /// <summary>
        /// Creates new cookie if it does not exist else updated the existing cookie
        /// The cookies are expired when session expires or on application close
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        public static void CreateCookie(string Name, string Value)
        {
            HttpCookie cultureCookie = HttpContext.Current.Request.Cookies[Name];
            if (cultureCookie == null)
                HttpContext.Current.Response.Cookies.Add(new HttpCookie(Name, Value));
            else
            {
                cultureCookie.Value = Value;
                HttpContext.Current.Response.Cookies.Set(cultureCookie);
            }
        }
        /// <summary>
        /// Provide the Date time in string format based on the country code 
        /// </summary>
        /// <param name="datetime">Input date values </param>
        /// <param name="userCulture">Logged in user country code</param>
        /// <param name="isShortendDate">boolean of if its needs shortend date</param>
        /// <returns>Date in string format based on culture info </returns>
        
        

    }
}