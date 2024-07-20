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
    public partial class MatchLiveRoshanDetailTypeQueryBuilder : GraphQlQueryBuilder<MatchLiveRoshanDetailTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "isAlive" },
                new FieldMetadata { Name = "respawnTimer" }
            };

        protected override string TypeName { get { return "MatchLiveRoshanDetailType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchLiveRoshanDetailTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveRoshanDetailTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchLiveRoshanDetailTypeQueryBuilder WithIsAlive(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("isAlive", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveRoshanDetailTypeQueryBuilder ExceptIsAlive()
        {
            return ExceptField("isAlive");
        }

        public MatchLiveRoshanDetailTypeQueryBuilder WithRespawnTimer(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("respawnTimer", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchLiveRoshanDetailTypeQueryBuilder ExceptRespawnTimer()
        {
            return ExceptField("respawnTimer");
        }
    }
}