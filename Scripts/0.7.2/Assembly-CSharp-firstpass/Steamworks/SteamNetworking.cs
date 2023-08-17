using System;

namespace Steamworks;

public static class SteamNetworking
{
	public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
	{
		return NativeMethods.ISteamNetworking_SendP2PPacket(steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
	}

	public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
	{
		return NativeMethods.ISteamNetworking_IsP2PPacketAvailable(out pcubMsgSize, nChannel);
	}

	public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
	{
		return NativeMethods.ISteamNetworking_ReadP2PPacket(pubDest, cubDest, out pcubMsgSize, out psteamIDRemote, nChannel);
	}

	public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
	{
		return NativeMethods.ISteamNetworking_AcceptP2PSessionWithUser(steamIDRemote);
	}

	public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
	{
		return NativeMethods.ISteamNetworking_CloseP2PSessionWithUser(steamIDRemote);
	}

	public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
	{
		return NativeMethods.ISteamNetworking_CloseP2PChannelWithUser(steamIDRemote, nChannel);
	}

	public static bool GetP2PSessionState(CSteamID steamIDRemote, IntPtr pConnectionState)
	{
		return NativeMethods.ISteamNetworking_GetP2PSessionState(steamIDRemote, pConnectionState);
	}

	public static bool AllowP2PPacketRelay(bool bAllow)
	{
		return NativeMethods.ISteamNetworking_AllowP2PPacketRelay(bAllow);
	}

	public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
	{
		return NativeMethods.ISteamNetworking_CreateListenSocket(nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
	}

	public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
	{
		return NativeMethods.ISteamNetworking_CreateP2PConnectionSocket(steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
	}

	public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
	{
		return NativeMethods.ISteamNetworking_CreateConnectionSocket(nIP, nPort, nTimeoutSec);
	}

	public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
	{
		return NativeMethods.ISteamNetworking_DestroySocket(hSocket, bNotifyRemoteEnd);
	}

	public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
	{
		return NativeMethods.ISteamNetworking_DestroyListenSocket(hSocket, bNotifyRemoteEnd);
	}

	public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
	{
		return NativeMethods.ISteamNetworking_SendDataOnSocket(hSocket, pubData, cubData, bReliable);
	}

	public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
	{
		return NativeMethods.ISteamNetworking_IsDataAvailableOnSocket(hSocket, out pcubMsgSize);
	}

	public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
	{
		return NativeMethods.ISteamNetworking_RetrieveDataFromSocket(hSocket, pubDest, cubDest, out pcubMsgSize);
	}

	public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
	{
		return NativeMethods.ISteamNetworking_IsDataAvailable(hListenSocket, out pcubMsgSize, out phSocket);
	}

	public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
	{
		return NativeMethods.ISteamNetworking_RetrieveData(hListenSocket, pubDest, cubDest, out pcubMsgSize, out phSocket);
	}

	public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
	{
		return NativeMethods.ISteamNetworking_GetSocketInfo(hSocket, out pSteamIDRemote, out peSocketStatus, out punIPRemote, out punPortRemote);
	}

	public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
	{
		return NativeMethods.ISteamNetworking_GetListenSocketInfo(hListenSocket, out pnIP, out pnPort);
	}

	public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
	{
		return NativeMethods.ISteamNetworking_GetSocketConnectionType(hSocket);
	}

	public static int GetMaxPacketSize(SNetSocket_t hSocket)
	{
		return NativeMethods.ISteamNetworking_GetMaxPacketSize(hSocket);
	}
}
