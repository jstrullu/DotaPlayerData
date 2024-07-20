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
    public partial class UserTypeQueryBuilder : GraphQlQueryBuilder<UserTypeQueryBuilder>
    {
        private static readonly FieldMetadata[] AllFieldMetadata =
            new []
            {
                new FieldMetadata { Name = "profile", IsComplex = true, QueryBuilderType = typeof(CaptainJackIdentityPrivateProfileTypeQueryBuilder) },
                new FieldMetadata { Name = "steamAccount", IsComplex = true, QueryBuilderType = typeof(SteamAccountTypeQueryBuilder) },
                new FieldMetadata { Name = "recentMatch", IsComplex = true, QueryBuilderType = typeof(MatchTypeQueryBuilder) },
                new FieldMetadata { Name = "followingCount" },
                new FieldMetadata { Name = "followerCount" },
                new FieldMetadata { Name = "followingLeagueCount" },
                new FieldMetadata { Name = "followingTeamCount" },
                new FieldMetadata { Name = "stratzApiApplications", IsComplex = true, QueryBuilderType = typeof(CaptainJackIdentityApiApplicationTypeQueryBuilder) }
            };

        protected override string TypeName { get { return "UserType"; } } 

        public override IReadOnlyList<FieldMetadata> AllFields { get { return AllFieldMetadata; } } 

        public UserTypeQueryBuilder WithProfile(CaptainJackIdentityPrivateProfileTypeQueryBuilder captainJackIdentityPrivateProfileTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("profile", alias, captainJackIdentityPrivateProfileTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptProfile()
        {
            return ExceptField("profile");
        }

        public UserTypeQueryBuilder WithSteamAccount(SteamAccountTypeQueryBuilder steamAccountTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("steamAccount", alias, steamAccountTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptSteamAccount()
        {
            return ExceptField("steamAccount");
        }

        public UserTypeQueryBuilder WithRecentMatch(MatchTypeQueryBuilder matchTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("recentMatch", alias, matchTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptRecentMatch()
        {
            return ExceptField("recentMatch");
        }

        public UserTypeQueryBuilder WithFollowingCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("followingCount", alias, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptFollowingCount()
        {
            return ExceptField("followingCount");
        }

        public UserTypeQueryBuilder WithFollowerCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("followerCount", alias, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptFollowerCount()
        {
            return ExceptField("followerCount");
        }

        public UserTypeQueryBuilder WithFollowingLeagueCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("followingLeagueCount", alias, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptFollowingLeagueCount()
        {
            return ExceptField("followingLeagueCount");
        }

        public UserTypeQueryBuilder WithFollowingTeamCount(string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithScalarField("followingTeamCount", alias, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptFollowingTeamCount()
        {
            return ExceptField("followingTeamCount");
        }

        public UserTypeQueryBuilder WithStratzApiApplications(CaptainJackIdentityApiApplicationTypeQueryBuilder captainJackIdentityApiApplicationTypeQueryBuilder, string alias = null, IncludeDirective include = null, SkipDirective skip = null)
        {
            return WithObjectField("stratzApiApplications", alias, captainJackIdentityApiApplicationTypeQueryBuilder, new GraphQlDirective[] { include, skip });
        }

        public UserTypeQueryBuilder ExceptStratzApiApplications()
        {
            return ExceptField("stratzApiApplications");
        }
    }
}