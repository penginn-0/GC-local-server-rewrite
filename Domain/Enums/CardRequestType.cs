﻿namespace Domain.Enums;

public enum CardRequestType
{
    #region Read
    ReadCard = 259,
    ReadCardDetail = 260,
    ReadCardDetails = 261,
    ReadCardBData = 264,
    ReadAvatar = 418,
    ReadItem = 420,
    ReadSkin = 422,
    ReadTitle = 424,
    ReadMusic = 428,
    ReadEventReward = 441,
    ReadNavigator = 443,
    ReadMusicExtra = 465,
    ReadMusicAou = 467,
    ReadCoin = 468,
    ReadUnlockReward = 507,
    ReadUnlockKeynum = 509,
    ReadSoundEffect = 8458,
    ReadGetMessage = 8461,
    ReadCond = 8465,
    ReadTotalTrophy = 8468,
    #endregion

    #region Session
    GetSession = 401,
    StartSession = 402,
    #endregion


    #region Write
    WriteCard = 771,
    WriteCardDetail = 772,
    WriteCardBData = 776,
    WriteAvatar = 929,
    WriteItem = 931,
    WriteTitle = 935,
    WriteMusicDetail = 941,
    WriteNavigator = 954,
    WriteCoin = 980,
    WriteSkin = 933,
    WriteUnlockKeynum = 1020,
    WriteSoundEffect = 8969,
    #endregion


    #region Online Matching
    StartOnlineMatching = 8705,
    UpdateOnlineMatching = 8961,
    UploadOnlineMatchingResult = 8709,
    #endregion
}