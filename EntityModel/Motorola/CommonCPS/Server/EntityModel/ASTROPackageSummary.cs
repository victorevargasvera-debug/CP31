using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200014E RID: 334
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))]
	[global::System.Serializable]
	public class ASTROPackageSummary : global::Motorola.CommonCPS.Server.EntityModel.PackageSummary
	{
		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000C60FC File Offset: 0x000C42FC
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x000C61AC File Offset: 0x000C43AC
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1337769401;
				short num2 = num;
				num = (short)1626455481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)822280192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1214119936;
				if (num != 0)
				{
				}
				num = (short)506920961;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1811947011;
				short num2 = num;
				num = (short)5185027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942800896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529741312;
				if (num != 0)
				{
				}
				num = (short)1942290433;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000C625C File Offset: 0x000C445C
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x000C630C File Offset: 0x000C450C
		[global::System.Runtime.Serialization.DataMember]
		public string PackageDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)850001921;
				if (num != 0)
				{
				}
				num = (short)1511129088;
				short num2 = num;
				num = (short)846383415;
				short num3 = num;
				num = (short)1636616503;
				switch (num3 == num)
				{
				}
				num = (short)587792384;
				if (num != 0)
				{
				}
				return this.<PackageDescription>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)857117457;
				short num2 = num;
				num = (short)1835701009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1753153536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572063745;
				if (num != 0)
				{
				}
				num = (short)1843920896;
				if (num != 0)
				{
				}
				this.<PackageDescription>k__BackingField = value;
			}
		}
	}
}
