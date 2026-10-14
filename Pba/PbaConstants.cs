using System;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000024 RID: 36
	public static class PbaConstants
	{
		// Token: 0x04000080 RID: 128
		public const string PartitionApplication = "Application";

		// Token: 0x04000081 RID: 129
		public const string PartitionSecurity = "Security";

		// Token: 0x04000082 RID: 130
		public const string PartitionNoDefined = "NoDefined";

		// Token: 0x04000083 RID: 131
		public const string VoiceAnnouncementSet = "VoiceAnnouncement";

		// Token: 0x04000084 RID: 132
		public const string VoiceAnnouncementInServerSet = "VoiceAnnouncementInServer";

		// Token: 0x04000085 RID: 133
		public const string CACertificatesSet = "CACertificates";

		// Token: 0x04000086 RID: 134
		public const string CACertificatesInServerSet = "CACertificatesInServer";

		// Token: 0x04000087 RID: 135
		public const string WelcomeBitmapSet = "WelcomeBitmap";

		// Token: 0x04000088 RID: 136
		public const string LanguagePackSet = "LanguagePackSet";

		// Token: 0x04000089 RID: 137
		public const string TTSLanguagePackSet = "TTSLanguagePackSet";

		// Token: 0x0400008A RID: 138
		public const string ProvisioningPackage = "PBBProvisioningPackage";

		// Token: 0x0400008B RID: 139
		public const string DVRSFilesSet = "DVRSFilesSet";

		// Token: 0x0400008C RID: 140
		public const string DVRSFilesInServerSet = "DVRSFilesInServerSet";

		// Token: 0x0400008D RID: 141
		public const string PBBApplicationInstall = "PBBApplicationInstall";

		// Token: 0x0400008E RID: 142
		public const string PBBApplicationUninstall = "PBBApplicationUninstall";

		// Token: 0x0400008F RID: 143
		public const string PBBProvisioningPackage = "PBBProvisioningPackage";

		// Token: 0x04000090 RID: 144
		public const string PBBHomeSetPackage = "PBBHomeSet";

		// Token: 0x04000091 RID: 145
		public const string PBBLicense = "PBBLicense";

		// Token: 0x04000092 RID: 146
		public const string BBF = "BBF";

		// Token: 0x04000093 RID: 147
		public const string FileCollectioin = "FileCollection";

		// Token: 0x04000094 RID: 148
		public const string ReadLMRCodeplugPackage = "ReadLMRCodeplugPackage";

		// Token: 0x04000095 RID: 149
		public const string FactoryReset = "FactoryReset";

		// Token: 0x04000096 RID: 150
		public const string Configuration = "Configuration";

		// Token: 0x04000097 RID: 151
		public const string WiFiList = "WiFiList";

		// Token: 0x04000098 RID: 152
		public const string WhiteList = "WhiteList";

		// Token: 0x04000099 RID: 153
		public const string APNList = "APNList";

		// Token: 0x0400009A RID: 154
		public const string SiSeries = "SiSeries";

		// Token: 0x0400009B RID: 155
		public const string SimpleTouch = "SimpleTouch";

		// Token: 0x0400009C RID: 156
		public const string PBBCertificate = "PBBCertificate";

		// Token: 0x0400009D RID: 157
		public const string PBBUninstallAllCertificate = "PBBUninstallAllCertificate";

		// Token: 0x0400009E RID: 158
		public const string PBBEnableAllCertificate = "PBBEnableAllCertificate";

		// Token: 0x0400009F RID: 159
		public const string PBBDisableAllCertificate = "PBBDisableAllCertifcate";

		// Token: 0x040000A0 RID: 160
		public const string FusionRebootPackage = "FusionRebootPackage";

		// Token: 0x040000A1 RID: 161
		public const string ProvSACConfig = "SAC";

		// Token: 0x040000A2 RID: 162
		public const string ProvTGConfig = "TG";

		// Token: 0x040000A3 RID: 163
		public const string ProvSystemConfig = "System";

		// Token: 0x040000A4 RID: 164
		public const string ProvLicenseConfig = "License";

		// Token: 0x040000A5 RID: 165
		public const string ProvAdjSites = "AdjSites";

		// Token: 0x040000A6 RID: 166
		public const string ProvMNIS = "MNIS";

		// Token: 0x040000A7 RID: 167
		public const string ProvVRC = "VRC";

		// Token: 0x040000A8 RID: 168
		public const string ProvSiteAnnouncement = "SiteAnnounce";

		// Token: 0x040000A9 RID: 169
		public const string ProvIP = "IP";

		// Token: 0x040000AA RID: 170
		public const string ProvPSK = "PSK";

		// Token: 0x040000AB RID: 171
		public const string CmbConfig = "CMB";

		// Token: 0x040000AC RID: 172
		public const string CmbGroupMapping = "TGID";

		// Token: 0x040000AD RID: 173
		public const string CmbSubscriberMapping = "SUID";

		// Token: 0x040000AE RID: 174
		public const string CmbSysSetConfig = "CmbSysSetConfig";

		// Token: 0x040000AF RID: 175
		public const string PCRTCProvFileSet = "PCRTCProvFileSet";

		// Token: 0x040000B0 RID: 176
		public const string PCRMNISProvFileSet = "PCRMNISProvFileSet";

		// Token: 0x040000B1 RID: 177
		public const string PCRVRCProvFileSet = "PCRVRCProvFileSet";

		// Token: 0x040000B2 RID: 178
		public const string PCRIPProvFileSet = "PCRIPProvFileSet";

		// Token: 0x040000B3 RID: 179
		public const string PCRLicenceFileSet = "PCRLicenceFileSet";

		// Token: 0x040000B4 RID: 180
		public const string PCRCmbConfigSet = "PCRCmbConfigSet";

		// Token: 0x040000B5 RID: 181
		public const string PCRCmbGroupMappingSet = "TalkGroupIDMappingTop";

		// Token: 0x040000B6 RID: 182
		public const string PCRCmbSubscriberMappingSet = "SubscriberIDMappingTop";

		// Token: 0x040000B7 RID: 183
		public const string CmbSysSetConfigSet = "CmbSysSetConfigSet";

		// Token: 0x040000B8 RID: 184
		public const string PCRPSKProvFileSet = "PCRPSKProvFileSet";

		// Token: 0x040000B9 RID: 185
		public const ushort FS_VA_PARTITIONID = 35;

		// Token: 0x040000BA RID: 186
		public const string FirmwareSupportedDevCfgVer = "FirmwareSupportedDevCfgVer";
	}
}
