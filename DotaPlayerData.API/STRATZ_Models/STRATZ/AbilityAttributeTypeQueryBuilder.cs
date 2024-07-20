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
    public partial class AbilityAttributeTypeQueryBuilder : GraphQlQueryBuilder<AbilityAttributeTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "name" },
                new FieldMetadata { Name = "value" },
                new FieldMetadata { Name = "linkedSpecialBonusAbilityId", IsComplex = true },
                new FieldMetadata { Name = "requiresScepter" }
            };

        protected override string TypeName { get { return "AbilityAttributeType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AbilityAttributeTypeQueryBuilder WithName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("name", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityAttributeTypeQueryBuilder ExceptName()
        {
            return ExceptField("name");
        }

        public AbilityAttributeTypeQueryBuilder WithValue(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("value", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityAttributeTypeQueryBuilder ExceptValue()
        {
            return ExceptField("value");
        }

        public AbilityAttributeTypeQueryBuilder WithLinkedSpecialBonusAbilityId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("linkedSpecialBonusAbilityId", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityAttributeTypeQueryBuilder ExceptLinkedSpecialBonusAbilityId()
        {
            return ExceptField("linkedSpecialBonusAbilityId");
        }

        public AbilityAttributeTypeQueryBuilder WithRequiresScepter(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("requiresScepter", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityAttributeTypeQueryBuilder ExceptRequiresScepter()
        {
            return ExceptField("requiresScepter");
        }
    }
}