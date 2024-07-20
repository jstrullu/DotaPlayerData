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
    public partial class LeagueTableTeamHeroesObjectTypeQueryBuilder : GraphQlQueryBuilder<LeagueTableTeamHeroesObjectTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId" },
                new FieldMetadata { Name = "matchCount" },
                new FieldMetadata { Name = "matchWins" },
                new FieldMetadata { Name = "imp", IsComplex = true },
                new FieldMetadata { Name = "banCount" }
            };

        protected override string TypeName { get { return "LeagueTableTeamHeroesObjectType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithMatchCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptMatchCount()
        {
            return ExceptField("matchCount");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithMatchWins(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("matchWins", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptMatchWins()
        {
            return ExceptField("matchWins");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithImp(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("imp", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptImp()
        {
            return ExceptField("imp");
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder WithBanCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("banCount", alias, new GraphQlDirective[] { include, skip });
        }

        public LeagueTableTeamHeroesObjectTypeQueryBuilder ExceptBanCount()
        {
            return ExceptField("banCount");
        }
    }
}