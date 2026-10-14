using System;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x02000003 RID: 3
	public class Constants
	{
		// Token: 0x04000003 RID: 3
		public const string NameTypeName = "Name";

		// Token: 0x04000004 RID: 4
		public const string RoleTypeName = "Role";

		// Token: 0x04000005 RID: 5
		public const string AppIdTypeName = "AppId";

		// Token: 0x04000006 RID: 6
		public const string AgencyIdTypeName = "AgencyId";

		// Token: 0x04000007 RID: 7
		public const string RelyingPartyTypeName = "RelyingPartyType";

		// Token: 0x04000008 RID: 8
		public const string HostnameTypeName = "Hostname";

		// Token: 0x04000009 RID: 9
		public const string UsernameTypeName = "Username";

		// Token: 0x0400000A RID: 10
		public const string AuthCredentialTypeName = "AuthCredentialTypeName";

		// Token: 0x0400000B RID: 11
		public const string OneTimePasswordTypeName = "OneTimePasswordTypeName";

		// Token: 0x0400000C RID: 12
		public const string FingerprintTypeName = "FingerprintTypeName";

		// Token: 0x0400000D RID: 13
		public const string ActivatingName = "ActivatingName";

		// Token: 0x0400000E RID: 14
		public const string JwtTokenName = "JwtTokenName";

		// Token: 0x0400000F RID: 15
		public const string HostSidTypeName = "HostSidTypeName";

		// Token: 0x04000010 RID: 16
		public const string ServerHostIdTypeName = "ServerHostId";

		// Token: 0x04000011 RID: 17
		public const string SystemKeyTypeName = "SystemKey";

		// Token: 0x04000012 RID: 18
		public const string PermissionTypeName = "Permission";

		// Token: 0x04000013 RID: 19
		public const string UploadSystemKeyPermision = "Allow upload of System Key to Server";

		// Token: 0x04000014 RID: 20
		public const string ClaimsTypeName = "claims";

		// Token: 0x04000015 RID: 21
		public const string Prefix = "cps";

		// Token: 0x04000016 RID: 22
		public const string CustomTypeName = "Custom";

		// Token: 0x04000017 RID: 23
		public const int NEG_1 = -1;

		// Token: 0x04000018 RID: 24
		public const string USER_NOT_ACTIVATED = "USER_NOT_ACTIVATED";

		// Token: 0x04000019 RID: 25
		public const string MACHINE_NOT_ACTIVATED = "MACHINE_NOT_ACTIVATED";

		// Token: 0x0400001A RID: 26
		public const string SYSTEM_KEY_ALREADY_EXISTS = "SYSTEM_KEY_ALREADY_EXISTS";

		// Token: 0x0400001B RID: 27
		public const string SECURITY_TOKEN_REQUEST_WAS_DENIED = "SECURITY_TOKEN_REQUEST_WAS_DENIED";

		// Token: 0x0400001C RID: 28
		public const string FINGERPRINT_VALIDATE_FAILED = "FINGERPRINT_VALIDATE_FAILED";

		// Token: 0x0400001D RID: 29
		public const string ID_TOKEN_IS_INVALID = "Invalid Authentication Token";

		// Token: 0x0400001E RID: 30
		public const string SystemClaimsNamspace = "http://schemas.xmlsoap.org/ws/2005/05/Identity/claims";

		// Token: 0x0400001F RID: 31
		public const string SystemClaimTypeName = "http://schemas.xmlsoap.org/ws/2005/05/Identity/claims/Name";

		// Token: 0x04000020 RID: 32
		public const string StsNamespace = "http://commoncps/RMIdP/sts";

		// Token: 0x04000021 RID: 33
		public const string StsClaimNamespace = "http://commoncps/RMIdP/sts/claims";

		// Token: 0x04000022 RID: 34
		public const string StsClaimTypeAppId = "http://commoncps/RMIdP/sts/claims/AppId";

		// Token: 0x04000023 RID: 35
		public const string StsClaimTypeAgencyId = "http://commoncps/RMIdP/sts/claims/AgencyId";

		// Token: 0x04000024 RID: 36
		public const string StsClaimRelyingPartyType = "http://commoncps/RMIdP/sts/claims/RelyingPartyType";

		// Token: 0x04000025 RID: 37
		public const string StsClaimTypeHostname = "http://commoncps/RMIdP/sts/claims/Hostname";

		// Token: 0x04000026 RID: 38
		public const string StsClaimTypeUsername = "http://commoncps/RMIdP/sts/claims/Username";

		// Token: 0x04000027 RID: 39
		public const string StsClaimTypeAuthCredentialType = "http://commoncps/RMIdP/sts/claims/AuthCredentialTypeName";

		// Token: 0x04000028 RID: 40
		public const string StsClaimTypeOneTimePassword = "http://commoncps/RMIdP/sts/claims/OneTimePasswordTypeName";

		// Token: 0x04000029 RID: 41
		public const string StsClaimTypeFingerprint = "http://commoncps/RMIdP/sts/claims/FingerprintTypeName";

		// Token: 0x0400002A RID: 42
		public const string StsClaimTypeActivating = "http://commoncps/RMIdP/sts/claims/ActivatingName";

		// Token: 0x0400002B RID: 43
		public const string StsClaimTypeHostSid = "http://commoncps/RMIdP/sts/claims/HostSidTypeName";

		// Token: 0x0400002C RID: 44
		public const string StsClaimTypeServerHostId = "http://commoncps/RMIdP/sts/claims/ServerHostId";

		// Token: 0x0400002D RID: 45
		public const string StsClaimTypeRole = "http://commoncps/RMIdP/sts/claims/Role";

		// Token: 0x0400002E RID: 46
		public const string StsClaimTypePermission = "http://commoncps/RMIdP/sts/claims/Permission";

		// Token: 0x0400002F RID: 47
		public const string StsClaimTypeSystemKey = "http://commoncps/RMIdP/sts/claims/SystemKey";

		// Token: 0x04000030 RID: 48
		public const string StsClaimJwtToken = "http://commoncps/RMIdP/sts/claims/JwtTokenName";

		// Token: 0x04000031 RID: 49
		public const string DiscoveryNamespace = "rm://discovery";

		// Token: 0x04000032 RID: 50
		public const string COMPATIBLE_CLIENTS = "CompatibleClients";

		// Token: 0x04000033 RID: 51
		public const string COMPATIBLE_CLIENT = "CompatibleClient";

		// Token: 0x04000034 RID: 52
		public const string HOST = "host";

		// Token: 0x04000035 RID: 53
		public const string WEBSOCKET_ENABLED = "websocketEnabled";

		// Token: 0x04000036 RID: 54
		public const string TYPE = "type";

		// Token: 0x04000037 RID: 55
		public const string RM_VERSION = "rmversion";

		// Token: 0x04000038 RID: 56
		public const string MIN_RM_VERSION = "minrmversion";

		// Token: 0x04000039 RID: 57
		public const string MAX_RM_VERSION = "maxrmversion";

		// Token: 0x0400003A RID: 58
		public const string EXCLUDED_RM_VERSIONS = "excludedrmversions";

		// Token: 0x0400003B RID: 59
		public const string ID = "id";

		// Token: 0x0400003C RID: 60
		public const string INFO = "info";

		// Token: 0x0400003D RID: 61
		public const string UTC_TICKS = "utcticks";

		// Token: 0x0400003E RID: 62
		public const string SERVER = "server";

		// Token: 0x0400003F RID: 63
		public const string END_POINTS = "Endpoints";

		// Token: 0x04000040 RID: 64
		public const string SERVICE_ENDPOINT = "ServiceEndpoint";

		// Token: 0x04000041 RID: 65
		public const string SERVICE_METADATA = "Metadata";

		// Token: 0x04000042 RID: 66
		public const string AUTOUPDATE = "autoupdate";

		// Token: 0x04000043 RID: 67
		public const string STATUS = "status";

		// Token: 0x04000044 RID: 68
		public const string INSTANCE = "instance";

		// Token: 0x04000045 RID: 69
		public const string DBNAME = "dbname";

		// Token: 0x04000046 RID: 70
		public const string ADDRESS = "address";

		// Token: 0x04000047 RID: 71
		public const string CONTRACT = "contract";

		// Token: 0x04000048 RID: 72
		public const string DISCOVERY_SERVICE_MAP = "DiscoveryServiceMap";

		// Token: 0x04000049 RID: 73
		public const string DATABASE_CONNECTION = "DatabaseConnection";

		// Token: 0x0400004A RID: 74
		public const string SERVER_INFO = "ServerInfo";

		// Token: 0x0400004B RID: 75
		public const string VERSION_INFO = "VersionInfo";

		// Token: 0x0400004C RID: 76
		public const string DB_CONNECTION_INFO = "DbConnectionInfo";

		// Token: 0x0400004D RID: 77
		public const string UPGRADE_PATH = "UpgradePath";

		// Token: 0x0400004E RID: 78
		public const string ONLINE = "Online";

		// Token: 0x0400004F RID: 79
		public const string OFFLINE = "Offline";

		// Token: 0x04000050 RID: 80
		public const char CONTRACT_NAMESPACE_DELIMITER = ':';

		// Token: 0x04000051 RID: 81
		public const string RMSERVER = "RMServer";

		// Token: 0x04000052 RID: 82
		public const string JOBSERVER = "RMJobServer";
	}
}
