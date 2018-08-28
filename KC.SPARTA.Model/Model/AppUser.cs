using System;
using KC.SPARTA.Interface.Service;

namespace KC.SPARTA.Model.Model
{
    public class AppUser : IAppUser
    {

        /// <summary>
        /// User Default or last used Region 
        /// </summary>
        public string Region { get; set; }

        public string Name { get; set; }

        public string Id { get; set; }

        public string Language { get; set; }

        public string PreferedLangauge { get; set; }

        public string DefaultLanguage { get; set; }

      
    }
}
