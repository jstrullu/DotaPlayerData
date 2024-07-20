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
    public partial class MatchPlayerStatsChatWheelEventTypeQueryBuilder : GraphQlQueryBuilder<MatchPlayerStatsChatWheelEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "chatWheelId", IsComplex = true },
                new FieldMetadata { Name = "pauseTick" }
            };

        protected override string TypeName { get { return "MatchPlayerStatsChatWheelEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public MatchPlayerStatsChatWheelEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsChatWheelEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public MatchPlayerStatsChatWheelEventTypeQueryBuilder WithChatWheelId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("chatWheelId", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsChatWheelEventTypeQueryBuilder ExceptChatWheelId()
        {
            return ExceptField("chatWheelId");
        }

        public MatchPlayerStatsChatWheelEventTypeQueryBuilder WithPauseTick(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("pauseTick", alias, new GraphQlDirective[] { include, skip });
        }

        public MatchPlayerStatsChatWheelEventTypeQueryBuilder ExceptPauseTick()
        {
            return ExceptField("pauseTick");
        }
    }
}