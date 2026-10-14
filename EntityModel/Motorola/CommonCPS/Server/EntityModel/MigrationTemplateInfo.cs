using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000131 RID: 305
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationTemplateInfo
	{
		// Token: 0x0600119A RID: 4506 RVA: 0x000BC29C File Offset: 0x000BA49C
		public MigrationTemplateInfo()
		{
			this.ReferencedRadioList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioBaseInfo>();
			this.IsTemplateExist = false;
			this.PCRLanguageList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack>();
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x000BC2CC File Offset: 0x000BA4CC
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x000BC37C File Offset: 0x000BA57C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid TemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)624706839;
				short num2 = num;
				num = (short)1762805015;
				switch (num2 == num)
				{
				}
				num = (short)742981633;
				if (num != 0)
				{
				}
				num = (short)2078670848;
				short num3 = num;
				num = (short)550305792;
				if (num != 0)
				{
				}
				return this.<TemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)372011445;
				short num2 = num;
				num = (short)1223127477;
				switch (num2 == num)
				{
				}
				num = (short)1720778752;
				if (num != 0)
				{
				}
				num = (short)116654080;
				short num3 = num;
				num = (short)506068993;
				if (num != 0)
				{
				}
				this.<TemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000BC42C File Offset: 0x000BA62C
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x000BC4E0 File Offset: 0x000BA6E0
		[global::System.Runtime.Serialization.DataMember]
		public string TemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1234553019;
				short num2 = num;
				num = (short)292210875;
				switch (num2 == num)
				{
				}
				num = (short)184942592;
				if (num != 0)
				{
				}
				num = (short)715718656;
				short num3 = num;
				num = (short)1109196801;
				if (num != 0)
				{
				}
				return this.<TemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1553866874;
				short num2 = num;
				num = (short)26419322;
				switch (num2 == num)
				{
				}
				num = (short)1183121409;
				if (num != 0)
				{
				}
				num = (short)1228341248;
				short num3 = num;
				num = (short)1493565440;
				if (num != 0)
				{
				}
				this.<TemplateName>k__BackingField = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000BC590 File Offset: 0x000BA790
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x000BC640 File Offset: 0x000BA840
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid ArchiveFileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1579608661;
				short num2 = num;
				num = (short)513141333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180237824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282277376;
				if (num != 0)
				{
				}
				num = (short)763297793;
				if (num != 0)
				{
				}
				return this.<ArchiveFileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)619066071;
				short num2 = num;
				num = (short)567685847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1028980736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2065367040;
				if (num != 0)
				{
				}
				num = (short)1986789377;
				if (num != 0)
				{
				}
				this.<ArchiveFileUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000BC6F4 File Offset: 0x000BA8F4
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x000BC7A4 File Offset: 0x000BA9A4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid LanguagePackUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1810938589;
				short num2 = num;
				num = (short)206420701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467482112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400700928;
				if (num != 0)
				{
				}
				num = (short)1114963969;
				if (num != 0)
				{
				}
				return this.<LanguagePackUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1608758101;
				short num2 = num;
				num = (short)1432073045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119027200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405078016;
				if (num != 0)
				{
				}
				num = (short)1308884993;
				if (num != 0)
				{
				}
				this.<LanguagePackUuid>k__BackingField = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x000BC858 File Offset: 0x000BAA58
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x000BC904 File Offset: 0x000BAB04
		[global::System.Runtime.Serialization.DataMember]
		public bool IsTemplateExist
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)558510187;
				short num2 = num;
				num = (short)1650274411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1725628416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452853761;
				if (num != 0)
				{
				}
				num = (short)1512112128;
				if (num != 0)
				{
				}
				return this.<IsTemplateExist>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1823526389;
				short num2 = num;
				num = (short)1206570485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990918144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625147904;
				if (num != 0)
				{
				}
				num = (short)331481089;
				if (num != 0)
				{
				}
				this.<IsTemplateExist>k__BackingField = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x000BC9B8 File Offset: 0x000BABB8
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x000BCA68 File Offset: 0x000BAC68
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioBaseInfo> ReferencedRadioList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)99677934;
				short num2 = num;
				num = (short)310245102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)210042880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136604673;
				if (num != 0)
				{
				}
				num = (short)1236992000;
				if (num != 0)
				{
				}
				return this.<ReferencedRadioList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1164950184;
				short num2 = num;
				num = (short)1608497832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492451328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546045952;
				if (num != 0)
				{
				}
				num = (short)1827733505;
				if (num != 0)
				{
				}
				this.<ReferencedRadioList>k__BackingField = value;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000BCB20 File Offset: 0x000BAD20
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePack> PCRLanguageList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1635805469;
				short num2 = num;
				num = (short)1953851677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1442119680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2002714624;
				if (num != 0)
				{
				}
				num = (short)2007564289;
				if (num != 0)
				{
				}
				return this.<PCRLanguageList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1996947810;
				short num2 = num;
				num = (short)1295450466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155661824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)835780609;
				if (num != 0)
				{
				}
				num = (short)1795162112;
				if (num != 0)
				{
				}
				this.<PCRLanguageList>k__BackingField = value;
			}
		}
	}
}
