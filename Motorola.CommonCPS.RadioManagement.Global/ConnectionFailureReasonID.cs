using System;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x02000011 RID: 17
	public enum ConnectionFailureReasonID
	{
		// Token: 0x04000063 RID: 99
		None,
		// Token: 0x04000064 RID: 100
		ServiceNotCompatibleWithClientVersion,
		// Token: 0x04000065 RID: 101
		UserNameLoginFailed,
		// Token: 0x04000066 RID: 102
		UserNameFirstTimeLogin,
		// Token: 0x04000067 RID: 103
		WindowsCredentialLoginFailed,
		// Token: 0x04000068 RID: 104
		WinowsCredentialFirstTimeLogin,
		// Token: 0x04000069 RID: 105
		UserNotActived,
		// Token: 0x0400006A RID: 106
		CannotConnectToDiscoveryServer,
		// Token: 0x0400006B RID: 107
		CannotConnectToTargetServer,
		// Token: 0x0400006C RID: 108
		AnotherRMCDoingDBMigration,
		// Token: 0x0400006D RID: 109
		AnotherRMCDoingDBUpgrade,
		// Token: 0x0400006E RID: 110
		ConfiguredCertificateTypeNotFound,
		// Token: 0x0400006F RID: 111
		InvalidAppConfigCertificatesSection,
		// Token: 0x04000070 RID: 112
		AmbiguousCertificatesFound,
		// Token: 0x04000071 RID: 113
		JwtTokenCredentialLoginFailed,
		// Token: 0x04000072 RID: 114
		JwtTokenCredentialFirstTimeLogin,
		// Token: 0x04000073 RID: 115
		JwtTokenCredentialInvalid
	}
}
