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
    public partial class LeagueTablePlayerTypeQueryBuilder : GraphQlQueryBuilder<LeagueTablePlayerTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccountId", IsComplex = true },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "overview", IsComplex = true, QueryBuilderType = typeof(LeagueTablePlayerOverviewTypeQueryBuilder) },
                new FieldMetadata { Name = "stats", IsComplex = true, QueryBuilderType = typeof(LeagueTablePlayerStatsTypeQueryBuilder) },
                new FieldMetadata { Name = "heroes", IsComplex = true, QueryBuilderType = typeof(LeagueTablePlayerHeroesObjectTypeQueryBuilder) },
                new FieldMetadata { Name = "lanes", IsComplex = true, QueryBuilderType = typeof(LeagueTablePlayerLanesObjectTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "LeagueTablePlayerType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTablePlayerTypeQueryBuilder WithSteamAccountId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("steamAccountId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerTypeQueryBuilder ExceptSteamAccountId()
        {
            return ExceptField("steamAccountId");
        }

        public LeagueTablePlayerTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LeagueTablePlayerTypeQueryBuilder WithOverview(LeagueTablePlayerOverviewTypeQueryBuilder leagueTablePlayerOverviewTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("overview", alias, leagueTablePlayerOverviewTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerTypeQueryBuilder ExceptOverview()
        {
            return ExceptField("overview");
        }

        public LeagueTablePlayerTypeQueryBuilder WithStats(LeagueTablePlayerStatsTypeQueryBuilder leagueTablePlayerStatsTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("stats", alias, leagueTablePlayerStatsTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerTypeQueryBuilder ExceptStats()
        {
            return ExceptField("stats");
        }

        public LeagueTablePlayerTypeQueryBuilder WithHeroes(LeagueTablePlayerHeroesObjectTypeQueryBuilder leagueTablePlayerHeroesObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("heroes", alias, leagueTablePlayerHeroesObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerTypeQueryBuilder ExceptHeroes()
        {
            return ExceptField("heroes");
        }

        public LeagueTablePlayerTypeQueryBuilder WithLanes(LeagueTablePlayerLanesObjectTypeQueryBuilder leagueTablePlayerLanesObjectTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("lanes", alias, leagueTablePlayerLanesObjectTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LeagueTablePlayerTypeQueryBuilder ExceptLanes()
        {
            return ExceptField("lanes");
        }
    }
}