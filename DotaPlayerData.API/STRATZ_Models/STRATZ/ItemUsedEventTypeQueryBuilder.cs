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
    public partial class ItemUsedEventTypeQueryBuilder : GraphQlQueryBuilder<ItemUsedEventTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "time" },
                new FieldMetadata { Name = "itemId", IsComplex = true },
                new FieldMetadata { Name = "attacker", IsComplex = true },
                new FieldMetadata { Name = "target", IsComplex = true }
            };

        protected override string TypeName { get { return "ItemUsedEventType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public ItemUsedEventTypeQueryBuilder WithTime(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("time", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemUsedEventTypeQueryBuilder ExceptTime()
        {
            return ExceptField("time");
        }

        public ItemUsedEventTypeQueryBuilder WithItemId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("itemId", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemUsedEventTypeQueryBuilder ExceptItemId()
        {
            return ExceptField("itemId");
        }

        public ItemUsedEventTypeQueryBuilder WithAttacker(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attacker", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemUsedEventTypeQueryBuilder ExceptAttacker()
        {
            return ExceptField("attacker");
        }

        public ItemUsedEventTypeQueryBuilder WithTarget(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("target", alias, new GraphQlDirective[] { include, skip });
        }

        public ItemUsedEventTypeQueryBuilder ExceptTarget()
        {
            return ExceptField("target");
        }
    }
}