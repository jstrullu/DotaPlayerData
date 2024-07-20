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
    public partial class PlayerHeroPerformanceLongestStreakTypeQueryBuilder : GraphQlQueryBuilder<PlayerHeroPerformanceLongestStreakTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "heroId", IsComplex = true },
                new FieldMetadata { Name = "longestStreak" },
                new FieldMetadata { Name = "currentStreak" }
            };

        protected override string TypeName { get { return "PlayerHeroPerformanceLongestStreakType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public PlayerHeroPerformanceLongestStreakTypeQueryBuilder WithHeroId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("heroId", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerHeroPerformanceLongestStreakTypeQueryBuilder ExceptHeroId()
        {
            return ExceptField("heroId");
        }

        public PlayerHeroPerformanceLongestStreakTypeQueryBuilder WithLongestStreak(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("longestStreak", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerHeroPerformanceLongestStreakTypeQueryBuilder ExceptLongestStreak()
        {
            return ExceptField("longestStreak");
        }

        public PlayerHeroPerformanceLongestStreakTypeQueryBuilder WithCurrentStreak(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("currentStreak", alias, new GraphQlDirective[] { include, skip });
        }

        public PlayerHeroPerformanceLongestStreakTypeQueryBuilder ExceptCurrentStreak()
        {
            return ExceptField("currentStreak");
        }
    }
}