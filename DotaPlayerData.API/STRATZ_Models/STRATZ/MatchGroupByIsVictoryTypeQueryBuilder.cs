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
    public partial class MatchGroupByIsVictoryTypeQueryBuilder : GraphQlQueryBuilder<MatchGroupByIsVictoryTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "isVictory" },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "winCount" },
                new FieldMetadata { Name = "avgImp" },
                new FieldMetadata { Name = "avgGoldPerMinute" },
                new FieldMetadata { Name = "avgExperiencePerMinute" },
                new FieldMetadata { Name = "avgKDA" },
                new FieldMetadata { Name = "avgKills" },
                new FieldMetadata { Name = "avgDeaths" },
                new FieldMetadata { Name = "avgAssists" },
                new FieldMetadata { Name = "avgTowerDamage" },
                new FieldMetadata { Name = "lastMatchDateTime", IsComplex = true },
                new FieldMetadata { Name = "firstMatchDateTime", IsComplex = true }
            };

        protected override string TypeName { get { return "MatchGroupByIsVictoryType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchGroupByIsVictoryTypeQueryBuilder WithIsVictory(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isVictory", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptIsVictory()
        {
            return ExceptField("isVictory");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithWinCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("winCount", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptWinCount()
        {
            return ExceptField("winCount");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgImp", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgImp()
        {
            return ExceptField("avgImp");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgGoldPerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgGoldPerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgGoldPerMinute()
        {
            return ExceptField("avgGoldPerMinute");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgExperiencePerMinute(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgExperiencePerMinute", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgExperiencePerMinute()
        {
            return ExceptField("avgExperiencePerMinute");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgKda(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKDA", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgKda()
        {
            return ExceptField("avgKDA");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgKills(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgKills", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgKills()
        {
            return ExceptField("avgKills");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgDeaths(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgDeaths", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgDeaths()
        {
            return ExceptField("avgDeaths");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgAssists(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgAssists", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgAssists()
        {
            return ExceptField("avgAssists");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithAvgTowerDamage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("avgTowerDamage", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptAvgTowerDamage()
        {
            return ExceptField("avgTowerDamage");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithLastMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lastMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptLastMatchDateTime()
        {
            return ExceptField("lastMatchDateTime");
        }

        public MatchGroupByIsVictoryTypeQueryBuilder WithFirstMatchDateTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("firstMatchDateTime", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchGroupByIsVictoryTypeQueryBuilder ExceptFirstMatchDateTime()
        {
            return ExceptField("firstMatchDateTime");
        }
    }
}