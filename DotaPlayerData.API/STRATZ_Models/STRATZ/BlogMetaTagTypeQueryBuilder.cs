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
    public partial class BlogMetaTagTypeQueryBuilder : GraphQlQueryBuilder<BlogMetaTagTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "id", IsComplex = true },
                new FieldMetadata { Name = "blogId", IsComplex = true },
                new FieldMetadata { Name = "blogMetaTagTypeId", IsComplex = true },
                new FieldMetadata { Name = "metaTag", IsComplex = true, QueryBuilderType = typeof(BlogMetaTagInfoTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "BlogMetaTagType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public BlogMetaTagTypeQueryBuilder WithId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("id", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogMetaTagTypeQueryBuilder ExceptId()
        {
            return ExceptField("id");
        }

        public BlogMetaTagTypeQueryBuilder WithBlogId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("blogId", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogMetaTagTypeQueryBuilder ExceptBlogId()
        {
            return ExceptField("blogId");
        }

        public BlogMetaTagTypeQueryBuilder WithBlogMetaTagTypeId(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("blogMetaTagTypeId", alias, new GraphQlDirective[] { include, skip });
        }

        public BlogMetaTagTypeQueryBuilder ExceptBlogMetaTagTypeId()
        {
            return ExceptField("blogMetaTagTypeId");
        }

        public BlogMetaTagTypeQueryBuilder WithMetaTag(BlogMetaTagInfoTypeQueryBuilder blogMetaTagInfoTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("metaTag", alias, blogMetaTagInfoTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public BlogMetaTagTypeQueryBuilder ExceptMetaTag()
        {
            return ExceptField("metaTag");
        }
    }
}