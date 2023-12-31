using System;
using System.Runtime.InteropServices;

namespace Steamworks;

internal static class NativeMethods
{
	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Shutdown")]
	public static extern void SteamAPI_Shutdown();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsSteamRunning")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool SteamAPI_IsSteamRunning();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "RestartAppIfNecessary")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WriteMiniDump")]
	public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMiniDumpComment")]
	public static extern void SteamAPI_SetMiniDumpComment(IntPtr pchMsg);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InitSafe")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool SteamAPI_InitSafe();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_GetHSteamUserCurrent_")]
	public static extern HSteamUser Steam_GetHSteamUserCurrent();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSteamInstallPath")]
	public static extern int SteamAPI_GetSteamInstallPath();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetHSteamPipe_")]
	public static extern HSteamPipe SteamAPI_GetHSteamPipe();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetHSteamUser_")]
	public static extern HSteamUser SteamAPI_GetHSteamUser();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_InitSafe")]
	public static extern bool SteamGameServer_InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, IntPtr pchVersionString);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_Shutdown")]
	public static extern void SteamGameServer_Shutdown();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_BSecure")]
	public static extern bool SteamGameServer_BSecure();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_GetSteamID")]
	public static extern CSteamID SteamGameServer_GetSteamID();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_GetHSteamPipe")]
	public static extern HSteamPipe SteamGameServer_GetHSteamPipe();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_GetHSteamUser")]
	public static extern HSteamUser SteamGameServer_GetHSteamUser();

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BDecryptTicket")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, out uint pcubTicketDecrypted, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32)] byte[] rgubKey, int cubKey);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BIsTicketForApp")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketIssueTime")]
	public static extern uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketSteamID")]
	public static extern void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketAppID")]
	public static extern uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BUserOwnsAppInTicket")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BUserIsVacBanned")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

	[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetUserVariableData")]
	public static extern IntPtr GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_BGetCallback2")]
	public static extern bool Steam_BGetCallback(HSteamPipe hSteamPipe, out CallbackMsg_t pCallbackMsg);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_FreeLastCallback2")]
	public static extern void Steam_FreeLastCallback(HSteamPipe hSteamPipe);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_GetAPICallResult2")]
	public static extern bool Steam_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsSubscribed();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsLowViolence();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsCybercafe();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsVACBanned();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamApps_GetCurrentGameLanguage();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamApps_GetAvailableGameLanguages();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsSubscribedApp(AppId_t appID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsDlcInstalled(AppId_t appID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(AppId_t nAppID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamApps_GetDLCCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamApps_InstallDLC(AppId_t nAppID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamApps_UninstallDLC(AppId_t nAppID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamApps_RequestAppProofOfPurchaseKey(AppId_t nAppID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_GetCurrentBetaName(IntPtr pchName, int cchNameBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_MarkContentCorrupt([MarshalAs(UnmanagedType.I1)] bool bMissingFilesOnly);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamApps_GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamApps_GetAppInstallDir(AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamApps_BIsAppInstalled(AppId_t appID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamApps_GetAppOwner();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr pchKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HSteamPipe ISteamClient_CreateSteamPipe();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamClient_BReleaseSteamPipe(HSteamPipe hSteamPipe);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HSteamUser ISteamClient_ConnectToGlobalUser(HSteamPipe hSteamPipe);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HSteamUser ISteamClient_CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamClient_ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamClient_SetLocalIPBinding(uint unIP, ushort usPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamUtils(HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamClient_RunFrame();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamClient_GetIPCCallCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamClient_SetWarningMessageHook(IntPtr pFunction);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamClient_BShutdownIfAllPipesClosed();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamClient_GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, IntPtr pchVersion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamController_Init(IntPtr pchAbsolutePathToControllerConfigVDF);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamController_Shutdown();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamController_RunFrame();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamController_GetControllerState(uint unControllerIndex, out SteamControllerState_t pState);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamController_TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamController_SetOverrideMode(IntPtr pchMode);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetPersonaName();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_SetPersonaName(IntPtr pchPersonaName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EPersonaState ISteamFriends_GetPersonaState();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetFriendCount(EFriendFlags iFriendFlags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EPersonaState ISteamFriends_GetFriendPersonaState(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetFriendPersonaName(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetPlayerNickname(CSteamID steamIDPlayer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetClanCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetClanByIndex(int iClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetClanName(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetClanTag(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetFriendCountFromSource(CSteamID steamIDSource);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_SetInGameVoiceSpeaking(CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_ActivateGameOverlay(IntPtr pchDialog);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr pchDialog, CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr pchURL);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_SetPlayedWith(CSteamID steamIDUserPlayedWith);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetSmallFriendAvatar(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetMediumFriendAvatar(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetLargeFriendAvatar(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_RequestUserInformation(CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_RequestClanOfficerList(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetClanOwner(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetClanOfficerCount(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamFriends_GetUserRestrictions();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_SetRichPresence(IntPtr pchKey, IntPtr pchValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_ClearRichPresence();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetFriendRichPresence(CSteamID steamIDFriend, IntPtr pchKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamFriends_RequestFriendRichPresence(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_InviteUserToGame(CSteamID steamIDFriend, IntPtr pchConnectString);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetCoplayFriendCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetCoplayFriend(int iCoplayFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetFriendCoplayTime(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern AppId_t ISteamFriends_GetFriendCoplayGame(CSteamID steamIDFriend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_JoinClanChatRoom(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_LeaveClanChatRoom(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetClanChatMemberCount(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamFriends_GetChatMemberByIndex(CSteamID steamIDClan, int iUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_SendClanChatMessage(CSteamID steamIDClanChat, IntPtr pchText);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_OpenClanChatWindowInSteam(CSteamID steamIDClanChat);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_CloseClanChatWindowInSteam(CSteamID steamIDClanChat);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_SetListenForFriendsMessages([MarshalAs(UnmanagedType.I1)] bool bInterceptEnabled);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamFriends_ReplyToFriendMessage(CSteamID steamIDFriend, IntPtr pchMsgToSend);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamFriends_GetFriendMessage(CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_GetFollowerCount(CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_IsFollowing(CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamFriends_EnumerateFollowingList(uint unStartIndex);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, IntPtr pchVersionString);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetProduct(IntPtr pszProduct);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetGameDescription(IntPtr pszGameDescription);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetModDir(IntPtr pszModDir);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetDedicatedServer([MarshalAs(UnmanagedType.I1)] bool bDedicated);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_LogOnAnonymous();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_LogOff();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_BLoggedOn();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_BSecure();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamGameServer_GetSteamID();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_WasRestartRequested();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetMaxPlayerCount(int cPlayersMax);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetBotPlayerCount(int cBotplayers);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetServerName(IntPtr pszServerName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetMapName(IntPtr pszMapName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetPasswordProtected([MarshalAs(UnmanagedType.I1)] bool bPasswordProtected);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetSpectatorPort(ushort unSpectatorPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr pszSpectatorServerName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_ClearAllKeyValues();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetKeyValue(IntPtr pKey, IntPtr pValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetGameTags(IntPtr pchGameTags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetGameData(IntPtr pchGameData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetRegion(IntPtr pszRegion);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(uint unIPClient, IntPtr pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamGameServer_CreateUnauthenticatedUserConnection();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SendUserDisconnect(CSteamID steamIDUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_BUpdateUserData(CSteamID steamIDUser, IntPtr pchPlayerName, uint uScore);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HAuthTicket ISteamGameServer_GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, out uint pcbTicket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr pAuthTicket, int cbAuthTicket, CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_EndAuthSession(CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_CancelAuthTicket(HAuthTicket hAuthTicket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_GetGameplayStats();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamGameServer_GetServerReputation();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServer_GetPublicIP();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr pData, int cbData, uint srcIP, ushort srcPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_EnableHeartbeats([MarshalAs(UnmanagedType.I1)] bool bActive);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_SetHeartbeatInterval(int iHeartbeatInterval);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServer_ForceHeartbeat();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamGameServer_AssociateWithClan(CSteamID steamIDClan);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamGameServer_ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HTTPRequestHandle ISteamGameServerHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, IntPtr pchAbsoluteURL);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, IntPtr pchHeaderName, IntPtr pchHeaderValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, IntPtr pchParamName, IntPtr pchParamValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, IntPtr pchHeaderName, out uint unResponseHeaderSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, IntPtr pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, IntPtr pchContentType, byte[] pubBody, uint unBodyLen);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_GetP2PSessionState(CSteamID steamIDRemote, IntPtr pConnectionState);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_AllowP2PPacketRelay([MarshalAs(UnmanagedType.I1)] bool bAllow);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SNetListenSocket_t ISteamGameServerNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SNetSocket_t ISteamGameServerNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SNetSocket_t ISteamGameServerNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_DestroySocket(SNetSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ESNetSocketConnectionType ISteamGameServerNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamGameServerNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamGameServerStats_RequestUserStats(CSteamID steamIDUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_GetUserStat(CSteamID steamIDUser, IntPtr pchName, out int pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_GetUserStat_(CSteamID steamIDUser, IntPtr pchName, out float pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_GetUserAchievement(CSteamID steamIDUser, IntPtr pchName, out bool pbAchieved);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_SetUserStat(CSteamID steamIDUser, IntPtr pchName, int nData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_SetUserStat_(CSteamID steamIDUser, IntPtr pchName, float fData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(CSteamID steamIDUser, IntPtr pchName, float flCountThisSession, double dSessionLength);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_SetUserAchievement(CSteamID steamIDUser, IntPtr pchName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerStats_ClearUserAchievement(CSteamID steamIDUser, IntPtr pchName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamGameServerStats_StoreUserStats(CSteamID steamIDUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServerUtils_GetSecondsSinceAppActive();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServerUtils_GetSecondsSinceComputerActive();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EUniverse ISteamGameServerUtils_GetConnectedUniverse();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServerUtils_GetServerRealTime();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamGameServerUtils_GetIPCountry();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern byte ISteamGameServerUtils_GetCurrentBatteryPower();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServerUtils_GetAppID();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServerUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ESteamAPICallFailure ISteamGameServerUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServerUtils_RunFrame();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServerUtils_GetIPCCallCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamGameServerUtils_SetWarningMessageHook(IntPtr pFunction);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_IsOverlayEnabled();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_BOverlayNeedsPresent();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamGameServerUtils_CheckFileSignature(IntPtr szFileName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, IntPtr pchDescription, uint unCharMax);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamGameServerUtils_GetEnteredGamepadTextLength();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamGameServerUtils_GetSteamUILanguage();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamGameServerUtils_IsSteamRunningInVR();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HTTPRequestHandle ISteamHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, IntPtr pchAbsoluteURL);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, IntPtr pchHeaderName, IntPtr pchHeaderValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, IntPtr pchParamName, IntPtr pchParamValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, IntPtr pchHeaderName, out uint unResponseHeaderSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, IntPtr pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, IntPtr pchContentType, byte[] pubBody, uint unBodyLen);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamMatchmaking_GetFavoriteGameCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamMatchmaking_RequestLobbyList();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr pchKeyToMatch, IntPtr pchValueToMatch, ELobbyComparison eComparisonType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr pchKeyToMatch, int nValueToBeCloseTo);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(int cMaxResults);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamMatchmaking_GetLobbyByIndex(int iLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamMatchmaking_CreateLobby(ELobbyType eLobbyType, int cMaxMembers);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamMatchmaking_JoinLobby(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_LeaveLobby(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamMatchmaking_GetNumLobbyMembers(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamMatchmaking_GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamMatchmaking_GetLobbyData(CSteamID steamIDLobby, IntPtr pchKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SetLobbyData(CSteamID steamIDLobby, IntPtr pchKey, IntPtr pchValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamMatchmaking_GetLobbyDataCount(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_DeleteLobbyData(CSteamID steamIDLobby, IntPtr pchKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, IntPtr pchKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_SetLobbyMemberData(CSteamID steamIDLobby, IntPtr pchKey, IntPtr pchValue);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SendLobbyChatMsg(CSteamID steamIDLobby, IntPtr pvMsgBody, int cubMsgBody);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamMatchmaking_GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_RequestLobbyData(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmaking_SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamMatchmaking_GetLobbyMemberLimit(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SetLobbyJoinable(CSteamID steamIDLobby, [MarshalAs(UnmanagedType.I1)] bool bLobbyJoinable);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamMatchmaking_GetLobbyOwner(CSteamID steamIDLobby);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmaking_SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerListRequest ISteamMatchmakingServers_RequestInternetServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerListRequest ISteamMatchmakingServers_RequestLANServerList(AppId_t iApp, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerListRequest ISteamMatchmakingServers_RequestFriendsServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerListRequest ISteamMatchmakingServers_RequestFavoritesServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerListRequest ISteamMatchmakingServers_RequestHistoryServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerListRequest ISteamMatchmakingServers_RequestSpectatorServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmakingServers_ReleaseRequest(HServerListRequest hServerListRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(HServerListRequest hRequest, int iServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmakingServers_CancelQuery(HServerListRequest hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmakingServers_RefreshQuery(HServerListRequest hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamMatchmakingServers_IsRefreshing(HServerListRequest hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamMatchmakingServers_GetServerCount(HServerListRequest hRequest);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmakingServers_RefreshServer(HServerListRequest hRequest, int iServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerQuery ISteamMatchmakingServers_PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerQuery ISteamMatchmakingServers_PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HServerQuery ISteamMatchmakingServers_ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamMatchmakingServers_CancelServerQuery(HServerQuery hServerQuery);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_GetP2PSessionState(CSteamID steamIDRemote, IntPtr pConnectionState);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_AllowP2PPacketRelay([MarshalAs(UnmanagedType.I1)] bool bAllow);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SNetListenSocket_t ISteamNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SNetSocket_t ISteamNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SNetSocket_t ISteamNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_DestroySocket(SNetSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileWrite(IntPtr pchFile, byte[] pvData, int cubData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamRemoteStorage_FileRead(IntPtr pchFile, byte[] pvData, int cubDataToRead);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileForget(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileDelete(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_FileShare(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern UGCFileWriteStreamHandle_t ISteamRemoteStorage_FileWriteStreamOpen(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FileExists(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamRemoteStorage_GetFileSize(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamRemoteStorage_GetFileCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(int iFile, out int pnFileSizeInBytes);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_GetQuota(out int pnTotalBytes, out int puAvailableBytes);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamRemoteStorage_SetCloudEnabledForApp([MarshalAs(UnmanagedType.I1)] bool bEnabled);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_UGCDownload(UGCHandle_t hContent, uint unPriority);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamRemoteStorage_UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamRemoteStorage_GetCachedUGCCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern UGCHandle_t ISteamRemoteStorage_GetCachedUGCHandle(int iCachedContent);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_PublishWorkshopFile(IntPtr pchFile, IntPtr pchPreviewFile, AppId_t nConsumerAppId, IntPtr pchTitle, IntPtr pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern PublishedFileUpdateHandle_t ISteamRemoteStorage_CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, IntPtr pchFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, IntPtr pchPreviewFile);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, IntPtr pchTitle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, IntPtr pchDescription);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_DeletePublishedFile(PublishedFileId_t unPublishedFileId);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_EnumerateUserPublishedFiles(uint unStartIndex);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_SubscribePublishedFile(PublishedFileId_t unPublishedFileId);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_EnumerateUserSubscribedFiles(uint unStartIndex);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, IntPtr pchChangeDescription);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_PublishVideo(EWorkshopVideoProvider eVideoProvider, IntPtr pchVideoAccount, IntPtr pchVideoIdentifier, IntPtr pchPreviewFile, AppId_t nConsumerAppId, IntPtr pchTitle, IntPtr pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamRemoteStorage_UGCDownloadToLocation(UGCHandle_t hContent, IntPtr pchLocation, uint unPriority);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ScreenshotHandle ISteamScreenshots_WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ScreenshotHandle ISteamScreenshots_AddScreenshotToLibrary(IntPtr pchFilename, IntPtr pchThumbnailFilename, int nWidth, int nHeight);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamScreenshots_TriggerScreenshot();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamScreenshots_HookScreenshots([MarshalAs(UnmanagedType.I1)] bool bHook);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamScreenshots_SetLocation(ScreenshotHandle hScreenshot, IntPtr pchLocation);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamScreenshots_TagUser(ScreenshotHandle hScreenshot, CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamScreenshots_TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern UGCQueryHandle_t ISteamUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern UGCQueryHandle_t ISteamUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_AddRequiredTag(UGCQueryHandle_t handle, IntPtr pTagName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_AddExcludedTag(UGCQueryHandle_t handle, IntPtr pTagName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_SetReturnLongDescription(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnLongDescription);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnTotalOnly);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, IntPtr pMatchCloudFileName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_SetMatchAnyTag(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bMatchAnyTag);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_SetSearchText(UGCQueryHandle_t handle, IntPtr pSearchText);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ClientUnifiedMessageHandle ISteamUnifiedMessages_SendMethod(IntPtr pchServiceMethod, IntPtr pRequestBuffer, uint unRequestBufferSize, ulong unContext);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUnifiedMessages_GetMethodResponseData(ClientUnifiedMessageHandle hHandle, IntPtr pResponseBuffer, uint unResponseBufferSize, [MarshalAs(UnmanagedType.I1)] bool bAutoRelease);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUnifiedMessages_ReleaseMethod(ClientUnifiedMessageHandle hHandle);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUnifiedMessages_SendNotification(IntPtr pchServiceNotification, IntPtr pNotificationBuffer, uint unNotificationBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HSteamUser ISteamUser_GetHSteamUser();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUser_BLoggedOn();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern CSteamID ISteamUser_GetSteamID();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUser_InitiateGameConnection(IntPtr pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_TerminateGameConnection(uint unIPServer, ushort usPortServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, IntPtr pchExtraInfo);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUser_GetUserDataFolder(IntPtr pchBuffer, int cubBuffer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_StartVoiceRecording();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_StopVoiceRecording();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EVoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EVoiceResult ISteamUser_GetVoice([MarshalAs(UnmanagedType.I1)] bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, [MarshalAs(UnmanagedType.I1)] bool bWantUncompressed, byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EVoiceResult ISteamUser_DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUser_GetVoiceOptimalSampleRate();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern HAuthTicket ISteamUser_GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_EndAuthSession(CSteamID steamID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_CancelAuthTicket(HAuthTicket hAuthTicket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUser_BIsBehindNAT();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUser_AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUser_RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUser_GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUser_GetGameBadgeLevel(int nSeries, [MarshalAs(UnmanagedType.I1)] bool bFoil);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUser_GetPlayerSteamLevel();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_RequestCurrentStats();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetStat(IntPtr pchName, out int pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetStat_(IntPtr pchName, out float pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_SetStat(IntPtr pchName, int nData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_SetStat_(IntPtr pchName, float fData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr pchName, float flCountThisSession, double dSessionLength);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetAchievement(IntPtr pchName, out bool pbAchieved);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_SetAchievement(IntPtr pchName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_ClearAchievement(IntPtr pchName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr pchName, out bool pbAchieved, out uint punUnlockTime);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_StoreStats();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUserStats_GetAchievementIcon(IntPtr pchName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr pchName, IntPtr pchKey);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr pchName, uint nCurProgress, uint nMaxProgress);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUserStats_GetNumAchievements();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamUserStats_GetAchievementName(uint iAchievement);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_RequestUserStats(CSteamID steamIDUser);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetUserStat(CSteamID steamIDUser, IntPtr pchName, out int pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetUserStat_(CSteamID steamIDUser, IntPtr pchName, out float pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetUserAchievement(CSteamID steamIDUser, IntPtr pchName, out bool pbAchieved);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamID steamIDUser, IntPtr pchName, out bool pbAchieved, out uint punUnlockTime);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_ResetAllStats([MarshalAs(UnmanagedType.I1)] bool bAchievementsToo);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_FindOrCreateLeaderboard(IntPtr pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_FindLeaderboard(IntPtr pchLeaderboardName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamUserStats_GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUserStats_GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, out int pDetails, int cDetailsMax);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_GetNumberOfCurrentPlayers();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_RequestGlobalAchievementPercentages();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr pchName, out float pflPercent);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUserStats_RequestGlobalStats(int nHistoryDays);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetGlobalStat(IntPtr pchStatName, out long pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUserStats_GetGlobalStat_(IntPtr pchStatName, out double pData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUserStats_GetGlobalStatHistory(IntPtr pchStatName, long[] pData, uint cubData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern int ISteamUserStats_GetGlobalStatHistory_(IntPtr pchStatName, double[] pData, uint cubData);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUtils_GetSecondsSinceAppActive();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUtils_GetSecondsSinceComputerActive();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern EUniverse ISteamUtils_GetConnectedUniverse();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUtils_GetServerRealTime();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamUtils_GetIPCountry();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern byte ISteamUtils_GetCurrentBatteryPower();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern AppId_t ISteamUtils_GetAppID();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUtils_RunFrame();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUtils_GetIPCCallCount();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ISteamUtils_SetWarningMessageHook(IntPtr pFunction);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_IsOverlayEnabled();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_BOverlayNeedsPresent();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern SteamAPICall_t ISteamUtils_CheckFileSignature(IntPtr szFileName);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, IntPtr pchDescription, uint unCharMax);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint ISteamUtils_GetEnteredGamepadTextLength();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr ISteamUtils_GetSteamUILanguage();

	[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool ISteamUtils_IsSteamRunningInVR();
}
