using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200006C RID: 108
	public interface IPBBCodeplug
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600083C RID: 2108
		// (set) Token: 0x0600083D RID: 2109
		[global::System.Runtime.Serialization.DataMember]
		string FirmwareVersion { get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600083E RID: 2110
		// (set) Token: 0x0600083F RID: 2111
		[global::System.Runtime.Serialization.DataMember]
		global::System.Guid? PBBFirmwareUuid { get; set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000840 RID: 2112
		// (set) Token: 0x06000841 RID: 2113
		[global::System.Runtime.Serialization.DataMember]
		string ProvisioningPackageName { get; set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000842 RID: 2114
		// (set) Token: 0x06000843 RID: 2115
		[global::System.Runtime.Serialization.DataMember]
		global::System.Guid? PBBProvisioningUuid { get; set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000844 RID: 2116
		// (set) Token: 0x06000845 RID: 2117
		[global::System.Runtime.Serialization.DataMember]
		global::System.Guid? PBBHomeSetUuid { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000846 RID: 2118
		// (set) Token: 0x06000847 RID: 2119
		[global::System.Runtime.Serialization.DataMember]
		bool? IsStaged { get; set; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000848 RID: 2120
		// (set) Token: 0x06000849 RID: 2121
		[global::System.Runtime.Serialization.DataMember]
		bool? IsFactoryReset { get; set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600084A RID: 2122
		// (set) Token: 0x0600084B RID: 2123
		[global::System.Runtime.Serialization.DataMember]
		byte[] UEFileContent { get; set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600084C RID: 2124
		// (set) Token: 0x0600084D RID: 2125
		[global::System.Runtime.Serialization.DataMember]
		string RetrievedLogFileName { get; set; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600084E RID: 2126
		// (set) Token: 0x0600084F RID: 2127
		[global::System.Runtime.Serialization.DataMember]
		global::Motorola.CommonCPS.Server.EntityModel.PBBFirmware PBBFirmware { get; set; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000850 RID: 2128
		// (set) Token: 0x06000851 RID: 2129
		[global::System.Runtime.Serialization.DataMember]
		global::Motorola.CommonCPS.Server.EntityModel.PBBProvisioning PBBProvisioning { get; set; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000852 RID: 2130
		// (set) Token: 0x06000853 RID: 2131
		[global::System.Runtime.Serialization.DataMember]
		global::Motorola.CommonCPS.Server.EntityModel.PBBHomeSet PBBHomeSet { get; set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000854 RID: 2132
		// (set) Token: 0x06000855 RID: 2133
		[global::System.Runtime.Serialization.DataMember]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBApplication> PBBApplications { get; set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000856 RID: 2134
		// (set) Token: 0x06000857 RID: 2135
		[global::System.Runtime.Serialization.DataMember]
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCertificate> PBBCertificates { get; set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000858 RID: 2136
		// (set) Token: 0x06000859 RID: 2137
		[global::System.Runtime.Serialization.DataMember]
		string AppCFS { get; set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600085A RID: 2138
		// (set) Token: 0x0600085B RID: 2139
		[global::System.Runtime.Serialization.DataMember]
		string AppCFSEncrypt { get; set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600085C RID: 2140
		// (set) Token: 0x0600085D RID: 2141
		[global::System.Runtime.Serialization.DataMember]
		string AppSetting { get; set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600085E RID: 2142
		// (set) Token: 0x0600085F RID: 2143
		[global::System.Runtime.Serialization.DataMember]
		string PBBFirmwareVersion { get; set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000860 RID: 2144
		// (set) Token: 0x06000861 RID: 2145
		[global::System.Runtime.Serialization.DataMember]
		string CertificateSetting { get; set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000862 RID: 2146
		// (set) Token: 0x06000863 RID: 2147
		[global::System.Runtime.Serialization.DataMember]
		string MCIFProfileName { get; set; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000864 RID: 2148
		// (set) Token: 0x06000865 RID: 2149
		[global::System.Runtime.Serialization.DataMember]
		string MCIFVersion { get; set; }
	}
}
