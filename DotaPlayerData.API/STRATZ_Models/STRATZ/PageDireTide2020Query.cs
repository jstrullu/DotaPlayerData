// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class PageDireTide2020Query
    {
        public DireTide2020CustomGameMatchType Match { get; set; }
        public IList<DireTide2020CustomGameMatchType> Matches { get; set; }
        public IList<DireTide2020CustomGameHeroWinDayType> WinHour { get; set; }
    }
}