using System;
using System.Collections.Generic;
using System.Text;

namespace KC.SPARTA.Interface.Service
{
    public interface IAppUser
    {
        string Region { get; set; }
        string Name { get; set; }
        string Id { get; set; }
        string Language { get; set; }
        string PreferedLangauge { get; set; }
        string DefaultLanguage { get; set; }

    }
}
