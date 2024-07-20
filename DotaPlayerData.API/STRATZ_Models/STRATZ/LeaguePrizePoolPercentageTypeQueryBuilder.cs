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
    public partial class LeaguePrizePoolPercentageTypeQueryBuilder : GraphQlQueryBuilder<LeaguePrizePoolPercentageTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "leagueId" },
                new FieldMetadata { Name = "index", IsComplex = true },
                new FieldMetadata { Name = "percentage" }
            };

        protected override string TypeName { get { return "LeaguePrizePoolPercentageType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public LeaguePrizePoolPercentageTypeQueryBuilder WithLeagueId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("leagueId", alias, new GraphQlDirective[] { include, skip });
        }

        public LeaguePrizePoolPercentageTypeQueryBuilder ExceptLeagueId()
        {
            return ExceptField("leagueId");
        }

        public LeaguePrizePoolPercentageTypeQueryBuilder WithIndex(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("index", alias, new GraphQlDirective[] { include, skip });
        }

        public LeaguePrizePoolPercentageTypeQueryBuilder ExceptIndex()
        {
            return ExceptField("index");
        }

        public LeaguePrizePoolPercentageTypeQueryBuilder WithPercentage(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("percentage", alias, new GraphQlDirective[] { include, skip });
        }

        public LeaguePrizePoolPercentageTypeQueryBuilder ExceptPercentage()
        {
            return ExceptField("percentage");
        }
    }
}