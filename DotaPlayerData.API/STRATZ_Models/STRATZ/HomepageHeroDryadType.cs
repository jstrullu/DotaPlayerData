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
    public partial class HomepageHeroDryadType
    {
        public short? MainHeroId { get; set; }
        public short? ComparisonHeroId { get; set; }
        public RankBracketBasicEnum? BracketBasicIds { get; set; }
        public long? MatchCount { get; set; }
        public long? WinCount { get; set; }
        public decimal? Synergy { get; set; }
        public decimal? WinsAverage { get; set; }
        public decimal? ComparisonHeroBaseWinRate { get; set; }
    }
}