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
    public partial class LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder : GraphQlQueryBuilder<LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "match", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "level", IsComplex = true }
            };

        protected override string TypeName { get { return "LiveEventPlayerHeroDotaPlusLevelType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder WithMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("match", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder ExceptMatch()
        {
            return ExceptField("match");
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder WithLevel(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("level", alias, new GraphQlDirective[] { include, skip });
        }

        public LiveEventPlayerHeroDotaPlusLevelTypeQueryBuilder ExceptLevel()
        {
            return ExceptField("level");
        }
    }
}