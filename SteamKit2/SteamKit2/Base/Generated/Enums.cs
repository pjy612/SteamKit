// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: enums.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileQueryType
    {
        k_PublishedFileQueryType_RankedByVote = 0,
        k_PublishedFileQueryType_RankedByPublicationDate = 1,
        k_PublishedFileQueryType_AcceptedForGameRankedByAcceptanceDate = 2,
        k_PublishedFileQueryType_RankedByTrend = 3,
        k_PublishedFileQueryType_FavoritedByFriendsRankedByPublicationDate = 4,
        k_PublishedFileQueryType_CreatedByFriendsRankedByPublicationDate = 5,
        k_PublishedFileQueryType_RankedByNumTimesReported = 6,
        k_PublishedFileQueryType_CreatedByFollowedUsersRankedByPublicationDate = 7,
        k_PublishedFileQueryType_NotYetRated = 8,
        k_PublishedFileQueryType_RankedByTotalUniqueSubscriptions = 9,
        k_PublishedFileQueryType_RankedByTotalVotesAsc = 10,
        k_PublishedFileQueryType_RankedByVotesUp = 11,
        k_PublishedFileQueryType_RankedByTextSearch = 12,
        k_PublishedFileQueryType_RankedByPlaytimeTrend = 13,
        k_PublishedFileQueryType_RankedByTotalPlaytime = 14,
        k_PublishedFileQueryType_RankedByAveragePlaytimeTrend = 15,
        k_PublishedFileQueryType_RankedByLifetimeAveragePlaytime = 16,
        k_PublishedFileQueryType_RankedByPlaytimeSessionsTrend = 17,
        k_PublishedFileQueryType_RankedByLifetimePlaytimeSessions = 18,
        k_PublishedFileQueryType_RankedByInappropriateContentRating = 19,
        k_PublishedFileQueryType_RankedByBanContentCheck = 20,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileInappropriateProvider
    {
        k_EPublishedFileInappropriateProvider_Invalid = 0,
        k_EPublishedFileInappropriateProvider_Google = 1,
        k_EPublishedFileInappropriateProvider_Amazon = 2,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileInappropriateResult
    {
        k_EPublishedFileInappropriateResult_NotScanned = 0,
        k_EPublishedFileInappropriateResult_VeryUnlikely = 1,
        k_EPublishedFileInappropriateResult_Unlikely = 30,
        k_EPublishedFileInappropriateResult_Possible = 50,
        k_EPublishedFileInappropriateResult_Likely = 75,
        k_EPublishedFileInappropriateResult_VeryLikely = 100,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPersonaStateFlag
    {
        k_EPersonaStateFlag_HasRichPresence = 1,
        k_EPersonaStateFlag_InJoinableGame = 2,
        k_EPersonaStateFlag_Golden = 4,
        k_EPersonaStateFlag_RemotePlayTogether = 8,
        k_EPersonaStateFlag_ClientTypeWeb = 256,
        k_EPersonaStateFlag_ClientTypeMobile = 512,
        k_EPersonaStateFlag_ClientTypeTenfoot = 1024,
        k_EPersonaStateFlag_ClientTypeVR = 2048,
        k_EPersonaStateFlag_LaunchTypeGamepad = 4096,
        k_EPersonaStateFlag_LaunchTypeCompatTool = 8192,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EContentCheckProvider
    {
        k_EContentCheckProvider_Invalid = 0,
        k_EContentCheckProvider_Google = 1,
        k_EContentCheckProvider_Amazon = 2,
        k_EContentCheckProvider_Local = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EBanContentCheckResult
    {
        k_EBanContentCheckResult_NotScanned = 0,
        k_EBanContentCheckResult_Reset = 1,
        k_EBanContentCheckResult_NeedsChecking = 2,
        k_EBanContentCheckResult_VeryUnlikely = 5,
        k_EBanContentCheckResult_Unlikely = 30,
        k_EBanContentCheckResult_Possible = 50,
        k_EBanContentCheckResult_Likely = 75,
        k_EBanContentCheckResult_VeryLikely = 100,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EProfileCustomizationType
    {
        k_EProfileCustomizationTypeInvalid = 0,
        k_EProfileCustomizationTypeRareAchievementShowcase = 1,
        k_EProfileCustomizationTypeGameCollector = 2,
        k_EProfileCustomizationTypeItemShowcase = 3,
        k_EProfileCustomizationTypeTradeShowcase = 4,
        k_EProfileCustomizationTypeBadges = 5,
        k_EProfileCustomizationTypeFavoriteGame = 6,
        k_EProfileCustomizationTypeScreenshotShowcase = 7,
        k_EProfileCustomizationTypeCustomText = 8,
        k_EProfileCustomizationTypeFavoriteGroup = 9,
        k_EProfileCustomizationTypeRecommendation = 10,
        k_EProfileCustomizationTypeWorkshopItem = 11,
        k_EProfileCustomizationTypeMyWorkshop = 12,
        k_EProfileCustomizationTypeArtworkShowcase = 13,
        k_EProfileCustomizationTypeVideoShowcase = 14,
        k_EProfileCustomizationTypeGuides = 15,
        k_EProfileCustomizationTypeMyGuides = 16,
        k_EProfileCustomizationTypeAchievements = 17,
        k_EProfileCustomizationTypeGreenlight = 18,
        k_EProfileCustomizationTypeMyGreenlight = 19,
        k_EProfileCustomizationTypeSalien = 20,
        k_EProfileCustomizationTypeLoyaltyRewardReactions = 21,
        k_EProfileCustomizationTypeSingleArtworkShowcase = 22,
        k_EProfileCustomizationTypeAchievementsCompletionist = 23,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EPublishedFileStorageSystem
    {
        k_EPublishedFileStorageSystemInvalid = 0,
        k_EPublishedFileStorageSystemLegacyCloud = 1,
        k_EPublishedFileStorageSystemDepot = 2,
        k_EPublishedFileStorageSystemUGCCloud = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECloudStoragePersistState
    {
        k_ECloudStoragePersistStatePersisted = 0,
        k_ECloudStoragePersistStateForgotten = 1,
        k_ECloudStoragePersistStateDeleted = 2,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
