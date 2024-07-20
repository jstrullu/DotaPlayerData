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
    public partial class AbilityLanguageTypeQueryBuilder : GraphQlQueryBuilder<AbilityLanguageTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "displayName" },
                new FieldMetadata { Name = "description", IsComplex = true },
                new FieldMetadata { Name = "attributes", IsComplex = true },
                new FieldMetadata { Name = "lore" },
                new FieldMetadata { Name = "aghanimDescription" },
                new FieldMetadata { Name = "shardDescription" },
                new FieldMetadata { Name = "notes", IsComplex = true }
            };

        protected override string TypeName { get { return "AbilityLanguageType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public AbilityLanguageTypeQueryBuilder WithDisplayName(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("displayName", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptDisplayName()
        {
            return ExceptField("displayName");
        }

        public AbilityLanguageTypeQueryBuilder WithDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("description", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptDescription()
        {
            return ExceptField("description");
        }

        public AbilityLanguageTypeQueryBuilder WithAttributes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("attributes", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptAttributes()
        {
            return ExceptField("attributes");
        }

        public AbilityLanguageTypeQueryBuilder WithLore(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("lore", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptLore()
        {
            return ExceptField("lore");
        }

        public AbilityLanguageTypeQueryBuilder WithAghanimDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("aghanimDescription", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptAghanimDescription()
        {
            return ExceptField("aghanimDescription");
        }

        public AbilityLanguageTypeQueryBuilder WithShardDescription(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("shardDescription", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptShardDescription()
        {
            return ExceptField("shardDescription");
        }

        public AbilityLanguageTypeQueryBuilder WithNotes(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("notes", alias, new GraphQlDirective[] { include, skip });
        }

        public AbilityLanguageTypeQueryBuilder ExceptNotes()
        {
            return ExceptField("notes");
        }
    }
}