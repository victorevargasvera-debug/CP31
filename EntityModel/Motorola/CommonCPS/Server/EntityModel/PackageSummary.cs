using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000147 RID: 327
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBHomeSetPackageSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBPackageSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBCertificateSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncementSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificatesSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePackSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmwareSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROPackageSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBFirmwareSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.GeneralPackageSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRVoiceAnnouncementSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroupSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFilesSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ASTROTTSVoiceAnnouncementSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcutSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationWidgetSummary))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.PCRTextToSpeechSummary))]
	[global::System.Serializable]
	public class PackageSummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000C2D88 File Offset: 0x000C0F88
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x000C2E3C File Offset: 0x000C103C
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1396047872;
				short num2 = num;
				num = (short)2056153922;
				short num3 = num;
				num = (short)6122306;
				switch (num3 == num)
				{
				}
				num = (short)956301313;
				if (num != 0)
				{
				}
				num = (short)1914634240;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)529334272;
				short num2 = num;
				num = (short)1619255314;
				short num3 = num;
				num = (short)76013586;
				switch (num3 == num)
				{
				}
				num = (short)1150615553;
				if (num != 0)
				{
				}
				num = (short)1743454208;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x000C2EEC File Offset: 0x000C10EC
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x000C2F9C File Offset: 0x000C119C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)617762405;
				short num2 = num;
				num = (short)1106333285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208470016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1498087425;
				if (num != 0)
				{
				}
				num = (short)709296128;
				if (num != 0)
				{
				}
				return this.<FileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)748492602;
				short num2 = num;
				num = (short)1708922682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1007616000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1787887616;
				if (num != 0)
				{
				}
				num = (short)1484455937;
				if (num != 0)
				{
				}
				this.<FileUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x000C304C File Offset: 0x000C124C
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x000C30FC File Offset: 0x000C12FC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? CreatedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)789577729;
				if (num != 0)
				{
				}
				num = (short)886374400;
				short num2 = num;
				num = (short)1656472161;
				short num3 = num;
				num = (short)2043658849;
				switch (num3 == num)
				{
				}
				num = (short)1631846400;
				if (num != 0)
				{
				}
				return this.<CreatedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)275513345;
				if (num != 0)
				{
				}
				num = (short)463470592;
				short num2 = num;
				num = (short)1049219980;
				short num3 = num;
				num = (short)583914380;
				switch (num3 == num)
				{
				}
				num = (short)169541632;
				if (num != 0)
				{
				}
				this.<CreatedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x000C31B0 File Offset: 0x000C13B0
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x000C3264 File Offset: 0x000C1464
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ModifiedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)734922795;
				short num2 = num;
				num = (short)1511196715;
				switch (num2 == num)
				{
				default:
				{
					num = (short)571801600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989659137;
				if (num != 0)
				{
				}
				num = (short)2026045440;
				if (num != 0)
				{
				}
				return this.<ModifiedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)114694732;
				short num2 = num;
				num = (short)1406540364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431240704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429143553;
				if (num != 0)
				{
				}
				num = (short)56819712;
				if (num != 0)
				{
				}
				this.<ModifiedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x000C3314 File Offset: 0x000C1514
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x000C33C8 File Offset: 0x000C15C8
		[global::System.Runtime.Serialization.DataMember]
		public string Comment
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1373148620;
				short num2 = num;
				num = (short)354588108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721499648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5242880;
				if (num != 0)
				{
				}
				num = (short)402456577;
				if (num != 0)
				{
				}
				return this.<Comment>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)192918424;
				short num2 = num;
				num = (short)1186509720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929562624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1919483904;
				if (num != 0)
				{
				}
				num = (short)541982721;
				if (num != 0)
				{
				}
				this.<Comment>k__BackingField = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x000C3478 File Offset: 0x000C1678
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x000C3528 File Offset: 0x000C1728
		[global::System.Runtime.Serialization.DataMember]
		public int? FileSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1538663891;
				short num2 = num;
				num = (short)68167123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)816775168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800142849;
				if (num != 0)
				{
				}
				num = (short)1749155840;
				if (num != 0)
				{
				}
				return this.<FileSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2095294663;
				short num2 = num;
				num = (short)1244113095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)108199936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40239104;
				if (num != 0)
				{
				}
				num = (short)748683265;
				if (num != 0)
				{
				}
				this.<FileSize>k__BackingField = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x000C35D4 File Offset: 0x000C17D4
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x000C3684 File Offset: 0x000C1884
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PackageUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)149031896;
				short num2 = num;
				num = (short)1001786328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119996416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327628289;
				if (num != 0)
				{
				}
				num = (short)2035679232;
				if (num != 0)
				{
				}
				return this.<PackageUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)373741047;
				short num2 = num;
				num = (short)16766455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784741888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2101215233;
				if (num != 0)
				{
				}
				num = (short)88014848;
				if (num != 0)
				{
				}
				this.<PackageUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x000C3734 File Offset: 0x000C1934
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x000C37E4 File Offset: 0x000C19E4
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1258160129;
				if (num != 0)
				{
				}
				num = (short)1460076544;
				short num2 = num;
				num = (short)929305477;
				short num3 = num;
				num = (short)298652549;
				switch (num3 == num)
				{
				}
				num = (short)212664320;
				if (num != 0)
				{
				}
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1735348664;
				short num2 = num;
				num = (short)1285902776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379074048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686765569;
				if (num != 0)
				{
				}
				num = (short)1743585280;
				if (num != 0)
				{
				}
				this.<ReferenceCount>k__BackingField = value;
			}
		}
	}
}
